namespace RyanLateFeeCalculator
{
    partial class frmNew
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
            this.txtCurrent = new System.Windows.Forms.TextBox();
            this.main_btn = new System.Windows.Forms.Button();
            this.cal_btn = new System.Windows.Forms.Button();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.Due_lbl = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LateFee = new System.Windows.Forms.Label();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Date";
            // 
            // txtCurrent
            // 
            this.txtCurrent.Location = new System.Drawing.Point(335, 108);
            this.txtCurrent.Name = "txtCurrent";
            this.txtCurrent.Size = new System.Drawing.Size(100, 20);
            this.txtCurrent.TabIndex = 1;
            this.txtCurrent.TextChanged += new System.EventHandler(this.txtCurrent_TextChanged);
            // 
            // main_btn
            // 
            this.main_btn.Location = new System.Drawing.Point(691, 368);
            this.main_btn.Name = "main_btn";
            this.main_btn.Size = new System.Drawing.Size(75, 23);
            this.main_btn.TabIndex = 2;
            this.main_btn.Text = "Close";
            this.main_btn.UseVisualStyleBackColor = true;
            this.main_btn.Click += new System.EventHandler(this.main_btn_Click);
            // 
            // cal_btn
            // 
            this.cal_btn.Location = new System.Drawing.Point(335, 219);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(100, 23);
            this.cal_btn.TabIndex = 3;
            this.cal_btn.Text = "Calculate";
            this.cal_btn.UseVisualStyleBackColor = true;
            this.cal_btn.Click += new System.EventHandler(this.cal_btn_Click);
            // 
            // txtDue
            // 
            this.txtDue.Location = new System.Drawing.Point(335, 153);
            this.txtDue.Name = "txtDue";
            this.txtDue.Size = new System.Drawing.Size(100, 20);
            this.txtDue.TabIndex = 4;
            this.txtDue.TextChanged += new System.EventHandler(this.txtDue_TextChanged);
            // 
            // Due_lbl
            // 
            this.Due_lbl.AutoSize = true;
            this.Due_lbl.Location = new System.Drawing.Point(191, 160);
            this.Due_lbl.Name = "Due_lbl";
            this.Due_lbl.Size = new System.Drawing.Size(53, 13);
            this.Due_lbl.TabIndex = 5;
            this.Due_lbl.Text = "Due Date";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(335, 268);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 6;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Late Days";
            // 
            // LateFee
            // 
            this.LateFee.AutoSize = true;
            this.LateFee.Location = new System.Drawing.Point(191, 314);
            this.LateFee.Name = "LateFee";
            this.LateFee.Size = new System.Drawing.Size(49, 13);
            this.LateFee.TabIndex = 8;
            this.LateFee.Text = "Late Fee";
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(335, 307);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(100, 20);
            this.txtFee.TabIndex = 9;
            this.txtFee.TextChanged += new System.EventHandler(this.txtFee_TextChanged);
            // 
            // frmNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.LateFee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.Due_lbl);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.cal_btn);
            this.Controls.Add(this.main_btn);
            this.Controls.Add(this.txtCurrent);
            this.Controls.Add(this.label1);
            this.Name = "frmNew";
            this.Text = "NewRelease";
            this.Load += new System.EventHandler(this.frmNew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrent;
        private System.Windows.Forms.Button main_btn;
        private System.Windows.Forms.Button cal_btn;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.Label Due_lbl;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LateFee;
        private System.Windows.Forms.TextBox txtFee;
    }
}