
namespace ScientificCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titlebarPanel = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.calculationsScreenPanel = new System.Windows.Forms.Panel();
            this.answerLabelHolder = new System.Windows.Forms.TableLayoutPanel();
            this.answerLabel = new System.Windows.Forms.Label();
            this.operationsLabelHolder = new System.Windows.Forms.TableLayoutPanel();
            this.operationsLabel = new System.Windows.Forms.Label();
            this.toBeFocused = new System.Windows.Forms.Label();
            this.advancedOperationsTable = new System.Windows.Forms.TableLayoutPanel();
            this.squareRootButton = new System.Windows.Forms.Button();
            this.rightParanthButton = new System.Windows.Forms.Button();
            this.leftParanthButton = new System.Windows.Forms.Button();
            this.piButton = new System.Windows.Forms.Button();
            this.powButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.lnButton = new System.Windows.Forms.Button();
            this.tanButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.radButton = new System.Windows.Forms.Button();
            this.invButton = new System.Windows.Forms.Button();
            this.factButton = new System.Windows.Forms.Button();
            this.expButton = new System.Windows.Forms.Button();
            this.percButton = new System.Windows.Forms.Button();
            this.numbersInputHolder = new System.Windows.Forms.TableLayoutPanel();
            this.eqButton = new System.Windows.Forms.Button();
            this._0Button = new System.Windows.Forms.Button();
            this.pointButton = new System.Windows.Forms.Button();
            this._2Button = new System.Windows.Forms.Button();
            this._1Button = new System.Windows.Forms.Button();
            this._5Button = new System.Windows.Forms.Button();
            this._4Button = new System.Windows.Forms.Button();
            this._8Button = new System.Windows.Forms.Button();
            this._7Button = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.ceButton = new System.Windows.Forms.Button();
            this._3Button = new System.Windows.Forms.Button();
            this._9Button = new System.Windows.Forms.Button();
            this._6Button = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.titlebarPanel.SuspendLayout();
            this.calculationsScreenPanel.SuspendLayout();
            this.answerLabelHolder.SuspendLayout();
            this.operationsLabelHolder.SuspendLayout();
            this.advancedOperationsTable.SuspendLayout();
            this.numbersInputHolder.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebarPanel
            // 
            this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.titlebarPanel.Controls.Add(this.label1);
            this.titlebarPanel.Controls.Add(this.minimizeButton);
            this.titlebarPanel.Controls.Add(this.maximizeButton);
            this.titlebarPanel.Controls.Add(this.closeButton);
            this.titlebarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebarPanel.Location = new System.Drawing.Point(0, 0);
            this.titlebarPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titlebarPanel.Name = "titlebarPanel";
            this.titlebarPanel.Size = new System.Drawing.Size(500, 35);
            this.titlebarPanel.TabIndex = 0;
            this.titlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarPanel_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Location = new System.Drawing.Point(380, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(40, 35);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // maximizeButton
            // 
            this.maximizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("maximizeButton.BackgroundImage")));
            this.maximizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.maximizeButton.Enabled = false;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizeButton.Location = new System.Drawing.Point(420, 0);
            this.maximizeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(40, 35);
            this.maximizeButton.TabIndex = 2;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.UseVisualStyleBackColor = true;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(460, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 35);
            this.closeButton.TabIndex = 1;
            this.closeButton.TabStop = false;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // calculationsScreenPanel
            // 
            this.calculationsScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.calculationsScreenPanel.Controls.Add(this.answerLabelHolder);
            this.calculationsScreenPanel.Controls.Add(this.operationsLabelHolder);
            this.calculationsScreenPanel.Controls.Add(this.toBeFocused);
            this.calculationsScreenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.calculationsScreenPanel.Location = new System.Drawing.Point(0, 35);
            this.calculationsScreenPanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.calculationsScreenPanel.Name = "calculationsScreenPanel";
            this.calculationsScreenPanel.Size = new System.Drawing.Size(500, 120);
            this.calculationsScreenPanel.TabIndex = 1;
            // 
            // answerLabelHolder
            // 
            this.answerLabelHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answerLabelHolder.ColumnCount = 1;
            this.answerLabelHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.answerLabelHolder.Controls.Add(this.answerLabel, 0, 0);
            this.answerLabelHolder.Location = new System.Drawing.Point(40, 72);
            this.answerLabelHolder.Name = "answerLabelHolder";
            this.answerLabelHolder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.answerLabelHolder.RowCount = 1;
            this.answerLabelHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.answerLabelHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.answerLabelHolder.Size = new System.Drawing.Size(448, 42);
            this.answerLabelHolder.TabIndex = 3;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerLabel.Font = new System.Drawing.Font("URWImperialTExtBol", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.Color.White;
            this.answerLabel.Location = new System.Drawing.Point(3, 0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.answerLabel.Size = new System.Drawing.Size(442, 42);
            this.answerLabel.TabIndex = 0;
            this.answerLabel.Text = "0";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // operationsLabelHolder
            // 
            this.operationsLabelHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationsLabelHolder.ColumnCount = 1;
            this.operationsLabelHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operationsLabelHolder.Controls.Add(this.operationsLabel, 0, 0);
            this.operationsLabelHolder.Location = new System.Drawing.Point(12, 20);
            this.operationsLabelHolder.Name = "operationsLabelHolder";
            this.operationsLabelHolder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operationsLabelHolder.RowCount = 1;
            this.operationsLabelHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operationsLabelHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.operationsLabelHolder.Size = new System.Drawing.Size(448, 42);
            this.operationsLabelHolder.TabIndex = 2;
            // 
            // operationsLabel
            // 
            this.operationsLabel.AutoSize = true;
            this.operationsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationsLabel.Font = new System.Drawing.Font("URWImperialTExtBol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(130)))), ((int)(((byte)(139)))));
            this.operationsLabel.Location = new System.Drawing.Point(3, 0);
            this.operationsLabel.Name = "operationsLabel";
            this.operationsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.operationsLabel.Size = new System.Drawing.Size(442, 42);
            this.operationsLabel.TabIndex = 0;
            this.operationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toBeFocused
            // 
            this.toBeFocused.AutoSize = true;
            this.toBeFocused.Location = new System.Drawing.Point(12, 72);
            this.toBeFocused.Name = "toBeFocused";
            this.toBeFocused.Size = new System.Drawing.Size(0, 20);
            this.toBeFocused.TabIndex = 4;
            // 
            // advancedOperationsTable
            // 
            this.advancedOperationsTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.advancedOperationsTable.ColumnCount = 3;
            this.advancedOperationsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.35294F));
            this.advancedOperationsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.29412F));
            this.advancedOperationsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.35294F));
            this.advancedOperationsTable.Controls.Add(this.squareRootButton, 2, 4);
            this.advancedOperationsTable.Controls.Add(this.rightParanthButton, 1, 4);
            this.advancedOperationsTable.Controls.Add(this.leftParanthButton, 0, 4);
            this.advancedOperationsTable.Controls.Add(this.piButton, 1, 3);
            this.advancedOperationsTable.Controls.Add(this.powButton, 0, 3);
            this.advancedOperationsTable.Controls.Add(this.logButton, 1, 2);
            this.advancedOperationsTable.Controls.Add(this.lnButton, 0, 2);
            this.advancedOperationsTable.Controls.Add(this.tanButton, 1, 1);
            this.advancedOperationsTable.Controls.Add(this.cosButton, 0, 1);
            this.advancedOperationsTable.Controls.Add(this.sinButton, 2, 0);
            this.advancedOperationsTable.Controls.Add(this.radButton, 1, 0);
            this.advancedOperationsTable.Controls.Add(this.invButton, 0, 0);
            this.advancedOperationsTable.Controls.Add(this.factButton, 2, 3);
            this.advancedOperationsTable.Controls.Add(this.expButton, 2, 1);
            this.advancedOperationsTable.Controls.Add(this.percButton, 2, 2);
            this.advancedOperationsTable.Dock = System.Windows.Forms.DockStyle.Right;
            this.advancedOperationsTable.Location = new System.Drawing.Point(333, 155);
            this.advancedOperationsTable.Name = "advancedOperationsTable";
            this.advancedOperationsTable.RowCount = 5;
            this.advancedOperationsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.advancedOperationsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.advancedOperationsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.advancedOperationsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.advancedOperationsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.advancedOperationsTable.Size = new System.Drawing.Size(167, 245);
            this.advancedOperationsTable.TabIndex = 2;
            // 
            // squareRootButton
            // 
            this.squareRootButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.squareRootButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.squareRootButton.FlatAppearance.BorderSize = 0;
            this.squareRootButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareRootButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.squareRootButton.Location = new System.Drawing.Point(115, 199);
            this.squareRootButton.Name = "squareRootButton";
            this.squareRootButton.Size = new System.Drawing.Size(49, 43);
            this.squareRootButton.TabIndex = 17;
            this.squareRootButton.TabStop = false;
            this.squareRootButton.Text = "√";
            this.squareRootButton.UseVisualStyleBackColor = true;
            // 
            // rightParanthButton
            // 
            this.rightParanthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rightParanthButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightParanthButton.FlatAppearance.BorderSize = 0;
            this.rightParanthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightParanthButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rightParanthButton.Location = new System.Drawing.Point(57, 199);
            this.rightParanthButton.Name = "rightParanthButton";
            this.rightParanthButton.Size = new System.Drawing.Size(52, 43);
            this.rightParanthButton.TabIndex = 16;
            this.rightParanthButton.TabStop = false;
            this.rightParanthButton.Text = ")";
            this.rightParanthButton.UseVisualStyleBackColor = true;
            // 
            // leftParanthButton
            // 
            this.leftParanthButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.leftParanthButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftParanthButton.FlatAppearance.BorderSize = 0;
            this.leftParanthButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftParanthButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.leftParanthButton.Location = new System.Drawing.Point(3, 199);
            this.leftParanthButton.Name = "leftParanthButton";
            this.leftParanthButton.Size = new System.Drawing.Size(48, 43);
            this.leftParanthButton.TabIndex = 15;
            this.leftParanthButton.TabStop = false;
            this.leftParanthButton.Text = "(";
            this.leftParanthButton.UseVisualStyleBackColor = true;
            // 
            // piButton
            // 
            this.piButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.piButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.piButton.FlatAppearance.BorderSize = 0;
            this.piButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.piButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.piButton.Location = new System.Drawing.Point(57, 150);
            this.piButton.Name = "piButton";
            this.piButton.Size = new System.Drawing.Size(52, 43);
            this.piButton.TabIndex = 13;
            this.piButton.TabStop = false;
            this.piButton.Text = "π";
            this.piButton.UseVisualStyleBackColor = true;
            // 
            // powButton
            // 
            this.powButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.powButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powButton.FlatAppearance.BorderSize = 0;
            this.powButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.powButton.Location = new System.Drawing.Point(3, 150);
            this.powButton.Name = "powButton";
            this.powButton.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.powButton.Size = new System.Drawing.Size(48, 43);
            this.powButton.TabIndex = 12;
            this.powButton.TabStop = false;
            this.powButton.Text = "^";
            this.powButton.UseVisualStyleBackColor = true;
            // 
            // logButton
            // 
            this.logButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logButton.FlatAppearance.BorderSize = 0;
            this.logButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logButton.Location = new System.Drawing.Point(57, 101);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(52, 43);
            this.logButton.TabIndex = 10;
            this.logButton.TabStop = false;
            this.logButton.Text = "log";
            this.logButton.UseVisualStyleBackColor = true;
            // 
            // lnButton
            // 
            this.lnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lnButton.FlatAppearance.BorderSize = 0;
            this.lnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lnButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lnButton.Location = new System.Drawing.Point(3, 101);
            this.lnButton.Name = "lnButton";
            this.lnButton.Size = new System.Drawing.Size(48, 43);
            this.lnButton.TabIndex = 9;
            this.lnButton.TabStop = false;
            this.lnButton.Text = "ln";
            this.lnButton.UseVisualStyleBackColor = true;
            // 
            // tanButton
            // 
            this.tanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tanButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tanButton.FlatAppearance.BorderSize = 0;
            this.tanButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tanButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tanButton.Location = new System.Drawing.Point(57, 52);
            this.tanButton.Name = "tanButton";
            this.tanButton.Size = new System.Drawing.Size(52, 43);
            this.tanButton.TabIndex = 7;
            this.tanButton.TabStop = false;
            this.tanButton.Text = "tan";
            this.tanButton.UseVisualStyleBackColor = true;
            // 
            // cosButton
            // 
            this.cosButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cosButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cosButton.FlatAppearance.BorderSize = 0;
            this.cosButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cosButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cosButton.Location = new System.Drawing.Point(3, 52);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(48, 43);
            this.cosButton.TabIndex = 6;
            this.cosButton.TabStop = false;
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = true;
            // 
            // sinButton
            // 
            this.sinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sinButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sinButton.FlatAppearance.BorderSize = 0;
            this.sinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sinButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sinButton.Location = new System.Drawing.Point(115, 3);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(49, 43);
            this.sinButton.TabIndex = 5;
            this.sinButton.TabStop = false;
            this.sinButton.Text = "sin";
            this.sinButton.UseVisualStyleBackColor = true;
            // 
            // radButton
            // 
            this.radButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radButton.FlatAppearance.BorderSize = 0;
            this.radButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.radButton.Location = new System.Drawing.Point(57, 3);
            this.radButton.Name = "radButton";
            this.radButton.Size = new System.Drawing.Size(52, 43);
            this.radButton.TabIndex = 4;
            this.radButton.TabStop = false;
            this.radButton.Text = "rad";
            this.radButton.UseVisualStyleBackColor = true;
            // 
            // invButton
            // 
            this.invButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.invButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invButton.FlatAppearance.BorderSize = 0;
            this.invButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.invButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.invButton.Location = new System.Drawing.Point(3, 3);
            this.invButton.Name = "invButton";
            this.invButton.Size = new System.Drawing.Size(48, 43);
            this.invButton.TabIndex = 3;
            this.invButton.TabStop = false;
            this.invButton.Text = "inv";
            this.invButton.UseVisualStyleBackColor = true;
            // 
            // factButton
            // 
            this.factButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.factButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.factButton.FlatAppearance.BorderSize = 0;
            this.factButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.factButton.Location = new System.Drawing.Point(115, 150);
            this.factButton.Name = "factButton";
            this.factButton.Size = new System.Drawing.Size(49, 43);
            this.factButton.TabIndex = 11;
            this.factButton.TabStop = false;
            this.factButton.Text = "!";
            this.factButton.UseVisualStyleBackColor = true;
            // 
            // expButton
            // 
            this.expButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.expButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expButton.FlatAppearance.BorderSize = 0;
            this.expButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.expButton.Location = new System.Drawing.Point(115, 52);
            this.expButton.Name = "expButton";
            this.expButton.Size = new System.Drawing.Size(49, 43);
            this.expButton.TabIndex = 14;
            this.expButton.TabStop = false;
            this.expButton.Text = "exp";
            this.expButton.UseVisualStyleBackColor = true;
            // 
            // percButton
            // 
            this.percButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.percButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.percButton.FlatAppearance.BorderSize = 0;
            this.percButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.percButton.Location = new System.Drawing.Point(115, 101);
            this.percButton.Name = "percButton";
            this.percButton.Size = new System.Drawing.Size(49, 43);
            this.percButton.TabIndex = 8;
            this.percButton.TabStop = false;
            this.percButton.Text = "%";
            this.percButton.UseVisualStyleBackColor = true;
            // 
            // numbersInputHolder
            // 
            this.numbersInputHolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.numbersInputHolder.ColumnCount = 4;
            this.numbersInputHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numbersInputHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numbersInputHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numbersInputHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.numbersInputHolder.Controls.Add(this.eqButton, 2, 4);
            this.numbersInputHolder.Controls.Add(this._0Button, 1, 4);
            this.numbersInputHolder.Controls.Add(this.pointButton, 0, 4);
            this.numbersInputHolder.Controls.Add(this._2Button, 1, 3);
            this.numbersInputHolder.Controls.Add(this._1Button, 0, 3);
            this.numbersInputHolder.Controls.Add(this._5Button, 1, 2);
            this.numbersInputHolder.Controls.Add(this._4Button, 0, 2);
            this.numbersInputHolder.Controls.Add(this._8Button, 1, 1);
            this.numbersInputHolder.Controls.Add(this._7Button, 0, 1);
            this.numbersInputHolder.Controls.Add(this.backButton, 2, 0);
            this.numbersInputHolder.Controls.Add(this.cButton, 1, 0);
            this.numbersInputHolder.Controls.Add(this.ceButton, 0, 0);
            this.numbersInputHolder.Controls.Add(this._3Button, 2, 3);
            this.numbersInputHolder.Controls.Add(this._9Button, 2, 1);
            this.numbersInputHolder.Controls.Add(this._6Button, 2, 2);
            this.numbersInputHolder.Controls.Add(this.divButton, 3, 0);
            this.numbersInputHolder.Controls.Add(this.mulButton, 3, 1);
            this.numbersInputHolder.Controls.Add(this.subButton, 3, 2);
            this.numbersInputHolder.Controls.Add(this.addButton, 3, 3);
            this.numbersInputHolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numbersInputHolder.Location = new System.Drawing.Point(0, 155);
            this.numbersInputHolder.Name = "numbersInputHolder";
            this.numbersInputHolder.RowCount = 5;
            this.numbersInputHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.numbersInputHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.numbersInputHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.numbersInputHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.numbersInputHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.numbersInputHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.numbersInputHolder.Size = new System.Drawing.Size(333, 245);
            this.numbersInputHolder.TabIndex = 3;
            // 
            // eqButton
            // 
            this.eqButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(46)))));
            this.numbersInputHolder.SetColumnSpan(this.eqButton, 2);
            this.eqButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eqButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eqButton.FlatAppearance.BorderSize = 0;
            this.eqButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eqButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.eqButton.Location = new System.Drawing.Point(169, 199);
            this.eqButton.Name = "eqButton";
            this.eqButton.Size = new System.Drawing.Size(161, 43);
            this.eqButton.TabIndex = 17;
            this.eqButton.TabStop = false;
            this.eqButton.Text = "=";
            this.eqButton.UseVisualStyleBackColor = false;
            this.eqButton.Click += new System.EventHandler(this.eqButton_Click);
            // 
            // _0Button
            // 
            this._0Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))));
            this._0Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this._0Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._0Button.FlatAppearance.BorderSize = 0;
            this._0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._0Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._0Button.Location = new System.Drawing.Point(86, 199);
            this._0Button.Name = "_0Button";
            this._0Button.Size = new System.Drawing.Size(77, 43);
            this._0Button.TabIndex = 16;
            this._0Button.TabStop = false;
            this._0Button.Text = "0";
            this._0Button.UseVisualStyleBackColor = false;
            this._0Button.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // pointButton
            // 
            this.pointButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.pointButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pointButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pointButton.FlatAppearance.BorderSize = 0;
            this.pointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pointButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pointButton.Location = new System.Drawing.Point(3, 199);
            this.pointButton.Name = "pointButton";
            this.pointButton.Size = new System.Drawing.Size(77, 43);
            this.pointButton.TabIndex = 15;
            this.pointButton.TabStop = false;
            this.pointButton.Text = ".";
            this.pointButton.UseVisualStyleBackColor = false;
            // 
            // _2Button
            // 
            this._2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))));
            this._2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this._2Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._2Button.FlatAppearance.BorderSize = 0;
            this._2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._2Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._2Button.Location = new System.Drawing.Point(86, 150);
            this._2Button.Name = "_2Button";
            this._2Button.Size = new System.Drawing.Size(77, 43);
            this._2Button.TabIndex = 13;
            this._2Button.TabStop = false;
            this._2Button.Text = "2";
            this._2Button.UseVisualStyleBackColor = false;
            this._2Button.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // _1Button
            // 
            this._1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))));
            this._1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this._1Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._1Button.FlatAppearance.BorderSize = 0;
            this._1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._1Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._1Button.Location = new System.Drawing.Point(3, 150);
            this._1Button.Name = "_1Button";
            this._1Button.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this._1Button.Size = new System.Drawing.Size(77, 43);
            this._1Button.TabIndex = 12;
            this._1Button.TabStop = false;
            this._1Button.Text = "1";
            this._1Button.UseVisualStyleBackColor = false;
            this._1Button.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // _5Button
            // 
            this._5Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))));
            this._5Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this._5Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._5Button.FlatAppearance.BorderSize = 0;
            this._5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._5Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._5Button.Location = new System.Drawing.Point(86, 101);
            this._5Button.Name = "_5Button";
            this._5Button.Size = new System.Drawing.Size(77, 43);
            this._5Button.TabIndex = 10;
            this._5Button.TabStop = false;
            this._5Button.Text = "5";
            this._5Button.UseVisualStyleBackColor = false;
            this._5Button.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // _4Button
            // 
            this._4Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))));
            this._4Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this._4Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._4Button.FlatAppearance.BorderSize = 0;
            this._4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._4Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._4Button.Location = new System.Drawing.Point(3, 101);
            this._4Button.Name = "_4Button";
            this._4Button.Size = new System.Drawing.Size(77, 43);
            this._4Button.TabIndex = 9;
            this._4Button.TabStop = false;
            this._4Button.Text = "4";
            this._4Button.UseVisualStyleBackColor = false;
            this._4Button.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // _8Button
            // 
            this._8Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))));
            this._8Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this._8Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._8Button.FlatAppearance.BorderSize = 0;
            this._8Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._8Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._8Button.Location = new System.Drawing.Point(86, 52);
            this._8Button.Name = "_8Button";
            this._8Button.Size = new System.Drawing.Size(77, 43);
            this._8Button.TabIndex = 7;
            this._8Button.TabStop = false;
            this._8Button.Text = "8";
            this._8Button.UseVisualStyleBackColor = false;
            this._8Button.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // _7Button
            // 
            this._7Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))));
            this._7Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this._7Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._7Button.FlatAppearance.BorderSize = 0;
            this._7Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._7Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._7Button.Location = new System.Drawing.Point(3, 52);
            this._7Button.Name = "_7Button";
            this._7Button.Size = new System.Drawing.Size(77, 43);
            this._7Button.TabIndex = 6;
            this._7Button.TabStop = false;
            this._7Button.Text = "7";
            this._7Button.UseVisualStyleBackColor = false;
            this._7Button.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.backButton.Location = new System.Drawing.Point(169, 3);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(77, 43);
            this.backButton.TabIndex = 5;
            this.backButton.TabStop = false;
            this.backButton.Text = "⌫";
            this.backButton.UseVisualStyleBackColor = false;
            // 
            // cButton
            // 
            this.cButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.cButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cButton.FlatAppearance.BorderSize = 0;
            this.cButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(61)))), ((int)(((byte)(116)))));
            this.cButton.Location = new System.Drawing.Point(86, 3);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(77, 43);
            this.cButton.TabIndex = 4;
            this.cButton.TabStop = false;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = false;
            this.cButton.Click += new System.EventHandler(this.cButton_Click);
            // 
            // ceButton
            // 
            this.ceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.ceButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ceButton.FlatAppearance.BorderSize = 0;
            this.ceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ceButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ceButton.Location = new System.Drawing.Point(3, 3);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(77, 43);
            this.ceButton.TabIndex = 3;
            this.ceButton.TabStop = false;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = false;
            this.ceButton.Click += new System.EventHandler(this.ceButton_Click);
            // 
            // _3Button
            // 
            this._3Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))));
            this._3Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this._3Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._3Button.FlatAppearance.BorderSize = 0;
            this._3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._3Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._3Button.Location = new System.Drawing.Point(169, 150);
            this._3Button.Name = "_3Button";
            this._3Button.Size = new System.Drawing.Size(77, 43);
            this._3Button.TabIndex = 11;
            this._3Button.TabStop = false;
            this._3Button.Text = "3";
            this._3Button.UseVisualStyleBackColor = false;
            this._3Button.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // _9Button
            // 
            this._9Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))));
            this._9Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this._9Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._9Button.FlatAppearance.BorderSize = 0;
            this._9Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._9Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._9Button.Location = new System.Drawing.Point(169, 52);
            this._9Button.Name = "_9Button";
            this._9Button.Size = new System.Drawing.Size(77, 43);
            this._9Button.TabIndex = 14;
            this._9Button.TabStop = false;
            this._9Button.Text = "9";
            this._9Button.UseVisualStyleBackColor = false;
            this._9Button.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // _6Button
            // 
            this._6Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(106)))), ((int)(((byte)(125)))));
            this._6Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this._6Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this._6Button.FlatAppearance.BorderSize = 0;
            this._6Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._6Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this._6Button.Location = new System.Drawing.Point(169, 101);
            this._6Button.Name = "_6Button";
            this._6Button.Size = new System.Drawing.Size(77, 43);
            this._6Button.TabIndex = 8;
            this._6Button.TabStop = false;
            this._6Button.Text = "6";
            this._6Button.UseVisualStyleBackColor = false;
            this._6Button.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // divButton
            // 
            this.divButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.divButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.divButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divButton.FlatAppearance.BorderSize = 0;
            this.divButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.divButton.Location = new System.Drawing.Point(252, 3);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(78, 43);
            this.divButton.TabIndex = 18;
            this.divButton.TabStop = false;
            this.divButton.Text = "÷";
            this.divButton.UseVisualStyleBackColor = false;
            this.divButton.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // mulButton
            // 
            this.mulButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.mulButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mulButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mulButton.FlatAppearance.BorderSize = 0;
            this.mulButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mulButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mulButton.Location = new System.Drawing.Point(252, 52);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(78, 43);
            this.mulButton.TabIndex = 19;
            this.mulButton.TabStop = false;
            this.mulButton.Text = "×";
            this.mulButton.UseVisualStyleBackColor = false;
            this.mulButton.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // subButton
            // 
            this.subButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.subButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subButton.FlatAppearance.BorderSize = 0;
            this.subButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.subButton.Location = new System.Drawing.Point(252, 101);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(78, 43);
            this.subButton.TabIndex = 20;
            this.subButton.TabStop = false;
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = false;
            this.subButton.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addButton.Location = new System.Drawing.Point(252, 150);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(78, 43);
            this.addButton.TabIndex = 21;
            this.addButton.TabStop = false;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.numericalInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("URWImperialTExtBol", 14F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculator";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebarPanel_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.numbersInputHolder);
            this.Controls.Add(this.advancedOperationsTable);
            this.Controls.Add(this.calculationsScreenPanel);
            this.Controls.Add(this.titlebarPanel);
            this.Font = new System.Drawing.Font("URWImperialTExtBol", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.titlebarPanel.ResumeLayout(false);
            this.titlebarPanel.PerformLayout();
            this.calculationsScreenPanel.ResumeLayout(false);
            this.calculationsScreenPanel.PerformLayout();
            this.answerLabelHolder.ResumeLayout(false);
            this.answerLabelHolder.PerformLayout();
            this.operationsLabelHolder.ResumeLayout(false);
            this.operationsLabelHolder.PerformLayout();
            this.advancedOperationsTable.ResumeLayout(false);
            this.numbersInputHolder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebarPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Panel calculationsScreenPanel;
        private System.Windows.Forms.Label operationsLabel;
        private System.Windows.Forms.TableLayoutPanel operationsLabelHolder;
        private System.Windows.Forms.TableLayoutPanel advancedOperationsTable;
        private System.Windows.Forms.Button squareRootButton;
        private System.Windows.Forms.Button rightParanthButton;
        private System.Windows.Forms.Button leftParanthButton;
        private System.Windows.Forms.Button expButton;
        private System.Windows.Forms.Button piButton;
        private System.Windows.Forms.Button powButton;
        private System.Windows.Forms.Button factButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Button lnButton;
        private System.Windows.Forms.Button percButton;
        private System.Windows.Forms.Button tanButton;
        private System.Windows.Forms.Button cosButton;
        private System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button radButton;
        private System.Windows.Forms.Button invButton;
        private System.Windows.Forms.TableLayoutPanel numbersInputHolder;
        private System.Windows.Forms.Button eqButton;
        private System.Windows.Forms.Button _0Button;
        private System.Windows.Forms.Button pointButton;
        private System.Windows.Forms.Button _2Button;
        private System.Windows.Forms.Button _1Button;
        private System.Windows.Forms.Button _5Button;
        private System.Windows.Forms.Button _4Button;
        private System.Windows.Forms.Button _8Button;
        private System.Windows.Forms.Button _7Button;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Button _3Button;
        private System.Windows.Forms.Button _9Button;
        private System.Windows.Forms.Button _6Button;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TableLayoutPanel answerLabelHolder;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label toBeFocused;
        private System.Windows.Forms.Label label1;
    }
}

