namespace QLBH
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.ThemSua = new DevExpress.XtraEditors.SimpleButton();
            this.Delete = new DevExpress.XtraEditors.SimpleButton();
            this.Exit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nguyên liệu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá mua";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã NL";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(102, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Loại";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNL,
            this.TenNL,
            this.SL,
            this.GiaMua,
            this.Loai});
            this.dataGridView1.Location = new System.Drawing.Point(425, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(728, 329);
            this.dataGridView1.TabIndex = 2;
            // 
            // MaNL
            // 
            this.MaNL.HeaderText = "Mã NL";
            this.MaNL.MinimumWidth = 8;
            this.MaNL.Name = "MaNL";
            this.MaNL.Width = 150;
            // 
            // TenNL
            // 
            this.TenNL.HeaderText = "Tên NL";
            this.TenNL.MinimumWidth = 8;
            this.TenNL.Name = "TenNL";
            this.TenNL.Width = 150;
            // 
            // SL
            // 
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 8;
            this.SL.Name = "SL";
            this.SL.Width = 150;
            // 
            // GiaMua
            // 
            this.GiaMua.HeaderText = "Giá mua";
            this.GiaMua.MinimumWidth = 8;
            this.GiaMua.Name = "GiaMua";
            this.GiaMua.Width = 150;
            // 
            // Loai
            // 
            this.Loai.HeaderText = "Loại";
            this.Loai.MinimumWidth = 8;
            this.Loai.Name = "Loai";
            this.Loai.Width = 150;
            // 
            // txtMaNL
            // 
            this.txtMaNL.Location = new System.Drawing.Point(248, 110);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(165, 26);
            this.txtMaNL.TabIndex = 3;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Location = new System.Drawing.Point(248, 181);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(165, 26);
            this.txtTenNL.TabIndex = 3;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(248, 247);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(165, 26);
            this.txtSL.TabIndex = 3;
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(248, 361);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(165, 26);
            this.txtLoai.TabIndex = 3;
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(248, 310);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(165, 26);
            this.txtGiaMua.TabIndex = 3;
            // 
            // ThemSua
            // 
            this.ThemSua.Location = new System.Drawing.Point(107, 414);
            this.ThemSua.Name = "ThemSua";
            this.ThemSua.Size = new System.Drawing.Size(94, 35);
            this.ThemSua.TabIndex = 4;
            this.ThemSua.Text = "Thêm/Sửa";
            this.ThemSua.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(225, 414);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 35);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Xóa";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(325, 414);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 35);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Thoát";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 468);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.ThemSua);
            this.Controls.Add(this.txtGiaMua);
            this.Controls.Add(this.txtLoai);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTenNL);
            this.Controls.Add(this.txtMaNL);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.TextBox txtGiaMua;
        private DevExpress.XtraEditors.SimpleButton ThemSua;
        private DevExpress.XtraEditors.SimpleButton Delete;
        private DevExpress.XtraEditors.SimpleButton Exit;
    }
}

