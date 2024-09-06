namespace hatvanyozas
{
    partial class form
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
            this.btszamol = new System.Windows.Forms.Button();
            this.btexit = new System.Windows.Forms.Button();
            this.lbhatvany = new System.Windows.Forms.Label();
            this.lbkitev = new System.Windows.Forms.Label();
            this.txalap = new System.Windows.Forms.TextBox();
            this.txkitev = new System.Windows.Forms.TextBox();
            this.lberedmeny = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btszamol
            // 
            this.btszamol.Location = new System.Drawing.Point(375, 15);
            this.btszamol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btszamol.Name = "btszamol";
            this.btszamol.Size = new System.Drawing.Size(115, 69);
            this.btszamol.TabIndex = 0;
            this.btszamol.Text = "Számol";
            this.btszamol.UseVisualStyleBackColor = true;
            this.btszamol.Click += new System.EventHandler(this.btszamol_Click);
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(375, 115);
            this.btexit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(115, 69);
            this.btexit.TabIndex = 1;
            this.btexit.Text = "Kilépés";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // lbhatvany
            // 
            this.lbhatvany.AutoSize = true;
            this.lbhatvany.Location = new System.Drawing.Point(59, 40);
            this.lbhatvany.Name = "lbhatvany";
            this.lbhatvany.Size = new System.Drawing.Size(86, 13);
            this.lbhatvany.TabIndex = 2;
            this.lbhatvany.Text = "Hatványalap: ";
            // 
            // lbkitev
            // 
            this.lbkitev.AutoSize = true;
            this.lbkitev.Location = new System.Drawing.Point(62, 97);
            this.lbkitev.Name = "lbkitev";
            this.lbkitev.Size = new System.Drawing.Size(101, 13);
            this.lbkitev.TabIndex = 3;
            this.lbkitev.Text = "Hatvány kitevő: ";
            // 
            // txalap
            // 
            this.txalap.Location = new System.Drawing.Point(177, 40);
            this.txalap.Name = "txalap";
            this.txalap.Size = new System.Drawing.Size(61, 20);
            this.txalap.TabIndex = 4;
            // 
            // txkitev
            // 
            this.txkitev.Location = new System.Drawing.Point(177, 94);
            this.txkitev.Name = "txkitev";
            this.txkitev.Size = new System.Drawing.Size(61, 20);
            this.txkitev.TabIndex = 5;
            // 
            // lberedmeny
            // 
            this.lberedmeny.AutoSize = true;
            this.lberedmeny.ForeColor = System.Drawing.Color.Red;
            this.lberedmeny.Location = new System.Drawing.Point(65, 147);
            this.lberedmeny.Name = "lberedmeny";
            this.lberedmeny.Size = new System.Drawing.Size(41, 13);
            this.lberedmeny.TabIndex = 6;
            this.lberedmeny.Text = "label1";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(516, 237);
            this.Controls.Add(this.lberedmeny);
            this.Controls.Add(this.txkitev);
            this.Controls.Add(this.txalap);
            this.Controls.Add(this.lbkitev);
            this.Controls.Add(this.lbhatvany);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.btszamol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hatvanyozás";
            this.Shown += new System.EventHandler(this.form_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btszamol;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Label lbhatvany;
        private System.Windows.Forms.Label lbkitev;
        private System.Windows.Forms.TextBox txalap;
        private System.Windows.Forms.TextBox txkitev;
        private System.Windows.Forms.Label lberedmeny;
    }
}

