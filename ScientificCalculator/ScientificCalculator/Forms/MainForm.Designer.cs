
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
            this.operationsLableHolder = new System.Windows.Forms.TableLayoutPanel();
            this.instantOperationLabel = new System.Windows.Forms.Label();
            this.advancedOperationsTable = new System.Windows.Forms.TableLayoutPanel();
            this.invButton = new System.Windows.Forms.Button();
            this.radButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.tanButton = new System.Windows.Forms.Button();
            this.percButton = new System.Windows.Forms.Button();
            this.lnButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.factButton = new System.Windows.Forms.Button();
            this.powButton = new System.Windows.Forms.Button();
            this.piButton = new System.Windows.Forms.Button();
            this.expButton = new System.Windows.Forms.Button();
            this.leftParanthButton = new System.Windows.Forms.Button();
            this.rightParanthButton = new System.Windows.Forms.Button();
            this.squareRootButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.titlebarPanel.SuspendLayout();
            this.calculationsScreenPanel.SuspendLayout();
            this.operationsLableHolder.SuspendLayout();
            this.advancedOperationsTable.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebarPanel
            // 
            this.titlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(67)))), ((int)(((byte)(83)))));
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
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // calculationsScreenPanel
            // 
            this.calculationsScreenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(92)))), ((int)(((byte)(104)))));
            this.calculationsScreenPanel.Controls.Add(this.operationsLableHolder);
            this.calculationsScreenPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.calculationsScreenPanel.Location = new System.Drawing.Point(0, 35);
            this.calculationsScreenPanel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.calculationsScreenPanel.Name = "calculationsScreenPanel";
            this.calculationsScreenPanel.Size = new System.Drawing.Size(500, 120);
            this.calculationsScreenPanel.TabIndex = 1;
            // 
            // operationsLableHolder
            // 
            this.operationsLableHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationsLableHolder.ColumnCount = 1;
            this.operationsLableHolder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operationsLableHolder.Controls.Add(this.instantOperationLabel, 0, 0);
            this.operationsLableHolder.Location = new System.Drawing.Point(12, 20);
            this.operationsLableHolder.Name = "operationsLableHolder";
            this.operationsLableHolder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.operationsLableHolder.RowCount = 1;
            this.operationsLableHolder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.operationsLableHolder.Size = new System.Drawing.Size(448, 42);
            this.operationsLableHolder.TabIndex = 2;
            // 
            // instantOperationLabel
            // 
            this.instantOperationLabel.AutoSize = true;
            this.instantOperationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.instantOperationLabel.Font = new System.Drawing.Font("URWImperialTExtBol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instantOperationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(130)))), ((int)(((byte)(139)))));
            this.instantOperationLabel.Location = new System.Drawing.Point(3, 0);
            this.instantOperationLabel.Name = "instantOperationLabel";
            this.instantOperationLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.instantOperationLabel.Size = new System.Drawing.Size(442, 42);
            this.instantOperationLabel.TabIndex = 0;
            this.instantOperationLabel.Text = "230 + 125 + 19 * 19 +20";
            this.instantOperationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.invButton.Text = "inv";
            this.invButton.UseVisualStyleBackColor = true;
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
            this.radButton.Text = "rad";
            this.radButton.UseVisualStyleBackColor = true;
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
            this.sinButton.Text = "sin";
            this.sinButton.UseVisualStyleBackColor = true;
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
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = true;
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
            this.tanButton.Text = "tan";
            this.tanButton.UseVisualStyleBackColor = true;
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
            this.percButton.Text = "%";
            this.percButton.UseVisualStyleBackColor = true;
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
            this.lnButton.Text = "ln";
            this.lnButton.UseVisualStyleBackColor = true;
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
            this.logButton.Text = "log";
            this.logButton.UseVisualStyleBackColor = true;
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
            this.factButton.Text = "!";
            this.factButton.UseVisualStyleBackColor = true;
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
            this.powButton.Text = "^";
            this.powButton.UseVisualStyleBackColor = true;
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
            this.piButton.Text = "π";
            this.piButton.UseVisualStyleBackColor = true;
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
            this.expButton.Text = "exp";
            this.expButton.UseVisualStyleBackColor = true;
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
            this.leftParanthButton.Text = "(";
            this.leftParanthButton.UseVisualStyleBackColor = true;
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
            this.rightParanthButton.Text = ")";
            this.rightParanthButton.UseVisualStyleBackColor = true;
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
            this.squareRootButton.Text = "√";
            this.squareRootButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.eqButton, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this._0Button, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.pointButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this._2Button, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this._1Button, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this._5Button, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this._4Button, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this._8Button, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this._7Button, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.backButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ceButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this._3Button, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this._9Button, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this._6Button, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.divButton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.mulButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.subButton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.addButton, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 155);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 245);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // eqButton
            // 
            this.eqButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(165)))), ((int)(((byte)(46)))));
            this.tableLayoutPanel1.SetColumnSpan(this.eqButton, 2);
            this.eqButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eqButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eqButton.FlatAppearance.BorderSize = 0;
            this.eqButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eqButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.eqButton.Location = new System.Drawing.Point(169, 199);
            this.eqButton.Name = "eqButton";
            this.eqButton.Size = new System.Drawing.Size(161, 43);
            this.eqButton.TabIndex = 17;
            this.eqButton.Text = "=";
            this.eqButton.UseVisualStyleBackColor = false;
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
            this._0Button.Text = "0";
            this._0Button.UseVisualStyleBackColor = false;
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
            this._2Button.Text = "2";
            this._2Button.UseVisualStyleBackColor = false;
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
            this._1Button.Text = "1";
            this._1Button.UseVisualStyleBackColor = false;
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
            this._5Button.Text = "5";
            this._5Button.UseVisualStyleBackColor = false;
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
            this._4Button.Text = "4";
            this._4Button.UseVisualStyleBackColor = false;
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
            this._8Button.Text = "8";
            this._8Button.UseVisualStyleBackColor = false;
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
            this._7Button.Text = "7";
            this._7Button.UseVisualStyleBackColor = false;
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
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = false;
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
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = false;
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
            this._3Button.Text = "3";
            this._3Button.UseVisualStyleBackColor = false;
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
            this._9Button.Text = "9";
            this._9Button.UseVisualStyleBackColor = false;
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
            this._6Button.Text = "6";
            this._6Button.UseVisualStyleBackColor = false;
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
            this.divButton.Text = "÷";
            this.divButton.UseVisualStyleBackColor = false;
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
            this.mulButton.Text = "×";
            this.mulButton.UseVisualStyleBackColor = false;
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
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = false;
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
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.advancedOperationsTable);
            this.Controls.Add(this.calculationsScreenPanel);
            this.Controls.Add(this.titlebarPanel);
            this.Font = new System.Drawing.Font("URWImperialTExtBol", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.titlebarPanel.ResumeLayout(false);
            this.calculationsScreenPanel.ResumeLayout(false);
            this.operationsLableHolder.ResumeLayout(false);
            this.operationsLableHolder.PerformLayout();
            this.advancedOperationsTable.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlebarPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Panel calculationsScreenPanel;
        private System.Windows.Forms.Label instantOperationLabel;
        private System.Windows.Forms.TableLayoutPanel operationsLableHolder;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
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
    }
}

