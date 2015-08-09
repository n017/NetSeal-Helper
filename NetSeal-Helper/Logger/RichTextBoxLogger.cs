using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace NetSeal_Helper.Logger
{
    class RichTextBoxLogger : ILogger
    {
        private RichTextBox _richTextBox;

        private int _timeColor = SystemColors.GradientInactiveCaption.ToArgb();
        private int _informationColor = Color.DeepSkyBlue.ToArgb();
        private int _errorColor = Color.Peru.ToArgb();
        private int _warningColor = Color.LightGoldenrodYellow.ToArgb();

        public Color TimeColor
        {
            get { return Color.FromArgb(_timeColor); }
            set { _timeColor = value.ToArgb(); }
        }
        public Color InformationColor
        {
            get { return Color.FromArgb(_informationColor); }
            set { _informationColor = value.ToArgb(); }
        }
        public Color ErrorColor
        {
            get { return Color.FromArgb(_errorColor); }
            set { _errorColor = value.ToArgb(); }
        }
        public Color WarningColor
        {
            get { return Color.FromArgb(_warningColor); }
            set { _warningColor = value.ToArgb(); }
        }

        public RichTextBoxLogger(RichTextBox richTextBox)
        {
            this._richTextBox = richTextBox;
        }

        public void Log(string message, LoggingEventType eventType)
        {
            if (_richTextBox.InvokeRequired)
            {
                _richTextBox.Invoke((MethodInvoker)(() =>
                {
                    LogBase(message, eventType);
                }));
            }
            else
            {
                LogBase(message, eventType);                
            }
        }
        private void LogBase(string message, LoggingEventType eventType)
        {
            string time = string.Empty;
            time = DateTime.Now.ToString("HH:mm");
            _richTextBox.Select(_richTextBox.Text.Length, _richTextBox.Text.Length + time.Length);
            _richTextBox.SelectionColor = TimeColor;
            _richTextBox.AppendText("[");
            _richTextBox.AppendText(time);
            _richTextBox.AppendText("]");
            _richTextBox.AppendText(" ");

            var color = Color.DeepSkyBlue;

            switch (eventType)
            {
                case LoggingEventType.Information:
                    color = InformationColor;
                    break;
                case LoggingEventType.Error:
                    color = ErrorColor;
                    break;
                case LoggingEventType.Warning:
                    color = WarningColor;
                    break;
                default: color = Color.DeepSkyBlue;
                    break;
            }

            _richTextBox.Select(_richTextBox.Text.Length, _richTextBox.Text.Length + message.Length);
            _richTextBox.SelectionColor = color;            
            _richTextBox.AppendText(message + "\r\n");
            _richTextBox.ScrollToCaret();
        }
        public void Clear()
        {
            this._richTextBox.Clear();
        }
    }
}