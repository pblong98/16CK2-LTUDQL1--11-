namespace GiaoDien
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.MaNhom_TXT = new System.Windows.Forms.TextBox();
			this.TenNhom_TXT = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.VaiTro_CBB = new System.Windows.Forms.ComboBox();
			this.VaiTro = new System.Windows.Forms.Label();
			this.add_BTN = new System.Windows.Forms.Button();
			this.xoa_BTN = new System.Windows.Forms.Button();
			this.edit_BTN = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 428);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã nhóm";
			// 
			// MaNhom_TXT
			// 
			this.MaNhom_TXT.Location = new System.Drawing.Point(70, 425);
			this.MaNhom_TXT.Name = "MaNhom_TXT";
			this.MaNhom_TXT.Size = new System.Drawing.Size(100, 20);
			this.MaNhom_TXT.TabIndex = 1;
			// 
			// TenNhom_TXT
			// 
			this.TenNhom_TXT.AutoSize = true;
			this.TenNhom_TXT.Location = new System.Drawing.Point(184, 428);
			this.TenNhom_TXT.Name = "TenNhom_TXT";
			this.TenNhom_TXT.Size = new System.Drawing.Size(55, 13);
			this.TenNhom_TXT.TabIndex = 0;
			this.TenNhom_TXT.Text = "Tên nhóm";
			this.TenNhom_TXT.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(242, 425);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 1;
			// 
			// VaiTro_CBB
			// 
			this.VaiTro_CBB.FormattingEnabled = true;
			this.VaiTro_CBB.Items.AddRange(new object[] {
            "Customers",
            "Employees",
            "Orders",
            "Products",
            "Supplier"});
			this.VaiTro_CBB.Location = new System.Drawing.Point(410, 424);
			this.VaiTro_CBB.Name = "VaiTro_CBB";
			this.VaiTro_CBB.Size = new System.Drawing.Size(121, 21);
			this.VaiTro_CBB.TabIndex = 2;
			// 
			// VaiTro
			// 
			this.VaiTro.AutoSize = true;
			this.VaiTro.Location = new System.Drawing.Point(361, 428);
			this.VaiTro.Name = "VaiTro";
			this.VaiTro.Size = new System.Drawing.Size(37, 13);
			this.VaiTro.TabIndex = 0;
			this.VaiTro.Text = "Vai trò";
			this.VaiTro.Click += new System.EventHandler(this.label2_Click);
			// 
			// add_BTN
			// 
			this.add_BTN.Location = new System.Drawing.Point(546, 423);
			this.add_BTN.Name = "add_BTN";
			this.add_BTN.Size = new System.Drawing.Size(75, 23);
			this.add_BTN.TabIndex = 3;
			this.add_BTN.Text = "Thêm";
			this.add_BTN.UseVisualStyleBackColor = true;
			// 
			// xoa_BTN
			// 
			this.xoa_BTN.Location = new System.Drawing.Point(627, 423);
			this.xoa_BTN.Name = "xoa_BTN";
			this.xoa_BTN.Size = new System.Drawing.Size(75, 23);
			this.xoa_BTN.TabIndex = 3;
			this.xoa_BTN.Text = "Xóa";
			this.xoa_BTN.UseVisualStyleBackColor = true;
			// 
			// edit_BTN
			// 
			this.edit_BTN.Location = new System.Drawing.Point(708, 423);
			this.edit_BTN.Name = "edit_BTN";
			this.edit_BTN.Size = new System.Drawing.Size(75, 23);
			this.edit_BTN.TabIndex = 3;
			this.edit_BTN.Text = "Sửa";
			this.edit_BTN.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(776, 405);
			this.dataGridView1.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.edit_BTN);
			this.Controls.Add(this.xoa_BTN);
			this.Controls.Add(this.add_BTN);
			this.Controls.Add(this.VaiTro_CBB);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.VaiTro);
			this.Controls.Add(this.TenNhom_TXT);
			this.Controls.Add(this.MaNhom_TXT);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox MaNhom_TXT;
		private System.Windows.Forms.Label TenNhom_TXT;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ComboBox VaiTro_CBB;
		private System.Windows.Forms.Label VaiTro;
		private System.Windows.Forms.Button add_BTN;
		private System.Windows.Forms.Button xoa_BTN;
		private System.Windows.Forms.Button edit_BTN;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

