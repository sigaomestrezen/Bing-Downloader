namespace Bing_Downloader
{
	partial class formBing
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
			this.components = new System.ComponentModel.Container();
			this.lstPaises = new System.Windows.Forms.ListBox();
			this.pcbBackground1 = new System.Windows.Forms.PictureBox();
			this.cmdSalvar1 = new System.Windows.Forms.Button();
			this.rtbSource = new System.Windows.Forms.RichTextBox();
			this.dgvImagens = new System.Windows.Forms.DataGridView();
			this.dgcData = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgcDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmdSalvar2 = new System.Windows.Forms.Button();
			this.pcbBackground2 = new System.Windows.Forms.PictureBox();
			this.cmdSalvar3 = new System.Windows.Forms.Button();
			this.pcbBackground3 = new System.Windows.Forms.PictureBox();
			this.cmdSalvar4 = new System.Windows.Forms.Button();
			this.pcbBackground4 = new System.Windows.Forms.PictureBox();
			this.cmdSalvar5 = new System.Windows.Forms.Button();
			this.pcbBackground5 = new System.Windows.Forms.PictureBox();
			this.cmdSalvar6 = new System.Windows.Forms.Button();
			this.pcbBackground6 = new System.Windows.Forms.PictureBox();
			this.cmdSalvar7 = new System.Windows.Forms.Button();
			this.pcbBackground7 = new System.Windows.Forms.PictureBox();
			this.cmdSalvar8 = new System.Windows.Forms.Button();
			this.pcbBackground8 = new System.Windows.Forms.PictureBox();
			this.grbStatus = new System.Windows.Forms.GroupBox();
			this.chkImg8 = new System.Windows.Forms.CheckBox();
			this.chkImg7 = new System.Windows.Forms.CheckBox();
			this.chkImg6 = new System.Windows.Forms.CheckBox();
			this.chkImg5 = new System.Windows.Forms.CheckBox();
			this.chkImg4 = new System.Windows.Forms.CheckBox();
			this.chkImg3 = new System.Windows.Forms.CheckBox();
			this.chkImg2 = new System.Windows.Forms.CheckBox();
			this.chkImg1 = new System.Windows.Forms.CheckBox();
			this.lblCopyright = new System.Windows.Forms.Label();
			this.grbIdioma = new System.Windows.Forms.GroupBox();
			this.rdbIdioma3 = new System.Windows.Forms.RadioButton();
			this.rdbIdioma2 = new System.Windows.Forms.RadioButton();
			this.rdbIdioma1 = new System.Windows.Forms.RadioButton();
			this.ttpInfo = new System.Windows.Forms.ToolTip(this.components);
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvImagens)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground8)).BeginInit();
			this.grbStatus.SuspendLayout();
			this.grbIdioma.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstPaises
			// 
			this.lstPaises.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lstPaises.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPaises.FormattingEnabled = true;
			this.lstPaises.Location = new System.Drawing.Point(12, 12);
			this.lstPaises.Name = "lstPaises";
			this.lstPaises.Size = new System.Drawing.Size(218, 407);
			this.lstPaises.TabIndex = 0;
			this.lstPaises.SelectedIndexChanged += new System.EventHandler(this.lstPaises_SelectedIndexChanged);
			// 
			// pcbBackground1
			// 
			this.pcbBackground1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbBackground1.Location = new System.Drawing.Point(236, 12);
			this.pcbBackground1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.pcbBackground1.Name = "pcbBackground1";
			this.pcbBackground1.Size = new System.Drawing.Size(240, 136);
			this.pcbBackground1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbBackground1.TabIndex = 10;
			this.pcbBackground1.TabStop = false;
			// 
			// cmdSalvar1
			// 
			this.cmdSalvar1.Enabled = false;
			this.cmdSalvar1.Location = new System.Drawing.Point(235, 148);
			this.cmdSalvar1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.cmdSalvar1.Name = "cmdSalvar1";
			this.cmdSalvar1.Size = new System.Drawing.Size(242, 23);
			this.cmdSalvar1.TabIndex = 3;
			this.cmdSalvar1.Text = "&Salvar";
			this.cmdSalvar1.UseVisualStyleBackColor = true;
			this.cmdSalvar1.Click += new System.EventHandler(this.cmdSalvar1_Click);
			// 
			// rtbSource
			// 
			this.rtbSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbSource.Location = new System.Drawing.Point(236, 12);
			this.rtbSource.Name = "rtbSource";
			this.rtbSource.Size = new System.Drawing.Size(731, 322);
			this.rtbSource.TabIndex = 1;
			this.rtbSource.Text = "";
			this.rtbSource.Visible = false;
			// 
			// dgvImagens
			// 
			this.dgvImagens.AllowUserToDeleteRows = false;
			this.dgvImagens.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvImagens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvImagens.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvImagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvImagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcData,
            this.dgcUrl,
            this.dgcDesc});
			this.dgvImagens.Location = new System.Drawing.Point(237, 340);
			this.dgvImagens.Name = "dgvImagens";
			this.dgvImagens.ReadOnly = true;
			this.dgvImagens.RowHeadersVisible = false;
			this.dgvImagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvImagens.Size = new System.Drawing.Size(731, 158);
			this.dgvImagens.TabIndex = 2;
			this.dgvImagens.Visible = false;
			// 
			// dgcData
			// 
			this.dgcData.HeaderText = "Data";
			this.dgcData.Name = "dgcData";
			this.dgcData.ReadOnly = true;
			this.dgcData.Width = 55;
			// 
			// dgcUrl
			// 
			this.dgcUrl.HeaderText = "URL";
			this.dgcUrl.Name = "dgcUrl";
			this.dgcUrl.ReadOnly = true;
			this.dgcUrl.Width = 54;
			// 
			// dgcDesc
			// 
			this.dgcDesc.HeaderText = "Desc";
			this.dgcDesc.Name = "dgcDesc";
			this.dgcDesc.ReadOnly = true;
			this.dgcDesc.Width = 57;
			// 
			// cmdSalvar2
			// 
			this.cmdSalvar2.Enabled = false;
			this.cmdSalvar2.Location = new System.Drawing.Point(481, 148);
			this.cmdSalvar2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.cmdSalvar2.Name = "cmdSalvar2";
			this.cmdSalvar2.Size = new System.Drawing.Size(242, 23);
			this.cmdSalvar2.TabIndex = 4;
			this.cmdSalvar2.Text = "&Salvar";
			this.cmdSalvar2.UseVisualStyleBackColor = true;
			this.cmdSalvar2.Click += new System.EventHandler(this.cmdSalvar2_Click);
			// 
			// pcbBackground2
			// 
			this.pcbBackground2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbBackground2.Location = new System.Drawing.Point(482, 12);
			this.pcbBackground2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.pcbBackground2.Name = "pcbBackground2";
			this.pcbBackground2.Size = new System.Drawing.Size(240, 136);
			this.pcbBackground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbBackground2.TabIndex = 15;
			this.pcbBackground2.TabStop = false;
			// 
			// cmdSalvar3
			// 
			this.cmdSalvar3.Enabled = false;
			this.cmdSalvar3.Location = new System.Drawing.Point(727, 148);
			this.cmdSalvar3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.cmdSalvar3.Name = "cmdSalvar3";
			this.cmdSalvar3.Size = new System.Drawing.Size(242, 23);
			this.cmdSalvar3.TabIndex = 5;
			this.cmdSalvar3.Text = "&Salvar";
			this.cmdSalvar3.UseVisualStyleBackColor = true;
			this.cmdSalvar3.Click += new System.EventHandler(this.cmdSalvar3_Click);
			// 
			// pcbBackground3
			// 
			this.pcbBackground3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbBackground3.Location = new System.Drawing.Point(728, 12);
			this.pcbBackground3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.pcbBackground3.Name = "pcbBackground3";
			this.pcbBackground3.Size = new System.Drawing.Size(240, 136);
			this.pcbBackground3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbBackground3.TabIndex = 17;
			this.pcbBackground3.TabStop = false;
			// 
			// cmdSalvar4
			// 
			this.cmdSalvar4.Enabled = false;
			this.cmdSalvar4.Location = new System.Drawing.Point(235, 312);
			this.cmdSalvar4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.cmdSalvar4.Name = "cmdSalvar4";
			this.cmdSalvar4.Size = new System.Drawing.Size(242, 23);
			this.cmdSalvar4.TabIndex = 6;
			this.cmdSalvar4.Text = "&Salvar";
			this.cmdSalvar4.UseVisualStyleBackColor = true;
			this.cmdSalvar4.Click += new System.EventHandler(this.cmdSalvar4_Click);
			// 
			// pcbBackground4
			// 
			this.pcbBackground4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbBackground4.Location = new System.Drawing.Point(236, 176);
			this.pcbBackground4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.pcbBackground4.Name = "pcbBackground4";
			this.pcbBackground4.Size = new System.Drawing.Size(240, 136);
			this.pcbBackground4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbBackground4.TabIndex = 19;
			this.pcbBackground4.TabStop = false;
			// 
			// cmdSalvar5
			// 
			this.cmdSalvar5.Enabled = false;
			this.cmdSalvar5.Location = new System.Drawing.Point(481, 312);
			this.cmdSalvar5.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.cmdSalvar5.Name = "cmdSalvar5";
			this.cmdSalvar5.Size = new System.Drawing.Size(242, 23);
			this.cmdSalvar5.TabIndex = 7;
			this.cmdSalvar5.Text = "&Salvar";
			this.cmdSalvar5.UseVisualStyleBackColor = true;
			this.cmdSalvar5.Click += new System.EventHandler(this.cmdSalvar5_Click);
			// 
			// pcbBackground5
			// 
			this.pcbBackground5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbBackground5.Location = new System.Drawing.Point(482, 176);
			this.pcbBackground5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.pcbBackground5.Name = "pcbBackground5";
			this.pcbBackground5.Size = new System.Drawing.Size(240, 136);
			this.pcbBackground5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbBackground5.TabIndex = 21;
			this.pcbBackground5.TabStop = false;
			// 
			// cmdSalvar6
			// 
			this.cmdSalvar6.Enabled = false;
			this.cmdSalvar6.Location = new System.Drawing.Point(727, 312);
			this.cmdSalvar6.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.cmdSalvar6.Name = "cmdSalvar6";
			this.cmdSalvar6.Size = new System.Drawing.Size(242, 23);
			this.cmdSalvar6.TabIndex = 8;
			this.cmdSalvar6.Text = "&Salvar";
			this.cmdSalvar6.UseVisualStyleBackColor = true;
			this.cmdSalvar6.Click += new System.EventHandler(this.cmdSalvar6_Click);
			// 
			// pcbBackground6
			// 
			this.pcbBackground6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbBackground6.Location = new System.Drawing.Point(728, 176);
			this.pcbBackground6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.pcbBackground6.Name = "pcbBackground6";
			this.pcbBackground6.Size = new System.Drawing.Size(240, 136);
			this.pcbBackground6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbBackground6.TabIndex = 23;
			this.pcbBackground6.TabStop = false;
			// 
			// cmdSalvar7
			// 
			this.cmdSalvar7.Enabled = false;
			this.cmdSalvar7.Location = new System.Drawing.Point(235, 476);
			this.cmdSalvar7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.cmdSalvar7.Name = "cmdSalvar7";
			this.cmdSalvar7.Size = new System.Drawing.Size(242, 23);
			this.cmdSalvar7.TabIndex = 9;
			this.cmdSalvar7.Text = "&Salvar";
			this.cmdSalvar7.UseVisualStyleBackColor = true;
			this.cmdSalvar7.Click += new System.EventHandler(this.cmdSalvar7_Click);
			// 
			// pcbBackground7
			// 
			this.pcbBackground7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbBackground7.Location = new System.Drawing.Point(236, 340);
			this.pcbBackground7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.pcbBackground7.Name = "pcbBackground7";
			this.pcbBackground7.Size = new System.Drawing.Size(240, 136);
			this.pcbBackground7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbBackground7.TabIndex = 25;
			this.pcbBackground7.TabStop = false;
			// 
			// cmdSalvar8
			// 
			this.cmdSalvar8.Enabled = false;
			this.cmdSalvar8.Location = new System.Drawing.Point(481, 476);
			this.cmdSalvar8.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.cmdSalvar8.Name = "cmdSalvar8";
			this.cmdSalvar8.Size = new System.Drawing.Size(242, 23);
			this.cmdSalvar8.TabIndex = 10;
			this.cmdSalvar8.Text = "&Salvar";
			this.cmdSalvar8.UseVisualStyleBackColor = true;
			this.cmdSalvar8.Click += new System.EventHandler(this.cmdSalvar8_Click);
			// 
			// pcbBackground8
			// 
			this.pcbBackground8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbBackground8.Location = new System.Drawing.Point(482, 340);
			this.pcbBackground8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.pcbBackground8.Name = "pcbBackground8";
			this.pcbBackground8.Size = new System.Drawing.Size(240, 136);
			this.pcbBackground8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pcbBackground8.TabIndex = 27;
			this.pcbBackground8.TabStop = false;
			// 
			// grbStatus
			// 
			this.grbStatus.Controls.Add(this.chkImg8);
			this.grbStatus.Controls.Add(this.chkImg7);
			this.grbStatus.Controls.Add(this.chkImg6);
			this.grbStatus.Controls.Add(this.chkImg5);
			this.grbStatus.Controls.Add(this.chkImg4);
			this.grbStatus.Controls.Add(this.chkImg3);
			this.grbStatus.Controls.Add(this.chkImg2);
			this.grbStatus.Controls.Add(this.chkImg1);
			this.grbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbStatus.ForeColor = System.Drawing.Color.Blue;
			this.grbStatus.Location = new System.Drawing.Point(728, 341);
			this.grbStatus.Name = "grbStatus";
			this.grbStatus.Size = new System.Drawing.Size(239, 158);
			this.grbStatus.TabIndex = 11;
			this.grbStatus.TabStop = false;
			this.grbStatus.Text = " STATUS ";
			// 
			// chkImg8
			// 
			this.chkImg8.AutoSize = true;
			this.chkImg8.Enabled = false;
			this.chkImg8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkImg8.ForeColor = System.Drawing.Color.Black;
			this.chkImg8.Location = new System.Drawing.Point(115, 42);
			this.chkImg8.Name = "chkImg8";
			this.chkImg8.Size = new System.Drawing.Size(72, 17);
			this.chkImg8.TabIndex = 7;
			this.chkImg8.Text = "Imagem 8";
			this.chkImg8.UseVisualStyleBackColor = true;
			// 
			// chkImg7
			// 
			this.chkImg7.AutoSize = true;
			this.chkImg7.Enabled = false;
			this.chkImg7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkImg7.ForeColor = System.Drawing.Color.Black;
			this.chkImg7.Location = new System.Drawing.Point(115, 19);
			this.chkImg7.Name = "chkImg7";
			this.chkImg7.Size = new System.Drawing.Size(72, 17);
			this.chkImg7.TabIndex = 6;
			this.chkImg7.Text = "Imagem 7";
			this.chkImg7.UseVisualStyleBackColor = true;
			// 
			// chkImg6
			// 
			this.chkImg6.AutoSize = true;
			this.chkImg6.Enabled = false;
			this.chkImg6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkImg6.ForeColor = System.Drawing.Color.Black;
			this.chkImg6.Location = new System.Drawing.Point(6, 134);
			this.chkImg6.Name = "chkImg6";
			this.chkImg6.Size = new System.Drawing.Size(72, 17);
			this.chkImg6.TabIndex = 5;
			this.chkImg6.Text = "Imagem 6";
			this.chkImg6.UseVisualStyleBackColor = true;
			// 
			// chkImg5
			// 
			this.chkImg5.AutoSize = true;
			this.chkImg5.Enabled = false;
			this.chkImg5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkImg5.ForeColor = System.Drawing.Color.Black;
			this.chkImg5.Location = new System.Drawing.Point(6, 111);
			this.chkImg5.Name = "chkImg5";
			this.chkImg5.Size = new System.Drawing.Size(72, 17);
			this.chkImg5.TabIndex = 4;
			this.chkImg5.Text = "Imagem 5";
			this.chkImg5.UseVisualStyleBackColor = true;
			// 
			// chkImg4
			// 
			this.chkImg4.AutoSize = true;
			this.chkImg4.Enabled = false;
			this.chkImg4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkImg4.ForeColor = System.Drawing.Color.Black;
			this.chkImg4.Location = new System.Drawing.Point(6, 88);
			this.chkImg4.Name = "chkImg4";
			this.chkImg4.Size = new System.Drawing.Size(72, 17);
			this.chkImg4.TabIndex = 3;
			this.chkImg4.Text = "Imagem 4";
			this.chkImg4.UseVisualStyleBackColor = true;
			// 
			// chkImg3
			// 
			this.chkImg3.AutoSize = true;
			this.chkImg3.Enabled = false;
			this.chkImg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkImg3.ForeColor = System.Drawing.Color.Black;
			this.chkImg3.Location = new System.Drawing.Point(6, 65);
			this.chkImg3.Name = "chkImg3";
			this.chkImg3.Size = new System.Drawing.Size(72, 17);
			this.chkImg3.TabIndex = 2;
			this.chkImg3.Text = "Imagem 3";
			this.chkImg3.UseVisualStyleBackColor = true;
			// 
			// chkImg2
			// 
			this.chkImg2.AutoSize = true;
			this.chkImg2.Enabled = false;
			this.chkImg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkImg2.ForeColor = System.Drawing.Color.Black;
			this.chkImg2.Location = new System.Drawing.Point(6, 42);
			this.chkImg2.Name = "chkImg2";
			this.chkImg2.Size = new System.Drawing.Size(72, 17);
			this.chkImg2.TabIndex = 1;
			this.chkImg2.Text = "Imagem 2";
			this.chkImg2.UseVisualStyleBackColor = true;
			// 
			// chkImg1
			// 
			this.chkImg1.AutoSize = true;
			this.chkImg1.Enabled = false;
			this.chkImg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkImg1.ForeColor = System.Drawing.Color.Black;
			this.chkImg1.Location = new System.Drawing.Point(6, 19);
			this.chkImg1.Name = "chkImg1";
			this.chkImg1.Size = new System.Drawing.Size(72, 17);
			this.chkImg1.TabIndex = 0;
			this.chkImg1.Text = "Imagem 1";
			this.chkImg1.UseVisualStyleBackColor = true;
			// 
			// lblCopyright
			// 
			this.lblCopyright.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCopyright.ForeColor = System.Drawing.Color.Blue;
			this.lblCopyright.Location = new System.Drawing.Point(12, 501);
			this.lblCopyright.Name = "lblCopyright";
			this.lblCopyright.Size = new System.Drawing.Size(955, 12);
			this.lblCopyright.TabIndex = 12;
			this.lblCopyright.Text = "COPYRIGHT © 2019 BY VITOR HUGO FALCÃO MONTAN";
			this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grbIdioma
			// 
			this.grbIdioma.Controls.Add(this.rdbIdioma3);
			this.grbIdioma.Controls.Add(this.rdbIdioma2);
			this.grbIdioma.Controls.Add(this.rdbIdioma1);
			this.grbIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbIdioma.ForeColor = System.Drawing.Color.Blue;
			this.grbIdioma.Location = new System.Drawing.Point(13, 432);
			this.grbIdioma.Name = "grbIdioma";
			this.grbIdioma.Size = new System.Drawing.Size(218, 67);
			this.grbIdioma.TabIndex = 28;
			this.grbIdioma.TabStop = false;
			this.grbIdioma.Text = " IDIOMA ";
			// 
			// rdbIdioma3
			// 
			this.rdbIdioma3.AutoSize = true;
			this.rdbIdioma3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbIdioma3.ForeColor = System.Drawing.Color.Black;
			this.rdbIdioma3.Location = new System.Drawing.Point(112, 19);
			this.rdbIdioma3.Name = "rdbIdioma3";
			this.rdbIdioma3.Size = new System.Drawing.Size(69, 17);
			this.rdbIdioma3.TabIndex = 2;
			this.rdbIdioma3.Text = "&Espanhol";
			this.rdbIdioma3.UseVisualStyleBackColor = true;
			this.rdbIdioma3.CheckedChanged += new System.EventHandler(this.rdbIdioma3_CheckedChanged);
			// 
			// rdbIdioma2
			// 
			this.rdbIdioma2.AutoSize = true;
			this.rdbIdioma2.Checked = true;
			this.rdbIdioma2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbIdioma2.ForeColor = System.Drawing.Color.Black;
			this.rdbIdioma2.Location = new System.Drawing.Point(6, 42);
			this.rdbIdioma2.Name = "rdbIdioma2";
			this.rdbIdioma2.Size = new System.Drawing.Size(53, 17);
			this.rdbIdioma2.TabIndex = 1;
			this.rdbIdioma2.TabStop = true;
			this.rdbIdioma2.Text = "&Inglês";
			this.rdbIdioma2.UseVisualStyleBackColor = true;
			this.rdbIdioma2.CheckedChanged += new System.EventHandler(this.rdbIdioma2_CheckedChanged);
			// 
			// rdbIdioma1
			// 
			this.rdbIdioma1.AutoSize = true;
			this.rdbIdioma1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbIdioma1.ForeColor = System.Drawing.Color.Black;
			this.rdbIdioma1.Location = new System.Drawing.Point(6, 19);
			this.rdbIdioma1.Name = "rdbIdioma1";
			this.rdbIdioma1.Size = new System.Drawing.Size(73, 17);
			this.rdbIdioma1.TabIndex = 0;
			this.rdbIdioma1.Text = "&Português";
			this.rdbIdioma1.UseVisualStyleBackColor = true;
			this.rdbIdioma1.CheckedChanged += new System.EventHandler(this.rdbIdioma1_CheckedChanged);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// formBing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(979, 522);
			this.Controls.Add(this.grbIdioma);
			this.Controls.Add(this.lblCopyright);
			this.Controls.Add(this.lstPaises);
			this.Controls.Add(this.cmdSalvar6);
			this.Controls.Add(this.pcbBackground6);
			this.Controls.Add(this.cmdSalvar5);
			this.Controls.Add(this.pcbBackground5);
			this.Controls.Add(this.cmdSalvar4);
			this.Controls.Add(this.pcbBackground4);
			this.Controls.Add(this.cmdSalvar3);
			this.Controls.Add(this.pcbBackground3);
			this.Controls.Add(this.cmdSalvar2);
			this.Controls.Add(this.pcbBackground2);
			this.Controls.Add(this.cmdSalvar1);
			this.Controls.Add(this.pcbBackground1);
			this.Controls.Add(this.grbStatus);
			this.Controls.Add(this.cmdSalvar8);
			this.Controls.Add(this.pcbBackground8);
			this.Controls.Add(this.cmdSalvar7);
			this.Controls.Add(this.pcbBackground7);
			this.Controls.Add(this.rtbSource);
			this.Controls.Add(this.dgvImagens);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = global::Bing_Downloader.Properties.Resources.icons8_bing;
			this.MaximizeBox = false;
			this.Name = "formBing";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BING WALLPAPER DOWNLOADER";
			this.Load += new System.EventHandler(this.formBing_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvImagens)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pcbBackground8)).EndInit();
			this.grbStatus.ResumeLayout(false);
			this.grbStatus.PerformLayout();
			this.grbIdioma.ResumeLayout(false);
			this.grbIdioma.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstPaises;
		private System.Windows.Forms.PictureBox pcbBackground1;
		private System.Windows.Forms.Button cmdSalvar1;
		private System.Windows.Forms.RichTextBox rtbSource;
		private System.Windows.Forms.DataGridView dgvImagens;
		private System.Windows.Forms.Button cmdSalvar2;
		private System.Windows.Forms.PictureBox pcbBackground2;
		private System.Windows.Forms.Button cmdSalvar3;
		private System.Windows.Forms.PictureBox pcbBackground3;
		private System.Windows.Forms.Button cmdSalvar4;
		private System.Windows.Forms.PictureBox pcbBackground4;
		private System.Windows.Forms.Button cmdSalvar5;
		private System.Windows.Forms.PictureBox pcbBackground5;
		private System.Windows.Forms.Button cmdSalvar6;
		private System.Windows.Forms.PictureBox pcbBackground6;
		private System.Windows.Forms.Button cmdSalvar7;
		private System.Windows.Forms.PictureBox pcbBackground7;
		private System.Windows.Forms.Button cmdSalvar8;
		private System.Windows.Forms.PictureBox pcbBackground8;
		private System.Windows.Forms.GroupBox grbStatus;
		private System.Windows.Forms.CheckBox chkImg8;
		private System.Windows.Forms.CheckBox chkImg7;
		private System.Windows.Forms.CheckBox chkImg6;
		private System.Windows.Forms.CheckBox chkImg5;
		private System.Windows.Forms.CheckBox chkImg4;
		private System.Windows.Forms.CheckBox chkImg3;
		private System.Windows.Forms.CheckBox chkImg2;
		private System.Windows.Forms.CheckBox chkImg1;
		private System.Windows.Forms.Label lblCopyright;
		private System.Windows.Forms.GroupBox grbIdioma;
		private System.Windows.Forms.RadioButton rdbIdioma3;
		private System.Windows.Forms.RadioButton rdbIdioma2;
		private System.Windows.Forms.RadioButton rdbIdioma1;
		private System.Windows.Forms.ToolTip ttpInfo;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcData;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcUrl;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgcDesc;
		private System.Windows.Forms.Timer timer1;
	}
}

