using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture16_Lesson1
{
    public partial class frmTextEditor : Form
    {
        public frmTextEditor()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.Text = "";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Rich Text Files | *.rtf";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusLabel1.Text = "Loading file";
                richTextBoxEditor.LoadFile(openFileDialog1.FileName);
                toolStripStatusLabel1.Text = "File loaded successfully";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Files | *.rtf";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                toolStripStatusLabel1.Text = "Saving file";
                richTextBoxEditor.SaveFile(saveFileDialog1.FileName);
                toolStripStatusLabel1.Text = "File saved";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxEditor.SelectAll();
        }

        private void aboutTextEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Text Editor for educational purposes.");
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBoxEditor.SelectionFont = fontDialog1.Font;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBoxEditor.SelectionColor = colorDialog1.Color;
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBoxEditor.BackColor = colorDialog1.Color;
        }

        private void maleVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.SelectVoiceByHints(VoiceGender.Male);
            voice.SpeakAsync(richTextBoxEditor.Text);
        }

        private void femaleVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.SelectVoiceByHints(VoiceGender.Female);
            voice.SpeakAsync(richTextBoxEditor.Text);
        }

    }
}
