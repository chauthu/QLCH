namespace QLCH
{
    partial class Formql
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
            this.dtgrid1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtbthemdienthoai = new System.Windows.Forms.TextBox();
            this.txtbthemdiachi = new System.Windows.Forms.TextBox();
            this.txtbthemluong = new System.Windows.Forms.TextBox();
            this.txtbthemtennv = new System.Windows.Forms.TextBox();
            this.txtbthemmanv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btntim = new System.Windows.Forms.Button();
            this.txtbtennv = new System.Windows.Forms.TextBox();
            this.txtbmanv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtgridcanv = new System.Windows.Forms.DataGridView();
            this.btntimca = new System.Windows.Forms.Button();
            this.txtbcaTennv = new System.Windows.Forms.TextBox();
            this.txtbcamanv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgridca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridcanv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridca)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid1
            // 
            this.dtgrid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid1.Location = new System.Drawing.Point(-4, 220);
            this.dtgrid1.Name = "dtgrid1";
            this.dtgrid1.ReadOnly = true;
            this.dtgrid1.ShowCellErrors = false;
            this.dtgrid1.ShowEditingIcon = false;
            this.dtgrid1.ShowRowErrors = false;
            this.dtgrid1.Size = new System.Drawing.Size(768, 257);
            this.dtgrid1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 532);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnxoa);
            this.tabPage1.Controls.Add(this.btnthem);
            this.tabPage1.Controls.Add(this.txtbthemdienthoai);
            this.tabPage1.Controls.Add(this.txtbthemdiachi);
            this.tabPage1.Controls.Add(this.txtbthemluong);
            this.tabPage1.Controls.Add(this.txtbthemtennv);
            this.tabPage1.Controls.Add(this.txtbthemmanv);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btntim);
            this.tabPage1.Controls.Add(this.txtbtennv);
            this.tabPage1.Controls.Add(this.txtbmanv);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtgrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 506);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(251, 69);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(101, 67);
            this.btnxoa.TabIndex = 18;
            this.btnxoa.Text = "Xoá nhân viên theo mã nhân viên";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(685, 76);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(73, 52);
            this.btnthem.TabIndex = 17;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtbthemdienthoai
            // 
            this.txtbthemdienthoai.Location = new System.Drawing.Point(545, 156);
            this.txtbthemdienthoai.Name = "txtbthemdienthoai";
            this.txtbthemdienthoai.Size = new System.Drawing.Size(125, 20);
            this.txtbthemdienthoai.TabIndex = 16;
            // 
            // txtbthemdiachi
            // 
            this.txtbthemdiachi.Location = new System.Drawing.Point(545, 119);
            this.txtbthemdiachi.Name = "txtbthemdiachi";
            this.txtbthemdiachi.Size = new System.Drawing.Size(125, 20);
            this.txtbthemdiachi.TabIndex = 15;
            // 
            // txtbthemluong
            // 
            this.txtbthemluong.Location = new System.Drawing.Point(545, 93);
            this.txtbthemluong.Name = "txtbthemluong";
            this.txtbthemluong.Size = new System.Drawing.Size(125, 20);
            this.txtbthemluong.TabIndex = 14;
            // 
            // txtbthemtennv
            // 
            this.txtbthemtennv.Location = new System.Drawing.Point(545, 61);
            this.txtbthemtennv.Name = "txtbthemtennv";
            this.txtbthemtennv.Size = new System.Drawing.Size(125, 20);
            this.txtbthemtennv.TabIndex = 13;
            // 
            // txtbthemmanv
            // 
            this.txtbthemmanv.Location = new System.Drawing.Point(545, 28);
            this.txtbthemmanv.Name = "txtbthemmanv";
            this.txtbthemmanv.Size = new System.Drawing.Size(125, 20);
            this.txtbthemmanv.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Lương";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thêm nhân viên";
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(251, 13);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(101, 48);
            this.btntim.TabIndex = 5;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // txtbtennv
            // 
            this.txtbtennv.Location = new System.Drawing.Point(105, 41);
            this.txtbtennv.Name = "txtbtennv";
            this.txtbtennv.Size = new System.Drawing.Size(115, 20);
            this.txtbtennv.TabIndex = 4;
            // 
            // txtbmanv
            // 
            this.txtbmanv.Location = new System.Drawing.Point(105, 13);
            this.txtbmanv.Name = "txtbmanv";
            this.txtbmanv.Size = new System.Drawing.Size(116, 20);
            this.txtbmanv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtgridcanv);
            this.tabPage2.Controls.Add(this.btntimca);
            this.tabPage2.Controls.Add(this.txtbcaTennv);
            this.tabPage2.Controls.Add(this.txtbcamanv);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dtgridca);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(760, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtgridcanv
            // 
            this.dtgridcanv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgridcanv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridcanv.Location = new System.Drawing.Point(-4, 152);
            this.dtgridcanv.Name = "dtgridcanv";
            this.dtgridcanv.Size = new System.Drawing.Size(567, 329);
            this.dtgridcanv.TabIndex = 11;
            // 
            // btntimca
            // 
            this.btntimca.Location = new System.Drawing.Point(253, 21);
            this.btntimca.Name = "btntimca";
            this.btntimca.Size = new System.Drawing.Size(101, 48);
            this.btntimca.TabIndex = 10;
            this.btntimca.Text = "Tìm";
            this.btntimca.UseVisualStyleBackColor = true;
            this.btntimca.Click += new System.EventHandler(this.btntimca_Click);
            // 
            // txtbcaTennv
            // 
            this.txtbcaTennv.Location = new System.Drawing.Point(107, 49);
            this.txtbcaTennv.Name = "txtbcaTennv";
            this.txtbcaTennv.Size = new System.Drawing.Size(115, 20);
            this.txtbcaTennv.TabIndex = 9;
            // 
            // txtbcamanv
            // 
            this.txtbcamanv.Location = new System.Drawing.Point(107, 21);
            this.txtbcamanv.Name = "txtbcamanv";
            this.txtbcamanv.Size = new System.Drawing.Size(116, 20);
            this.txtbcamanv.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tên nhân viên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Mã nhân viên";
            // 
            // dtgridca
            // 
            this.dtgridca.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgridca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridca.Location = new System.Drawing.Point(522, 152);
            this.dtgridca.Name = "dtgridca";
            this.dtgridca.ShowCellErrors = false;
            this.dtgridca.ShowEditingIcon = false;
            this.dtgridca.ShowRowErrors = false;
            this.dtgridca.Size = new System.Drawing.Size(242, 321);
            this.dtgridca.TabIndex = 0;
            // 
            // Formql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "Formql";
            this.Text = "Formql";
            this.Load += new System.EventHandler(this.Formql_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridcanv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgrid1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgridca;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.TextBox txtbtennv;
        private System.Windows.Forms.TextBox txtbmanv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtbthemdienthoai;
        private System.Windows.Forms.TextBox txtbthemdiachi;
        private System.Windows.Forms.TextBox txtbthemluong;
        private System.Windows.Forms.TextBox txtbthemtennv;
        private System.Windows.Forms.TextBox txtbthemmanv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntimca;
        private System.Windows.Forms.TextBox txtbcaTennv;
        private System.Windows.Forms.TextBox txtbcamanv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dtgridcanv;
    }
}