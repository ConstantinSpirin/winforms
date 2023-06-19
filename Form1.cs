using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        List<Page> pages = new List<Page>();

        public Form1()
        {
            InitializeComponent();
            this.tabControl.MouseClick += new MouseEventHandler(tabControl_MouseClick);
        }

        private void menuItemCreate_Click(object sender, EventArgs e)
        {
            TabPage tabPage = new TabPage("*new");
            RichTextBox richTextBox = new RichTextBox();
            Page page = new Page(tabPage, richTextBox);

            richTextBox.TextChanged += new EventHandler(richTextBox_TextChanged);

            richTextBox.Dock = DockStyle.Fill;
            pages.Add(page);
            tabControl.SelectedTab = tabPage;
            tabControl.TabPages.Add(tabPage);
            tabPage.Controls.Add(richTextBox);
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                TabPage tabPage = new TabPage(Path.GetFileName(filename));
                RichTextBox richTextBox = new RichTextBox();
                Page page = new Page(tabPage, richTextBox);
                page.Saved = true;
                page.PrimarySaved = true;
                page.TextBox = richTextBox;
                page.Tab = tabPage;
                page.FilePath = filename;

                string content = System.IO.File.ReadAllText(filename);

                richTextBox.Text = content;

                richTextBox.TextChanged += new EventHandler(richTextBox_TextChanged);

                richTextBox.Dock = DockStyle.Fill;
                pages.Add(page);
                tabControl.SelectedTab = tabPage;
                tabControl.TabPages.Add(tabPage);
                tabPage.Controls.Add(richTextBox);
            }
        }

        private void toolBtnCreate_Click(object sender, EventArgs e)
        {
            menuItemCreate_Click(sender, e);
        }

        private void tabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            if (tabControl.Controls.Count > 0)
            {
                tabControl.Visible = true;
            }
            statusLabel.Text = "new document created";
        }

        private void tabControl_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (tabControl.Controls.Count == 0)
            {
                tabControl.Visible = false;
            }
        }

        private void tabControl_MouseClick(object sender, MouseEventArgs e)
        {

            for (int ix = 0; ix < tabControl.TabCount; ++ix)
            {
                if (tabControl.GetTabRect(ix).Contains(e.Location))
                {
                    tabControl.SelectedIndex = ix;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip.Show(this.tabControl, e.Location);
            }
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = tabControl.SelectedIndex;
            if (pages[index].Saved)
            {
                RichTextBox textBox = (RichTextBox)sender;
                pages[index].Tab.Text = "* " + pages[index].Tab.Text;
                pages[index].Saved = false;
            }
        }

        private void closeTabPageContextMenuItem_Click(object sender, EventArgs e)
        {
            TabPage selectedTab = tabControl.SelectedTab;
            int index = tabControl.SelectedIndex;
            if (pages[index].Saved)
            {
                tabControl.TabPages.Remove(selectedTab);
            }
            else
            {
                var confirmResult = MessageBox.Show("Сохранить файл перед закрытием?", "Предупреждение", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    menuItemSave_Click(null, null);
                }
                tabControl.TabPages.Remove(selectedTab);
            }
            
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            int index = tabControl.SelectedIndex;
            Page page = pages[index];
            if (page.PrimarySaved)
            {
                string filename = page.FilePath;
                string content = page.TextBox.Text;
                System.IO.File.WriteAllText(filename, content);
                page.Saved = true;
                page.Tab.Text = Path.GetFileName(filename);
                statusLabel.Text = "Файл сохранен";
            }
            else
            {
                menuItemSaveAs_Click(sender, e);
            }
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстовые документы (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                int index = tabControl.SelectedIndex;
                Page page = pages[index];
                string filename = saveFileDialog.FileName;
                page.FilePath = filename;
                string content = page.TextBox.Text;
                System.IO.File.WriteAllText(filename, content);
                page.Tab.Text = Path.GetFileName(filename);
                page.Saved = true;
                page.PrimarySaved = true;
                page.FilePath = filename;
                statusLabel.Text = "Файл сохранен";
            }
        }

        private void toolBtnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                int index = tabControl.SelectedIndex;
                Page page = pages[index];
                page.TextBox.SelectionFont = fontDialog.Font;
            }
        }
    }
}
