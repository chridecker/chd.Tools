using chd.Tools.LogServer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace chd.Tools.LogServer.Controls
{
    public partial class HttpCallDtoControl : UserControl
    {
        public HttpCallDtoControl()
        {
            InitializeComponent();
            foreach (var comp in this.tableLayoutPanel.Controls)
            {
                if (comp is TextBox tb)
                {
                    tb.Dock = DockStyle.Fill;
                    tb.ReadOnly = true;
                }
            }
            foreach (var comp in this.grpBody.Controls)
            {
                if (comp is TextBox tb)
                {
                    tb.Dock = DockStyle.Fill;
                    tb.ReadOnly = true;
                }
            }
        }

        public void SetDto(HttpCallDto dto)
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
