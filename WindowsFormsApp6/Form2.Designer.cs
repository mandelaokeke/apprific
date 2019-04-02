namespace WindowsFormsApp6
{
    partial class Form2
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
            this.lbAccNum = new System.Windows.Forms.Label();
            this.lbPin = new System.Windows.Forms.Label();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtAccNo = new System.Windows.Forms.TextBox();
            this.btnEter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAccNum
            // 
            this.lbAccNum.AutoSize = true;
            this.lbAccNum.Location = new System.Drawing.Point(52, 33);
            this.lbAccNum.Name = "lbAccNum";
            this.lbAccNum.Size = new System.Drawing.Size(72, 13);
            this.lbAccNum.TabIndex = 1;
            this.lbAccNum.Text = "Account Num";
            // 
            // lbPin
            // 
            this.lbPin.AutoSize = true;
            this.lbPin.Location = new System.Drawing.Point(52, 71);
            this.lbPin.Name = "lbPin";
            this.lbPin.Size = new System.Drawing.Size(22, 13);
            this.lbPin.TabIndex = 2;
            this.lbPin.Text = "Pin";
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(158, 71);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 20);
            this.txtPin.TabIndex = 3;
            this.txtPin.TextChanged += new System.EventHandler(this.txtPin_TextChanged);
            this.txtPin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPin_KeyPress);
            // 
            // txtAccNo
            // 
            this.txtAccNo.Location = new System.Drawing.Point(158, 30);
            this.txtAccNo.Name = "txtAccNo";
            this.txtAccNo.Size = new System.Drawing.Size(100, 20);
            this.txtAccNo.TabIndex = 4;
            this.txtAccNo.TextChanged += new System.EventHandler(this.txtAccNo_TextChanged);
            // 
            // btnEter
            // 
            this.btnEter.BackColor = System.Drawing.Color.White;
            this.btnEter.Location = new System.Drawing.Point(171, 103);
            this.btnEter.Name = "btnEter";
            this.btnEter.Size = new System.Drawing.Size(75, 23);
            this.btnEter.TabIndex = 5;
            this.btnEter.Text = "Enter";
            this.btnEter.UseVisualStyleBackColor = false;
            this.btnEter.Click += new System.EventHandler(this.btnEter_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(64, 103);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(335, 138);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEter);
            this.Controls.Add(this.txtAccNo);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.lbPin);
            this.Controls.Add(this.lbAccNum);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAccNum;
        private System.Windows.Forms.Label lbPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtAccNo;
        private System.Windows.Forms.Button btnEter;
        private System.Windows.Forms.Button btnCancel;
    }
}