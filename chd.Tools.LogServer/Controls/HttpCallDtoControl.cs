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
        }
        [Browsable(false)]
        public Model.HttpCallDto? Dto
        {
            get => bindingSourceDto.DataSource as Model.HttpCallDto;
            set
            {
                bindingSourceDto.DataSource = value;

                dgvHeaders.DataSource = value?.Headers
                    .Select(x => new HeaderEntry
                    {
                        Name = x.Key,
                        Value = x.Value
                    })
                    .ToList();
            }
        }

        private sealed class HeaderEntry
        {
            public string Name { get; set; } = "";
            public string Value { get; set; } = "";
        }
    }


}
