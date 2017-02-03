namespace bankomat
{
    partial class Przelew
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbKonto4 = new System.Windows.Forms.TextBox();
            this.txbAdresat4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txbKwotaPrzelewu4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Anuluj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nr konta";
            // 
            // txbKonto4
            // 
            this.txbKonto4.Location = new System.Drawing.Point(117, 24);
            this.txbKonto4.Name = "txbKonto4";
            this.txbKonto4.Size = new System.Drawing.Size(100, 20);
            this.txbKonto4.TabIndex = 2;
            this.txbKonto4.TextChanged += new System.EventHandler(this.sprawdzAdresata);
            // 
            // txbAdresat4
            // 
            this.txbAdresat4.Location = new System.Drawing.Point(117, 50);
            this.txbAdresat4.Name = "txbAdresat4";
            this.txbAdresat4.Size = new System.Drawing.Size(100, 20);
            this.txbAdresat4.TabIndex = 3;
            this.txbAdresat4.TextChanged += new System.EventHandler(this.sprawdzAdresata);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 65);
            this.button2.TabIndex = 4;
            this.button2.Text = "Wykonaj przelew";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbKwotaPrzelewu4
            // 
            this.txbKwotaPrzelewu4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txbKwotaPrzelewu4.Location = new System.Drawing.Point(117, 76);
            this.txbKwotaPrzelewu4.Name = "txbKwotaPrzelewu4";
            this.txbKwotaPrzelewu4.Size = new System.Drawing.Size(100, 32);
            this.txbKwotaPrzelewu4.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kwota przelewu";
            // 
            // Przelew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 254);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbKwotaPrzelewu4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txbAdresat4);
            this.Controls.Add(this.txbKonto4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Przelew";
            this.Text = "Przelew";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbKonto4;
        private System.Windows.Forms.TextBox txbAdresat4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbKwotaPrzelewu4;
        private System.Windows.Forms.Label label2;
    }
}