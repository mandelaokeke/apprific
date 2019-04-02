namespace WindowsFormsApp6
{
    partial class Form7
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
            this.btnDepo = new System.Windows.Forms.Button();
            this.txtdeposit = new System.Windows.Forms.TextBox();
            this.btnCan = new System.Windows.Forms.Button();
            this.btnCont = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDepo
            // 
            this.btnDepo.BackColor = System.Drawing.Color.White;
            this.btnDepo.Location = new System.Drawing.Point(12, 32);
            this.btnDepo.Name = "btnDepo";
            this.btnDepo.Size = new System.Drawing.Size(75, 23);
            this.btnDepo.TabIndex = 0;
            this.btnDepo.Text = "Deposit";
            this.btnDepo.UseVisualStyleBackColor = false;
            this.btnDepo.Click += new System.EventHandler(this.btnDepo_Click);
            // 
            // txtdeposit
            // 
            this.txtdeposit.Location = new System.Drawing.Point(130, 34);
            this.txtdeposit.Name = "txtdeposit";
            this.txtdeposit.Size = new System.Drawing.Size(100, 20);
            this.txtdeposit.TabIndex = 1;
            this.txtdeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnCan
            // 
            this.btnCan.BackColor = System.Drawing.Color.White;
            this.btnCan.Location = new System.Drawing.Point(58, 87);
            this.btnCan.Name = "btnCan";
            this.btnCan.Size = new System.Drawing.Size(75, 23);
            this.btnCan.TabIndex = 2;
            this.btnCan.Text = "Cancel";
            this.btnCan.UseVisualStyleBackColor = false;
            this.btnCan.Click += new System.EventHandler(this.btnCan_Click);
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.Color.White;
            this.btnCont.Location = new System.Drawing.Point(166, 87);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(75, 23);
            this.btnCont.TabIndex = 3;
            this.btnCont.Text = "Continue";
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(284, 133);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.btnCan);
            this.Controls.Add(this.txtdeposit);
            this.Controls.Add(this.btnDepo);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDepo;
        private System.Windows.Forms.TextBox txtdeposit;
        private System.Windows.Forms.Button btnCan;
        private System.Windows.Forms.Button btnCont;
    }
}