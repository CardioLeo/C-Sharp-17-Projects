using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpNotepadApp
{
    public partial class formMain: Form
    {

        string OurFilename;
        string LastFindWord; // word being searched for
        bool LastFindDown;
        bool LastFindMatchCase;
        void DoSave(string filename)
        {
            OurFilename = filename;
            textBox.SaveFile(filename);
        }

        void DoSaveAs()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DoSave(saveFileDialog1.FileName);
            }
        }
        public formMain()
        {
            InitializeComponent();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // event handler for undo button in edit menu
            textBox.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        public void DoFind(string search, bool down, bool match_case)
        {
            LastFindWord = search;
            LastFindDown = down;
            LastFindMatchCase = match_case;

            if (down)
            {
                if (match_case)
                {
                    textBox.Find(search, textBox.SelectionStart + 1, RichTextBoxFinds.MatchCase);
                }
                else
                {
                    textBox.Find(search, textBox.SelectionStart + 1, RichTextBoxFinds.None);
                }
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formFind find = new formFind();
            find.Show(this);
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
        //    formMain parent_form = (formMain)Owner;
        //    parent_form.DoFind(find.textFindWhat.Text, rdoDown.Checked, checkMatchCase.Checked);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectAll();
        }

        bool CheckChanges()
        {
            return true;
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckChanges())
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox.LoadFile(openFileDialog1.FileName);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OurFilename))
            {
                DoSaveAs();
            }
            else
            {
                DoSave(OurFilename);
            }
        }
    }
}
