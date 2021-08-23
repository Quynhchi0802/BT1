
namespace BT1
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
            this.txtNhapso = new System.Windows.Forms.TextBox();
            this.txtTongchan = new System.Windows.Forms.TextBox();
            this.txtTongpt = new System.Windows.Forms.TextBox();
            this.txtDayvn = new System.Windows.Forms.TextBox();
            this.txtTongle = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.btnTieptuc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dãy vừa nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng các phần tử trong dãy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng chẵn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng lẻ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(145, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nhập dãy số và tính tổng ";
            // 
            // txtNhapso
            // 
            this.txtNhapso.Location = new System.Drawing.Point(160, 84);
            this.txtNhapso.Name = "txtNhapso";
            this.txtNhapso.Size = new System.Drawing.Size(100, 20);
            this.txtNhapso.TabIndex = 6;
            // 
            // txtTongchan
            // 
            this.txtTongchan.Location = new System.Drawing.Point(150, 189);
            this.txtTongchan.Name = "txtTongchan";
            this.txtTongchan.Size = new System.Drawing.Size(71, 20);
            this.txtTongchan.TabIndex = 7;
            // 
            // txtTongpt
            // 
            this.txtTongpt.Location = new System.Drawing.Point(227, 148);
            this.txtTongpt.Name = "txtTongpt";
            this.txtTongpt.Size = new System.Drawing.Size(100, 20);
            this.txtTongpt.TabIndex = 8;
            // 
            // txtDayvn
            // 
            this.txtDayvn.Location = new System.Drawing.Point(177, 114);
            this.txtDayvn.Name = "txtDayvn";
            this.txtDayvn.Size = new System.Drawing.Size(100, 20);
            this.txtDayvn.TabIndex = 9;
            // 
            // txtTongle
            // 
            this.txtTongle.Location = new System.Drawing.Point(283, 189);
            this.txtTongle.Name = "txtTongle";
            this.txtTongle.Size = new System.Drawing.Size(71, 20);
            this.txtTongle.TabIndex = 10;
            this.txtTongle.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(315, 82);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 11;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // btnTieptuc
            // 
            this.btnTieptuc.Location = new System.Drawing.Point(160, 231);
            this.btnTieptuc.Name = "btnTieptuc";
            this.btnTieptuc.Size = new System.Drawing.Size(75, 23);
            this.btnTieptuc.TabIndex = 12;
            this.btnTieptuc.Text = "Tiếp tục";
            this.btnTieptuc.UseVisualStyleBackColor = true;
            this.btnTieptuc.Click += new System.EventHandler(this.btnTieptuc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(283, 231);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 398);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTieptuc);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtTongle);
            this.Controls.Add(this.txtDayvn);
            this.Controls.Add(this.txtTongpt);
            this.Controls.Add(this.txtTongchan);
            this.Controls.Add(this.txtNhapso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nhập dãy số và tính tổng";
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
        private System.Windows.Forms.TextBox txtNhapso;
        private System.Windows.Forms.TextBox txtTongchan;
        private System.Windows.Forms.TextBox txtTongpt;
        private System.Windows.Forms.TextBox txtDayvn;
        private System.Windows.Forms.TextBox txtTongle;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Button btnTieptuc;
        private System.Windows.Forms.Button btnThoat;
    }
}

