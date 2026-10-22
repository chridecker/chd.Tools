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

        private void DgvMessages_CellContentDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (bindingSourceMessage.Current is SignalRMessage message)
            {

            }
        }

        public void SetDto(SignalRConnectionDto dto)
        {
            this.bindingSourceDto.DataSource = dto;
            dgvHeaders.DataSource = dto.Headers
                .Select(h => new
                {
                    Name = h.Key,
                    Value = h.Value
                })
                .ToList();
        }
    }
}
