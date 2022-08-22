
namespace RyanLateFeeCalculator
{
    partial class frmLibrary
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
            this.txCurrent = new System.Windows.Forms.TextBox();
            this.main_btn = new System.Windows.Forms.Button();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.Due_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.LateFee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.movie_cal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txCurrent
            // 
            this.txCurrent.Location = new System.Drawing.Point(370, 62);
            this.txCurrent.Name = "txCurrent";
            this.txCurrent.Size = new System.Drawing.Size(100, 20);
            this.txCurrent.TabIndex = 0;
            this.txCurrent.TextChanged += new System.EventHandler(this.txCurrent_TextChanged);
            // 
            // main_btn
            // 
            this.main_btn.Location = new System.Drawing.Point(712, 340);
            this.main_btn.Name = "main_btn";
            this.main_btn.Size = new System.Drawing.Size(75, 23);
            this.main_btn.TabIndex = 1;
            this.main_btn.Text = "Close";
            this.main_btn.UseVisualStyleBackColor = true;
            this.main_btn.Click += new System.EventHandler(this.main_btn_Click_1);
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(370, 111);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(100, 20);
            this.txtDue.TabIndex = 3;
            this.txtDue.TextChanged += new System.EventHandler(this.txtDue_TextChanged);
            // 
            // Due_lbl
            // 
            this.Due_lbl.AutoSize = true;
            this.Due_lbl.Location = new System.Drawing.Point(182, 118);
            this.Due_lbl.Name = "Due_lbl";
            this.Due_lbl.Size = new System.Drawing.Size(53, 13);
            this.Due_lbl.TabIndex = 7;
            this.Due_lbl.Text = "Due Date";
            this.Due_lbl.Click += new System.EventHandler(this.Due_lbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Current Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(370, 245);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(100, 20);
            this.txtFee.TabIndex = 14;
            this.txtFee.TextChanged += new System.EventHandler(this.txtFee_TextChanged);
            // 
            // LateFee
            // 
            this.LateFee.AutoSize = true;
            this.LateFee.Location = new System.Drawing.Point(226, 252);
            this.LateFee.Name = "LateFee";
            this.LateFee.Size = new System.Drawing.Size(49, 13);
            this.LateFee.TabIndex = 13;
            this.LateFee.Text = "Late Fee";
            this.LateFee.Click += new System.EventHandler(this.LateFee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Late Days";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(370, 206);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 11;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // movie_cal
            // 
            this.movie_cal.Location = new System.Drawing.Point(370, 157);
            this.movie_cal.Name = "movie_cal";
            this.movie_cal.Size = new System.Drawing.Size(100, 23);
            this.movie_cal.TabIndex = 10;
            this.movie_cal.Text = "Calculate";
            this.movie_cal.UseVisualStyleBackColor = true;
            this.movie_cal.Click += new System.EventHandler(this.movie_cal_Click);
            // 
            // frmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.LateFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.movie_cal);
            this.Controls.Add(this.Due_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.main_btn);
            this.Controls.Add(this.txCurrent);
            this.Name = "frmLibrary";
            this.Text = "LibraryMovie";
            this.Load += new System.EventHandler(this.frmLibrary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txCurrent;
        private System.Windows.Forms.Button main_btn;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Label Due_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label LateFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button movie_cal;
    }
}