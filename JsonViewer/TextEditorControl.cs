using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPocalipse.Json.Viewer
{
    public class TextEditorControl : ICSharpCode.TextEditor.TextEditorControl
    {
        /// <summary>
        /// 从剪切板复制内容到文本框
        /// </summary>
        public void Paste()
        {
            string text = Clipboard.GetText();
            if (string.IsNullOrWhiteSpace(text) == true) return;

            this.Text = text;
        }

        /// <summary>
        /// 复制文件到剪切板
        /// </summary>
        public void Copy()
        {
            if (string.IsNullOrWhiteSpace(this.Text) == true) return;

            Clipboard.SetText(this.Text);
        }

        public void Cut()
        {

        }

        public void SelectAll()
        {

        }

    }
}
