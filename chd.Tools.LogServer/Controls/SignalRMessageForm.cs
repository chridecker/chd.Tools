using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using chd.Tools.LogServer.Model;

namespace chd.Tools.LogServer.Controls
{
    public partial class SignalRMessageForm
        //where TMessage : SignalRMessage
    {
        protected SignalRMessage _message;
        public SignalRMessageForm(SignalRMessage message)
        {
            _message = message;
            InitializeComponent();
            this.textBox1.Text = message.Data;
        }
    }
}
