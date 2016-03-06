//    Copyright(C) 2015/2016 Alcatraz Developer
//
//    This file is part of NetSeal Helper
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.If not, see<http://www.gnu.org/licenses/>.

using System;
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

            var color = Color.Empty;

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
                default: color = InformationColor;
                    break;
            }

            _richTextBox.Select(_richTextBox.Text.Length, _richTextBox.Text.Length + message.Length);
            _richTextBox.SelectionColor = color;            
            _richTextBox.AppendText(message + Environment.NewLine);
            _richTextBox.ScrollToCaret();
        }

        public void Clear()
        {
            this._richTextBox.Clear();
        }
    }
}