namespace WindowsFormsApp6
{
    partial class Form4
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
            this.btnCont = new System.Windows.Forms.Button();
            this.btnCan = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnbal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.Color.White;
            this.btnCont.Location = new System.Drawing.Point(197, 76);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(75, 23);
            this.btnCont.TabIndex = 8;
            this.btnCont.Text = "Continue";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnCan
            // 
            this.btnCan.BackColor = System.Drawing.Color.White;
            this.btnCan.Location = new System.Drawing.Point(84, 76);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(75, 23);
            this.btnCan.TabIndex = 7;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = false;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnbal
            // 
            this.btnbal.BackColor = System.Drawing.Color.White;
            this.btnbal.Location = new System.Drawing.Point(12, 36);
            this.btnbal.Name = "btnbal";
            this.btnbal.Size = new System.Drawing.Size(75, 23);
            this.btnbal.TabIndex = 5;
            this.btnbal.Text = "Balance";
            this.btnbal.UseVisualStyleBackColor = false;
            this.btnbal.Click += new System.EventHandler(this.btnbal_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnbal);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnbal;
    }
}