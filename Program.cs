using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class Page
    {
        public Page()
        {
            Saved = false;
            PrimarySaved = false;
        }
        public Page(TabPage tab, RichTextBox textBox):this()
        {
            Tab = tab;
            TextBox = textBox;
        }

        public String FilePath { get; set; }
        public bool PrimarySaved { get; set;  }
        public bool Saved { get; set; }
        public TabPage Tab { get; set; }
        public RichTextBox TextBox { get; set; }
    }
}
