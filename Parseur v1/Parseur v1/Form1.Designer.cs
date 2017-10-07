namespace Parseur_v1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabWindowParseur = new System.Windows.Forms.TabControl();
            this.Templates = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.templateFinal = new System.Windows.Forms.RichTextBox();
            this.templateInitial = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.resetButton = new System.Windows.Forms.Button();
            this.resetAllButton = new System.Windows.Forms.Button();
            this.testButton = new System.Windows.Forms.Button();
            this.fileButton = new System.Windows.Forms.Button();
            this.selection = new System.Windows.Forms.TextBox();
            this.colorButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.colorSave1 = new System.Windows.Forms.Button();
            this.colorSave2 = new System.Windows.Forms.Button();
            this.colorSave3 = new System.Windows.Forms.Button();
            this.colorSave4 = new System.Windows.Forms.Button();
            this.colorSave5 = new System.Windows.Forms.Button();
            this.colorSave6 = new System.Windows.Forms.Button();
            this.colorSave7 = new System.Windows.Forms.Button();
            this.colorSave8 = new System.Windows.Forms.Button();
            this.colorSave9 = new System.Windows.Forms.Button();
            this.colorSave10 = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lockPattern1Button = new System.Windows.Forms.Button();
            this.lockPattern2Button = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.CalculProgressBar = new System.Windows.Forms.ProgressBar();
            this.Result = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.saveButton = new System.Windows.Forms.Button();
            this.finalText = new System.Windows.Forms.RichTextBox();
            this.fileText = new System.Windows.Forms.RichTextBox();
            this.tabWindowParseur.SuspendLayout();
            this.Templates.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.Result.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabWindowParseur
            // 
            this.tabWindowParseur.Controls.Add(this.Templates);
            this.tabWindowParseur.Controls.Add(this.Result);
            this.tabWindowParseur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabWindowParseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabWindowParseur.Location = new System.Drawing.Point(0, 0);
            this.tabWindowParseur.Name = "tabWindowParseur";
            this.tabWindowParseur.SelectedIndex = 0;
            this.tabWindowParseur.Size = new System.Drawing.Size(1040, 505);
            this.tabWindowParseur.TabIndex = 0;
            // 
            // Templates
            // 
            this.Templates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Templates.Controls.Add(this.tableLayoutPanel2);
            this.Templates.Controls.Add(this.tableLayoutPanel1);
            this.Templates.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Templates.Location = new System.Drawing.Point(4, 25);
            this.Templates.Name = "Templates";
            this.Templates.Padding = new System.Windows.Forms.Padding(3);
            this.Templates.Size = new System.Drawing.Size(1032, 476);
            this.Templates.TabIndex = 0;
            this.Templates.Text = "Templates";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.templateFinal, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.templateInitial, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(203, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(826, 470);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // templateFinal
            // 
            this.templateFinal.AcceptsTab = true;
            this.templateFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateFinal.Location = new System.Drawing.Point(416, 3);
            this.templateFinal.Name = "templateFinal";
            this.templateFinal.Size = new System.Drawing.Size(407, 464);
            this.templateFinal.TabIndex = 1;
            this.templateFinal.Text = "";
            this.templateFinal.SelectionChanged += new System.EventHandler(this.templateFinal_SelectionChanged);
            // 
            // templateInitial
            // 
            this.templateInitial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.templateInitial.Location = new System.Drawing.Point(3, 3);
            this.templateInitial.Name = "templateInitial";
            this.templateInitial.Size = new System.Drawing.Size(407, 464);
            this.templateInitial.TabIndex = 2;
            this.templateInitial.Text = "";
            this.templateInitial.SelectionChanged += new System.EventHandler(this.templateInitial_SelectionChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.resetButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.resetAllButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.testButton, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.fileButton, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.selection, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.colorButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.filePath, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startButton, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.CalculProgressBar, 0, 12);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 470);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetButton.Location = new System.Drawing.Point(3, 163);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(194, 24);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // resetAllButton
            // 
            this.resetAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetAllButton.Location = new System.Drawing.Point(3, 193);
            this.resetAllButton.Name = "resetAllButton";
            this.resetAllButton.Size = new System.Drawing.Size(194, 24);
            this.resetAllButton.TabIndex = 2;
            this.resetAllButton.Text = "Reset All";
            this.resetAllButton.UseVisualStyleBackColor = true;
            this.resetAllButton.Click += new System.EventHandler(this.resetAllButton_Click);
            // 
            // testButton
            // 
            this.testButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testButton.Location = new System.Drawing.Point(3, 223);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(194, 24);
            this.testButton.TabIndex = 3;
            this.testButton.Text = "button4";
            this.testButton.UseVisualStyleBackColor = true;
            // 
            // fileButton
            // 
            this.fileButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileButton.Location = new System.Drawing.Point(3, 313);
            this.fileButton.Name = "fileButton";
            this.fileButton.Size = new System.Drawing.Size(194, 34);
            this.fileButton.TabIndex = 4;
            this.fileButton.Text = "Load File";
            this.fileButton.UseVisualStyleBackColor = true;
            this.fileButton.Click += new System.EventHandler(this.fileButton_Click);
            // 
            // selection
            // 
            this.selection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selection.Location = new System.Drawing.Point(3, 43);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(194, 22);
            this.selection.TabIndex = 5;
            // 
            // colorButton
            // 
            this.colorButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorButton.Location = new System.Drawing.Point(3, 83);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(194, 24);
            this.colorButton.TabIndex = 0;
            this.colorButton.Text = "Color";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.colorSave1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.colorSave2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.colorSave3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.colorSave4, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.colorSave5, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.colorSave6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.colorSave7, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.colorSave8, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.colorSave9, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.colorSave10, 4, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 113);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(194, 44);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // colorSave1
            // 
            this.colorSave1.Location = new System.Drawing.Point(0, 0);
            this.colorSave1.Margin = new System.Windows.Forms.Padding(0);
            this.colorSave1.Name = "colorSave1";
            this.colorSave1.Size = new System.Drawing.Size(38, 14);
            this.colorSave1.TabIndex = 0;
            this.colorSave1.UseVisualStyleBackColor = true;
            this.colorSave1.Click += new System.EventHandler(this.colorSave1_Click);
            // 
            // colorSave2
            // 
            this.colorSave2.Location = new System.Drawing.Point(38, 0);
            this.colorSave2.Margin = new System.Windows.Forms.Padding(0);
            this.colorSave2.Name = "colorSave2";
            this.colorSave2.Size = new System.Drawing.Size(38, 14);
            this.colorSave2.TabIndex = 1;
            this.colorSave2.UseVisualStyleBackColor = true;
            this.colorSave2.Click += new System.EventHandler(this.colorSave2_Click);
            // 
            // colorSave3
            // 
            this.colorSave3.Location = new System.Drawing.Point(76, 0);
            this.colorSave3.Margin = new System.Windows.Forms.Padding(0);
            this.colorSave3.Name = "colorSave3";
            this.colorSave3.Size = new System.Drawing.Size(38, 14);
            this.colorSave3.TabIndex = 2;
            this.colorSave3.UseVisualStyleBackColor = true;
            this.colorSave3.Click += new System.EventHandler(this.colorSave3_Click);
            // 
            // colorSave4
            // 
            this.colorSave4.Location = new System.Drawing.Point(114, 0);
            this.colorSave4.Margin = new System.Windows.Forms.Padding(0);
            this.colorSave4.Name = "colorSave4";
            this.colorSave4.Size = new System.Drawing.Size(38, 14);
            this.colorSave4.TabIndex = 3;
            this.colorSave4.UseVisualStyleBackColor = true;
            this.colorSave4.Click += new System.EventHandler(this.colorSave4_Click);
            // 
            // colorSave5
            // 
            this.colorSave5.Location = new System.Drawing.Point(152, 0);
            this.colorSave5.Margin = new System.Windows.Forms.Padding(0);
            this.colorSave5.Name = "colorSave5";
            this.colorSave5.Size = new System.Drawing.Size(42, 14);
            this.colorSave5.TabIndex = 4;
            this.colorSave5.UseVisualStyleBackColor = true;
            this.colorSave5.Click += new System.EventHandler(this.colorSave5_Click);
            // 
            // colorSave6
            // 
            this.colorSave6.Location = new System.Drawing.Point(0, 14);
            this.colorSave6.Margin = new System.Windows.Forms.Padding(0);
            this.colorSave6.Name = "colorSave6";
            this.colorSave6.Size = new System.Drawing.Size(38, 14);
            this.colorSave6.TabIndex = 5;
            this.colorSave6.UseVisualStyleBackColor = true;
            this.colorSave6.Click += new System.EventHandler(this.colorSave6_Click);
            // 
            // colorSave7
            // 
            this.colorSave7.Location = new System.Drawing.Point(38, 14);
            this.colorSave7.Margin = new System.Windows.Forms.Padding(0);
            this.colorSave7.Name = "colorSave7";
            this.colorSave7.Size = new System.Drawing.Size(38, 14);
            this.colorSave7.TabIndex = 6;
            this.colorSave7.UseVisualStyleBackColor = true;
            this.colorSave7.Click += new System.EventHandler(this.colorSave7_Click);
            // 
            // colorSave8
            // 
            this.colorSave8.Location = new System.Drawing.Point(76, 14);
            this.colorSave8.Margin = new System.Windows.Forms.Padding(0);
            this.colorSave8.Name = "colorSave8";
            this.colorSave8.Size = new System.Drawing.Size(38, 14);
            this.colorSave8.TabIndex = 7;
            this.colorSave8.UseVisualStyleBackColor = true;
            this.colorSave8.Click += new System.EventHandler(this.colorSave8_Click);
            // 
            // colorSave9
            // 
            this.colorSave9.Location = new System.Drawing.Point(114, 14);
            this.colorSave9.Margin = new System.Windows.Forms.Padding(0);
            this.colorSave9.Name = "colorSave9";
            this.colorSave9.Size = new System.Drawing.Size(38, 14);
            this.colorSave9.TabIndex = 8;
            this.colorSave9.UseVisualStyleBackColor = true;
            this.colorSave9.Click += new System.EventHandler(this.colorSave9_Click);
            // 
            // colorSave10
            // 
            this.colorSave10.Location = new System.Drawing.Point(152, 14);
            this.colorSave10.Margin = new System.Windows.Forms.Padding(0);
            this.colorSave10.Name = "colorSave10";
            this.colorSave10.Size = new System.Drawing.Size(42, 14);
            this.colorSave10.TabIndex = 9;
            this.colorSave10.UseVisualStyleBackColor = true;
            this.colorSave10.Click += new System.EventHandler(this.colorSave10_Click);
            // 
            // filePath
            // 
            this.filePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePath.Enabled = false;
            this.filePath.Location = new System.Drawing.Point(3, 353);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(194, 22);
            this.filePath.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lockPattern1Button, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lockPattern2Button, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 34);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // lockPattern1Button
            // 
            this.lockPattern1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lockPattern1Button.Location = new System.Drawing.Point(3, 3);
            this.lockPattern1Button.Name = "lockPattern1Button";
            this.lockPattern1Button.Size = new System.Drawing.Size(91, 28);
            this.lockPattern1Button.TabIndex = 0;
            this.lockPattern1Button.Text = "Lock 1";
            this.lockPattern1Button.UseVisualStyleBackColor = true;
            this.lockPattern1Button.Click += new System.EventHandler(this.lockPattern1Button_Click);
            // 
            // lockPattern2Button
            // 
            this.lockPattern2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lockPattern2Button.Location = new System.Drawing.Point(100, 3);
            this.lockPattern2Button.Name = "lockPattern2Button";
            this.lockPattern2Button.Size = new System.Drawing.Size(91, 28);
            this.lockPattern2Button.TabIndex = 1;
            this.lockPattern2Button.Text = "Lock 2";
            this.lockPattern2Button.UseVisualStyleBackColor = true;
            this.lockPattern2Button.Click += new System.EventHandler(this.lockPattern2Button_Click);
            // 
            // startButton
            // 
            this.startButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startButton.Location = new System.Drawing.Point(3, 393);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(194, 34);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // CalculProgressBar
            // 
            this.CalculProgressBar.Location = new System.Drawing.Point(3, 433);
            this.CalculProgressBar.Name = "CalculProgressBar";
            this.CalculProgressBar.Size = new System.Drawing.Size(194, 23);
            this.CalculProgressBar.TabIndex = 10;
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Result.Controls.Add(this.tableLayoutPanel5);
            this.Result.Location = new System.Drawing.Point(4, 25);
            this.Result.Name = "Result";
            this.Result.Padding = new System.Windows.Forms.Padding(3);
            this.Result.Size = new System.Drawing.Size(1032, 476);
            this.Result.TabIndex = 1;
            this.Result.Text = "Result";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.fileText, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1026, 470);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.saveButton, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.finalText, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(516, 23);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(507, 464);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.Location = new System.Drawing.Point(3, 427);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 34);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // finalText
            // 
            this.finalText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalText.Location = new System.Drawing.Point(3, 3);
            this.finalText.Name = "finalText";
            this.finalText.Size = new System.Drawing.Size(501, 418);
            this.finalText.TabIndex = 1;
            this.finalText.Text = "";
            // 
            // fileText
            // 
            this.fileText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileText.Location = new System.Drawing.Point(3, 23);
            this.fileText.Name = "fileText";
            this.fileText.Size = new System.Drawing.Size(507, 464);
            this.fileText.TabIndex = 1;
            this.fileText.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1040, 505);
            this.Controls.Add(this.tabWindowParseur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabWindowParseur.ResumeLayout(false);
            this.Templates.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.Result.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabWindowParseur;
        private System.Windows.Forms.TabPage Templates;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage Result;
        private System.Windows.Forms.RichTextBox templateFinal;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button resetAllButton;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button fileButton;
        private System.Windows.Forms.TextBox selection;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button lockPattern1Button;
        private System.Windows.Forms.Button lockPattern2Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RichTextBox finalText;
        private System.Windows.Forms.RichTextBox fileText;
        private System.Windows.Forms.Button colorSave1;
        private System.Windows.Forms.Button colorSave2;
        private System.Windows.Forms.Button colorSave3;
        private System.Windows.Forms.Button colorSave4;
        private System.Windows.Forms.Button colorSave5;
        private System.Windows.Forms.Button colorSave6;
        private System.Windows.Forms.Button colorSave7;
        private System.Windows.Forms.Button colorSave8;
        private System.Windows.Forms.Button colorSave9;
        private System.Windows.Forms.Button colorSave10;
        private System.Windows.Forms.RichTextBox templateInitial;
        private System.Windows.Forms.ProgressBar CalculProgressBar;
    }
}

