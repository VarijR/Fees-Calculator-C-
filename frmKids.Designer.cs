
namespace RyanLateFeeCalculator
{
    partial class frmKids
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
            this.txtFee = new System.Windows.Forms.TextBox();
            this.LateFee = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.kids_cal = new System.Windows.Forms.Button();
            this.Due_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.main_btn = new System.Windows.Forms.Button();
            this.txCurrent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(286, 258);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(100, 20);
            this.txtFee.TabIndex = 24;
            this.txtFee.TextChanged += new System.EventHandler(this.txtFee_TextChanged);
            // 
            // LateFee
            // 
            this.LateFee.AutoSize = true;
            this.LateFee.Location = new System.Drawing.Point(142, 265);
            this.LateFee.Name = "LateFee";
            this.LateFee.Size = new System.Drawing.Size(49, 13);
            this.LateFee.TabIndex = 23;
            this.LateFee.Text = "Late Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Late Days";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(286, 219);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 21;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // kids_cal
            // 
            this.kids_cal.Location = new System.Drawing.Point(286, 170);
            this.kids_cal.Name = "kids_cal";
            this.kids_cal.Size = new System.Drawing.Size(100, 23);
            this.kids_cal.TabIndex = 20;
            this.kids_cal.Text = "Calculate";
            this.kids_cal.UseVisualStyleBackColor = true;
            this.kids_cal.Click += new System.EventHandler(this.movie_cal_Click);
            // 
            // Due_lbl
            // 
            this.Due_lbl.AutoSize = true;
            this.Due_lbl.Location = new System.Drawing.Point(98, 131);
            this.Due_lbl.Name = "Due_lbl";
            this.Due_lbl.Size = new System.Drawing.Size(53, 13);
            this.Due_lbl.TabIndex = 19;
            this.Due_lbl.Text = "Due Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Current Date";
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(286, 124);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(100, 20);
            this.txtDue.TabIndex = 17;
            this.txtDue.TextChanged += new System.EventHandler(this.txtDue_TextChanged);
            // 
            // main_btn
            // 
            this.main_btn.Location = new System.Drawing.Point(628, 353);
            this.main_btn.Name = "main_btn";
            this.main_btn.Size = new System.Drawing.Size(75, 23);
            this.main_btn.TabIndex = 16;
            this.main_btn.Text = "Close";
            this.main_btn.UseVisualStyleBackColor = true;
            this.main_btn.Click += new System.EventHandler(this.main_btn_Click);
            // 
            // txCurrent
            // 
            this.txCurrent.Location = new System.Drawing.Point(286, 75);
            this.txCurrent.Name = "txCurrent";
            this.txCurrent.Size = new System.Drawing.Size(100, 20);
            this.txCurrent.TabIndex = 15;
            this.txCurrent.TextChanged += new System.EventHandler(this.txCurrent_TextChanged);
            // 
            // frmKids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.LateFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.kids_cal);
            this.Controls.Add(this.Due_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.main_btn);
            this.Controls.Add(this.txCurrent);
            this.Name = "frmKids";
            this.Text = "frmKids";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label LateFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button kids_cal;
        private System.Windows.Forms.Label Due_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Button main_btn;
        private System.Windows.Forms.TextBox txCurrent;
    }
}