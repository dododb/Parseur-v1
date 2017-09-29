using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parseur_v1
{
    public partial class Form1 : Form
    {
        Dictionary<Color, Tuple<int, string>> elementsToParse1 = new Dictionary<Color, Tuple<int, string>>();
        string textSelected1 = "";
        int indexSelected1;
        int lenghtSelected1;

        Dictionary<Color, Tuple<int, string>> elementsToParse2 = new Dictionary<Color, Tuple<int, string>>();
        string textSelected2 = "";
        int indexSelected2;
        int lenghtSelected2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RichTextBox2_SelectionChanged(object sender, EventArgs e)
        {
            this.textSelected1 = richTextBox2.SelectedText;
            this.indexSelected1 = richTextBox2.SelectionStart;
            this.lenghtSelected1 = richTextBox2.SelectionLength;

            this.richTextBox3.Text = richTextBox2.SelectedText;
        }
        private void RichTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            this.textSelected2 = richTextBox1.SelectedText;
            this.indexSelected2 = richTextBox1.SelectionStart;
            this.lenghtSelected2 = richTextBox1.SelectionLength;

            this.richTextBox3.Text = richTextBox1.SelectedText;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textSelected2 == "")
            {
                this.reset();

                ColorDialog cd1 = new ColorDialog();
                if (cd1.ShowDialog() == DialogResult.OK)
                {
                    this.elementsToParse1.Add(cd1.Color, Tuple.Create(this.lenghtSelected1, this.textSelected1));

                    richTextBox2.Select(indexSelected1, lenghtSelected1);
                    richTextBox2.SelectionColor = cd1.Color;
                }

                this.textSelected1 = "";
                this.indexSelected1 = 0;
                this.lenghtSelected1 = 0;
            }
            else
            {

                this.reset();

                ColorDialog cd1 = new ColorDialog();
                if (cd1.ShowDialog() == DialogResult.OK)
                {
                    Tuple < int, string > buffer;
                    if (this.elementsToParse1.TryGetValue(cd1.Color, out buffer))
                    {
                        if (buffer.Item2 == textSelected2)
                        {
                            this.elementsToParse2.Add(cd1.Color, Tuple.Create(this.lenghtSelected2, this.textSelected2));

                            richTextBox1.Select(indexSelected2, lenghtSelected2);
                            richTextBox1.SelectionColor = cd1.Color;
                        }
                    }
                }

                this.textSelected2 = "";
                this.indexSelected2 = 0;
                this.lenghtSelected2 = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void attribuerUneColeurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void reset()
        {
            if (this.textSelected2 == "")
            {
                foreach (KeyValuePair<Color, Tuple<int, string>> element in this.elementsToParse1)
                {
                    if (element.Value.Item1 == indexSelected1 && element.Value.Item2 == this.textSelected1)
                    {
                        this.elementsToParse1.Remove(element.Key);
                    }
                }
                richTextBox2.Select(indexSelected1, lenghtSelected1);
                richTextBox2.SelectionColor = Color.Black;
            }
            else
            {
                foreach (KeyValuePair<Color, Tuple<int, string>> element in this.elementsToParse2)
                {
                    if (element.Value.Item1 == indexSelected2 && element.Value.Item2 == this.textSelected2)
                    {
                        this.elementsToParse2.Remove(element.Key);
                    }
                }
                richTextBox1.Select(indexSelected2, lenghtSelected2);
                richTextBox1.SelectionColor = Color.Black;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine("[" + textSelected1 + "]:[" + indexSelected1 + "]:[" + lenghtSelected1 + "] - [" + elementsToParse1.Count + "]");
            Console.WriteLine("[" + textSelected2 + "]:[" + indexSelected2 + "]:[" + lenghtSelected2 + "] - [" + elementsToParse2.Count + "]");
            Console.WriteLine("=======================");

        }
    }
}
