using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parseur_v1
{
    public partial class Form1 : Form
    {
        Dictionary<Color, Tuple<int, string>> elementsToParse1 = new Dictionary<Color, Tuple<int, string>>();
        string textSelected1 = "";
        int indexSelected1;
        int lenghtSelected1;
        bool lock1 = false;

        Dictionary<Color, Tuple<int, string>> elementsToParse2 = new Dictionary<Color, Tuple<int, string>>();
        string textSelected2 = "";
        int indexSelected2;
        int lenghtSelected2;
        bool lock2 = false;

        string fileToParse;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lockPattern1Button_Click(object sender, EventArgs e)
        {
            if (!this.templateInitial.ReadOnly)  this.lockRichText(this.templateInitial);
            else this.unLockRichText(this.templateInitial);

        }

        private void lockPattern2Button_Click(object sender, EventArgs e)
        {
            if (!this.templateFinal.ReadOnly)  this.lockRichText(this.templateFinal);
            else this.unLockRichText(this.templateFinal);
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if (this.textSelected2 == "")
            {
                if (!lock1)
                {
                    if (MessageBox.Show("Mise en forme du texte terminé?", "Waring", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (this.lockPattern1Button.Text == "Lock 1") this.lockRichText(this.templateInitial);
                    }
                }

                if (lock1)
                {
                    this.reset();

                    ColorDialog cd1 = new ColorDialog();
                    if (cd1.ShowDialog() == DialogResult.OK)
                    {
                        if (this.elementsToParse1.ContainsKey(cd1.Color))
                        {
                            MessageBox.Show("Color already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.elementsToParse1.Add(cd1.Color, Tuple.Create(this.indexSelected1, this.textSelected1));

                            templateInitial.Select(indexSelected1, lenghtSelected1);
                            templateInitial.SelectionColor = cd1.Color;

                            saveColor(cd1.Color);
                        }
                    }

                    this.textSelected1 = "";
                    this.indexSelected1 = 0;
                    this.lenghtSelected1 = 0;
                }
            }
            else
            {

                if (!lock2)
                {
                    if (MessageBox.Show("Mise en forme du texte terminé?", "Waring", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (this.lockPattern2Button.Text == "Lock 2") this.lockRichText(this.templateFinal);
                    }
                }

                if (lock2)
                {
                    this.reset();

                    ColorDialog cd1 = new ColorDialog();
                    if (cd1.ShowDialog() == DialogResult.OK)
                    {
                        if (this.elementsToParse2.ContainsKey(cd1.Color))
                        {
                            MessageBox.Show("Color already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Tuple<int, string> buffer;
                            if (this.elementsToParse1.TryGetValue(cd1.Color, out buffer))
                            {
                                if (buffer.Item2 == textSelected2)
                                {
                                    this.elementsToParse2.Add(cd1.Color, Tuple.Create(this.indexSelected2, this.textSelected2));

                                    templateFinal.Select(indexSelected2, lenghtSelected2);
                                    templateFinal.SelectionColor = cd1.Color;

                                    saveColor(cd1.Color);
                                }
                            }
                        }
                    }

                    this.textSelected2 = "";
                    this.indexSelected2 = 0;
                    this.lenghtSelected2 = 0;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void resetAllButton_Click(object sender, EventArgs e)
        {
            this.resetAll();
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader st = new StreamReader(myStream);
                            this.fileToParse = st.ReadToEnd();
                            st.Dispose();
                            this.filePath.Text = openFileDialog1.SafeFileName;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file from disk. Original error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            myStream.Dispose();
            openFileDialog1.Dispose();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void templateInitial_SelectionChanged(object sender, EventArgs e)
        {
            this.textSelected1 = templateInitial.SelectedText;
            this.indexSelected1 = templateInitial.SelectionStart;
            this.lenghtSelected1 = templateInitial.SelectionLength;

            this.selection.Text = templateInitial.SelectedText;
        }

        private void templateFinal_SelectionChanged(object sender, EventArgs e)
        {
            this.textSelected2 = templateFinal.SelectedText;
            this.indexSelected2 = templateFinal.SelectionStart;
            this.lenghtSelected2 = templateFinal.SelectionLength;

            this.selection.Text = templateFinal.SelectedText;
        }

        private void colorSave1_Click(object sender, EventArgs e)
        {
            this.colorSave(this.colorSave1.BackColor);
        }

        private void colorSave2_Click(object sender, EventArgs e)
        {
            this.colorSave(this.colorSave2.BackColor);
        }

        private void colorSave3_Click(object sender, EventArgs e)
        {
            this.colorSave(this.colorSave3.BackColor);
        }

        private void colorSave4_Click(object sender, EventArgs e)
        {
            this.colorSave(this.colorSave4.BackColor);
        }

        private void colorSave5_Click(object sender, EventArgs e)
        {
            this.colorSave(this.colorSave5.BackColor);
        }

        private void colorSave6_Click(object sender, EventArgs e)
        {
            this.colorSave(this.colorSave6.BackColor);
        }

        private void colorSave7_Click(object sender, EventArgs e)
        {
            this.colorSave(this.colorSave7.BackColor);
        }

        private void colorSave8_Click(object sender, EventArgs e)
        {
            this.colorSave(this.colorSave8.BackColor);
        }

        private void colorSave9_Click(object sender, EventArgs e)
        {
            this.colorSave(this.colorSave9.BackColor);
        }

        private void colorSave10_Click(object sender, EventArgs e)
        {
            this.colorSave(this.colorSave10.BackColor);
        }



























        private void colorSave(Color save)
        {
            if (this.textSelected2 == "")
            {
                if (!lock1)
                {
                    if (MessageBox.Show("Mise en forme du texte terminé?", "Waring", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (this.lockPattern1Button.Text == "Lock 1") this.lockRichText(this.templateInitial);
                    }
                }

                if (lock1)
                {
                    this.reset();

                    if (save != Color.FromArgb(32, 32, 32))
                    {
                        if (this.elementsToParse1.ContainsKey(save))
                        {
                            MessageBox.Show("Color already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.elementsToParse1.Add(save, Tuple.Create(this.indexSelected1, this.textSelected1));

                            templateInitial.Select(indexSelected1, lenghtSelected1);
                            templateInitial.SelectionColor = save;
                        }
                    }

                    this.textSelected1 = "";
                    this.indexSelected1 = 0;
                    this.lenghtSelected1 = 0;
                }
            }
            else
            {

                if (!lock2)
                {
                    if (MessageBox.Show("Mise en forme du texte terminé?", "Waring", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (this.lockPattern2Button.Text == "Lock 2") this.lockRichText(this.templateFinal);
                    }
                }

                if (lock2)
                {
                    this.reset();

                    if (save != Color.FromArgb(32, 32, 32))
                    {
                        if (this.elementsToParse2.ContainsKey(save))
                        {
                            MessageBox.Show("Color already used", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Tuple<int, string> buffer;
                            if (this.elementsToParse1.TryGetValue(save, out buffer))
                            {
                                if (buffer.Item2 == textSelected2)
                                {
                                    this.elementsToParse2.Add(save, Tuple.Create(this.indexSelected2, this.textSelected2));

                                    templateFinal.Select(indexSelected2, lenghtSelected2);
                                    templateFinal.SelectionColor = save;
                                }
                            }
                        }
                    }

                    this.textSelected2 = "";
                    this.indexSelected2 = 0;
                    this.lenghtSelected2 = 0;
                }
            }
        }


        private void reset()
        {
            Color remove =  new Color();
            if (this.textSelected2 == "")
            {
                foreach (KeyValuePair<Color, Tuple<int, string>> element in this.elementsToParse1)
                {
                    if (element.Value.Item1 == indexSelected1 && element.Value.Item2 == this.textSelected1)
                    {

                        remove = element.Key;
                        templateInitial.Select(indexSelected1, lenghtSelected1);
                        templateInitial.SelectionColor = Color.Black;
                    }
                }
                if(remove != null) this.elementsToParse1.Remove(remove);
            }
            else
            {
                foreach (KeyValuePair<Color, Tuple<int, string>> element in this.elementsToParse2)
                {
                    if (element.Value.Item1 == indexSelected2 && element.Value.Item2 == this.textSelected2)
                    {
                        remove = element.Key;
                        templateFinal.Select(indexSelected2, lenghtSelected2);
                        templateFinal.SelectionColor = Color.Black;
                    }
                }
                if (remove != null) this.elementsToParse2.Remove(remove);
            }
        }

        private void resetAll()
        {
            this.elementsToParse1.Clear();
            this.textSelected1 = "";
            this.indexSelected1 = 0;
            this.lenghtSelected1 = 0;

            this.elementsToParse2.Clear();
            this.textSelected2 = "";
            this.indexSelected2 = 0;
            this.lenghtSelected2 = 0;

            if (this.lockPattern1Button.Text == "Modify")
            {
                this.unLockRichText(this.templateInitial);
            }
            if (this.lockPattern2Button.Text == "Modify")
            {
                this.unLockRichText(this.templateFinal);
            }
        }

        private void lockRichText(RichTextBox box)
        {
            if (box == this.templateFinal)
            {
                this.lock2 = true;
                this.lockPattern2Button.Text = "Unlock 2";
            }
            else
            {
                this.lock1 = true;
                this.lockPattern1Button.Text = "Unlock 1";
            }

            box.ReadOnly = true;
            box.BackColor = Color.Gainsboro;
        }

        private void unLockRichText(RichTextBox box)
        {
            if (box == this.templateFinal)
            {
                this.lock2 = false;
                this.lockPattern2Button.Text = "Lock 2";
            }
            else
            {
                this.lock1 = false;
                this.lockPattern1Button.Text = "Lock 1";
            }

            box.ReadOnly = false;
            box.BackColor = Color.White;
        }

        void saveColor(Color save)
        {
            if (this.colorSave1.BackColor == Color.FromArgb(32, 32, 32) || this.colorSave1.BackColor == save) this.colorSave1.BackColor = save;
            else if (this.colorSave2.BackColor == Color.FromArgb(32, 32, 32) || this.colorSave2.BackColor == save) this.colorSave2.BackColor = save;
            else if (this.colorSave3.BackColor == Color.FromArgb(32, 32, 32) || this.colorSave3.BackColor == save) this.colorSave3.BackColor = save;
            else if (this.colorSave4.BackColor == Color.FromArgb(32, 32, 32) || this.colorSave4.BackColor == save) this.colorSave4.BackColor = save;
            else if (this.colorSave5.BackColor == Color.FromArgb(32, 32, 32) || this.colorSave5.BackColor == save) this.colorSave5.BackColor = save;
            else if (this.colorSave6.BackColor == Color.FromArgb(32, 32, 32) || this.colorSave6.BackColor == save) this.colorSave6.BackColor = save;
            else if (this.colorSave7.BackColor == Color.FromArgb(32, 32, 32) || this.colorSave7.BackColor == save) this.colorSave7.BackColor = save;
            else if (this.colorSave8.BackColor == Color.FromArgb(32, 32, 32) || this.colorSave8.BackColor == save) this.colorSave8.BackColor = save;
            else if (this.colorSave9.BackColor == Color.FromArgb(32, 32, 32) || this.colorSave9.BackColor == save) this.colorSave9.BackColor = save;
            else if (this.colorSave10.BackColor == Color.FromArgb(32, 32, 32) || this.colorSave10.BackColor == save) this.colorSave10.BackColor = save;
        }
    }
}