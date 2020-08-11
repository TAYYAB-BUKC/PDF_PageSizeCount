namespace PDF_PageSizeCount
{
	partial class PageSizeCounter
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.Grd_PageSizeCounter = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Filepath = new System.Windows.Forms.TextBox();
			this.button5 = new System.Windows.Forms.Button();
			this.Button_Choose = new System.Windows.Forms.Button();
			this.Button_MultipleFiles = new System.Windows.Forms.Button();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.Grd_PageSizeCounter)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel2.Location = new System.Drawing.Point(18, 530);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(796, 5);
			this.panel2.TabIndex = 74;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(244, 32);
			this.label1.TabIndex = 75;
			this.label1.Text = "PageSize Counter";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
			this.panel1.Location = new System.Drawing.Point(16, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(797, 5);
			this.panel1.TabIndex = 73;
			// 
			// Grd_PageSizeCounter
			// 
			this.Grd_PageSizeCounter.AllowUserToAddRows = false;
			this.Grd_PageSizeCounter.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Grd_PageSizeCounter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.Grd_PageSizeCounter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Grd_PageSizeCounter.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.Grd_PageSizeCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Grd_PageSizeCounter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MediumBlue;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Grd_PageSizeCounter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Grd_PageSizeCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grd_PageSizeCounter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Count,
            this.Height,
            this.Width,
            this.FileName});
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Grd_PageSizeCounter.DefaultCellStyle = dataGridViewCellStyle7;
			this.Grd_PageSizeCounter.DoubleBuffered = true;
			this.Grd_PageSizeCounter.EnableHeadersVisualStyles = false;
			this.Grd_PageSizeCounter.HeaderBgColor = System.Drawing.SystemColors.Control;
			this.Grd_PageSizeCounter.HeaderForeColor = System.Drawing.Color.MediumBlue;
			this.Grd_PageSizeCounter.Location = new System.Drawing.Point(20, 192);
			this.Grd_PageSizeCounter.Name = "Grd_PageSizeCounter";
			this.Grd_PageSizeCounter.ReadOnly = true;
			this.Grd_PageSizeCounter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.Grd_PageSizeCounter.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			this.Grd_PageSizeCounter.Size = new System.Drawing.Size(794, 323);
			this.Grd_PageSizeCounter.TabIndex = 89;
			// 
			// Filepath
			// 
			this.Filepath.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Filepath.Location = new System.Drawing.Point(181, 81);
			this.Filepath.Name = "Filepath";
			this.Filepath.Size = new System.Drawing.Size(634, 26);
			this.Filepath.TabIndex = 99;
			// 
			// button5
			// 
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.LightGray;
			this.button5.Location = new System.Drawing.Point(800, 1);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(25, 25);
			this.button5.TabIndex = 100;
			this.button5.Text = "X";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// Button_Choose
			// 
			this.Button_Choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Button_Choose.FlatAppearance.BorderSize = 0;
			this.Button_Choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button_Choose.ForeColor = System.Drawing.Color.LightGray;
			this.Button_Choose.Location = new System.Drawing.Point(25, 76);
			this.Button_Choose.Name = "Button_Choose";
			this.Button_Choose.Size = new System.Drawing.Size(150, 40);
			this.Button_Choose.TabIndex = 101;
			this.Button_Choose.Text = "Choose PDF File";
			this.Button_Choose.UseVisualStyleBackColor = false;
			this.Button_Choose.Click += new System.EventHandler(this.Button_Choose_Click);
			// 
			// Button_MultipleFiles
			// 
			this.Button_MultipleFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
			this.Button_MultipleFiles.FlatAppearance.BorderSize = 0;
			this.Button_MultipleFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Button_MultipleFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button_MultipleFiles.ForeColor = System.Drawing.Color.LightGray;
			this.Button_MultipleFiles.Location = new System.Drawing.Point(25, 122);
			this.Button_MultipleFiles.Name = "Button_MultipleFiles";
			this.Button_MultipleFiles.Size = new System.Drawing.Size(150, 60);
			this.Button_MultipleFiles.TabIndex = 102;
			this.Button_MultipleFiles.Text = "Choose Multiple PDFs";
			this.Button_MultipleFiles.UseVisualStyleBackColor = false;
			this.Button_MultipleFiles.Click += new System.EventHandler(this.Button_MultipleFiles_Click);
			// 
			// Count
			// 
			this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Count.DefaultCellStyle = dataGridViewCellStyle3;
			this.Count.FillWeight = 78.71768F;
			this.Count.HeaderText = "Count";
			this.Count.Name = "Count";
			this.Count.ReadOnly = true;
			// 
			// Height
			// 
			this.Height.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Height.DefaultCellStyle = dataGridViewCellStyle4;
			this.Height.FillWeight = 66.46481F;
			this.Height.HeaderText = "Height";
			this.Height.Name = "Height";
			this.Height.ReadOnly = true;
			// 
			// Width
			// 
			this.Width.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Width.DefaultCellStyle = dataGridViewCellStyle5;
			this.Width.FillWeight = 51.77182F;
			this.Width.HeaderText = "Width";
			this.Width.Name = "Width";
			this.Width.ReadOnly = true;
			// 
			// FileName
			// 
			this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
			this.FileName.DefaultCellStyle = dataGridViewCellStyle6;
			this.FileName.FillWeight = 203.0457F;
			this.FileName.HeaderText = "FileName";
			this.FileName.Name = "FileName";
			this.FileName.ReadOnly = true;
			// 
			// PageSizeCounter
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(827, 554);
			this.Controls.Add(this.Button_MultipleFiles);
			this.Controls.Add(this.Button_Choose);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.Filepath);
			this.Controls.Add(this.Grd_PageSizeCounter);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "PageSizeCounter";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PageSizeCounter_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PageSizeCounter_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PageSizeCounter_MouseUp);
			((System.ComponentModel.ISupportInitialize)(this.Grd_PageSizeCounter)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid Grd_PageSizeCounter;
		private System.Windows.Forms.TextBox Filepath;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button Button_Choose;
		private System.Windows.Forms.Button Button_MultipleFiles;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
		private System.Windows.Forms.DataGridViewTextBoxColumn Height;
		private System.Windows.Forms.DataGridViewTextBoxColumn Width;
		private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
	}
}