﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpNotepadApp
{
    public partial class formMain: Form
    {

        string OurFilename;
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

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // textBox.Find();
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
