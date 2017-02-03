namespace bankomat
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
            this.btnSprawdzStan1 = new System.Windows.Forms.Button();
            this.btnWyplac1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnWyloguj1 = new System.Windows.Forms.Button();
            this.btnPrzelew1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSprawdzStan1
            // 
            this.btnSprawdzStan1.Location = new System.Drawing.Point(54, 49);
            this.btnSprawdzStan1.Name = "btnSprawdzStan1";
            this.btnSprawdzStan1.Size = new System.Drawing.Size(181, 52);
            this.btnSprawdzStan1.TabIndex = 0;
            this.btnSprawdzStan1.Text = "Sprawdzenie stanu konta";
            this.btnSprawdzStan1.UseVisualStyleBackColor = true;
            this.btnSprawdzStan1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnWyplac1
            // 
            this.btnWyplac1.Location = new System.Drawing.Point(54, 118);
            this.btnWyplac1.Name = "btnWyplac1";
            this.btnWyplac1.Size = new System.Drawing.Size(181, 52);
            this.btnWyplac1.TabIndex = 1;
            this.btnWyplac1.Text = "Wypłata gotówki";
            this.btnWyplac1.UseVisualStyleBackColor = true;
            this.btnWyplac1.Click += new System.EventHandler(this.btnWyplac1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(555, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Zamknij";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnWyloguj1
            // 
            this.btnWyloguj1.Location = new System.Drawing.Point(555, 118);
            this.btnWyloguj1.Name = "btnWyloguj1";
            this.btnWyloguj1.Size = new System.Drawing.Size(181, 52);
            this.btnWyloguj1.TabIndex = 3;
            this.btnWyloguj1.Text = "Wyloguj";
            this.btnWyloguj1.UseVisualStyleBackColor = true;
            this.btnWyloguj1.Click += new System.EventHandler(this.btnWyloguj1_Click);
            // 
            // btnPrzelew1
            // 
            this.btnPrzelew1.Location = new System.Drawing.Point(54, 187);
            this.btnPrzelew1.Name = "btnPrzelew1";
            this.btnPrzelew1.Size = new System.Drawing.Size(181, 52);
            this.btnPrzelew1.TabIndex = 4;
            this.btnPrzelew1.Text = "Przelew na konto";
            this.btnPrzelew1.UseVisualStyleBackColor = true;
            this.btnPrzelew1.Click += new System.EventHandler(this.btnPrzelew1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 270);
            this.Controls.Add(this.btnPrzelew1);
            this.Controls.Add(this.btnWyloguj1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnWyplac1);
            this.Controls.Add(this.btnSprawdzStan1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSprawdzStan1;
        private System.Windows.Forms.Button btnWyplac1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnWyloguj1;
        private System.Windows.Forms.Button btnPrzelew1;
    }
}

