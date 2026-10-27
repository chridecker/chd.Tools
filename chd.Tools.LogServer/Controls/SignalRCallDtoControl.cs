using chd.Tools.LogServer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.WebSockets;
using System.Text;
using System.Windows.Forms;

namespace chd.Tools.LogServer.Controls
{
    public partial class SignalRCallDtoControl : UserControl
    {
        private SignalRConnectionDto _dto => bindingSourceDto.Current as SignalRConnectionDto;
        public SignalRCallDtoControl()
        {
            InitializeComponent();
            foreach (var comp in this.tableLayoutPanel1.Controls)
            {
                if (comp is TextBox tb)
                {
                    tb.Dock = DockStyle.Fill;
                    tb.ReadOnly = true;
                }
            }
            dgvMessages.CellContentDoubleClick += DgvMessages_CellContentDoubleClick;
        }

        private async void DgvMessages_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (bindingSourceMessage.Current is SignalRMessage message)
            {
                if (message is SignalRStreamInvokationMessage stream)
                {
                    await this._dto.SendStreamItem(stream.InvocationId, 1, CancellationToken.None);
                }
                else if (message is SignalRStreamItemMessage item)
                {
                    await this._dto.SendCompletionItem(item.InvocationId, CancellationToken.None);
                }
                var form = new SignalRMessageForm(message);
                form.Show(this);
            }
        }

        public void SetDto(SignalRConnectionDto dto)
        {
            dto.MessageReceived += Dto_MessageReceived;
            this.bindingSourceDto.DataSource = dto;
            dgvHeaders.DataSource = dto.Headers
                .Select(h => new
                {
                    Name = h.Key,
                    Value = h.Value
                })
                .ToList();
        }

        private void Dto_MessageReceived(object? sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(() => bindingSourceDto.ResetBindings(true));
            }
            else
            {
                bindingSourceDto.ResetBindings(true);

            }
        }
    }
}
