using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    class EditorTabPage : TabPage
    {
        public String FilePath { get; private set; }
        public bool PrimarySaved { get; private set; }
        public bool Saved { get; set; }
        public RichTextBox TextBox { get; private set; }
        public RichTextBoxStreamType TextType { get; set; }

        private void InitializeTextBox()
        {
            TextBox = new RichTextBox();
            TextBox.Dock = DockStyle.Fill;
            Controls.Add(TextBox);
        }

        public EditorTabPage()
        {
            InitializeTextBox();
            Text = "* new";
            Saved = false;
            PrimarySaved = false;
        }

        public EditorTabPage(string filename)
        {
            InitializeTextBox();
            TextBox.Text = System.IO.File.ReadAllText(filename);
            Text = Path.GetFileName(filename);
            PrimarySaved = true;
            Saved = true;
            FilePath = filename;
        }

        public void SaveFile()
        {
            TextBox.SaveFile(this.FilePath, TextType);
            Saved = true;
            Text = Path.GetFileName(FilePath);
        }

        public void SaveFile(string filename)
        {
            FilePath = filename;
            SaveFile();
            PrimarySaved = true;
        }
    }
}
