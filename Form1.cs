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
        public Form1()
        {
            InitializeComponent();
            this.tabControl.MouseClick += new MouseEventHandler(tabControl_MouseClick);
        }

        private void menuItemCreate_Click(object sender, EventArgs e)
        {
            EditorTabPage tabPage = new EditorTabPage();
            tabPage.TextBox.TextChanged += new EventHandler(richTextBox_TextChanged);
            tabControl.SelectedTab = tabPage;
            tabControl.TabPages.Add(tabPage);
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                EditorTabPage tabPage = new EditorTabPage(openFileDialog.FileName);
                tabPage.TextBox.TextChanged += new EventHandler(richTextBox_TextChanged);
                tabControl.SelectedTab = tabPage;
                tabControl.TabPages.Add(tabPage);
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
            EditorTabPage selectedTab = (EditorTabPage)tabControl.SelectedTab;
            if (selectedTab.Saved)
            {
                selectedTab.Text = "* " + selectedTab.Text;
                selectedTab.Saved = false;
            }
        }

        private void closeTabPageContextMenuItem_Click(object sender, EventArgs e)
        {
            EditorTabPage selectedTab = (EditorTabPage)tabControl.SelectedTab;
            if (selectedTab.Saved)
            {
                tabControl.TabPages.Remove(selectedTab);
            }
            else
            {
                var confirmResult = MessageBox.Show("Сохранить файл " + selectedTab.FilePath + " перед закрытием?", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (confirmResult)
                {
                    case DialogResult.Yes:
                        if (Save(selectedTab))
                        {
                            tabControl.TabPages.Remove(selectedTab);
                        }
                        break;
                    case DialogResult.No:
                        tabControl.TabPages.Remove(selectedTab);
                        break;
                    default:
                        break;
                }
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            EditorTabPage selectedTab = (EditorTabPage)tabControl.SelectedTab;
            if (Save(selectedTab))
            {
                statusLabel.Text = "Файл сохранен";
            }
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            EditorTabPage selectedTab = (EditorTabPage)tabControl.SelectedTab;
            if (SaveAs(selectedTab))
            {
                statusLabel.Text = "Файл сохранен";
            }
        }

        private bool Save(EditorTabPage tabPage)
        {
            if (tabPage.PrimarySaved)
            {
                tabPage.SaveFile();
                statusLabel.Text = "Файл сохранен";
                return true;
            }
            else
            {
                return SaveAs(tabPage);
            }
        }

        private bool SaveAs(EditorTabPage tabPage)
        {
            saveFileDialog.Filter = "Текстовые документы (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                tabPage.SaveFile(saveFileDialog.FileName);
                return true;
            } else
            {
                return false;
            }
        }

        private void toolBtnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                EditorTabPage selectedTab = (EditorTabPage)tabControl.SelectedTab;
                selectedTab.TextBox.SelectionFont = fontDialog.Font;
            }
        }
    }
}
