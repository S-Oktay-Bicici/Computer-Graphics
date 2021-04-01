
namespace BilgisayarGrafikleri
{
    partial class AnaMenu
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
            this.btnTemel = new System.Windows.Forms.Button();
            this.btnUzay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(218, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SADIK OKTAY BİÇİCİ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(298, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "1180505018";
            // 
            // btnTemel
            // 
            this.btnTemel.BackColor = System.Drawing.Color.DarkGreen;
            this.btnTemel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemel.ForeColor = System.Drawing.Color.Black;
            this.btnTemel.Location = new System.Drawing.Point(93, 197);
            this.btnTemel.Name = "btnTemel";
            this.btnTemel.Size = new System.Drawing.Size(200, 150);
            this.btnTemel.TabIndex = 2;
            this.btnTemel.Text = "3D TEMEL İŞLEMLER";
            this.btnTemel.UseVisualStyleBackColor = false;
            this.btnTemel.Click += new System.EventHandler(this.btnTemel_Click);
            // 
            // btnUzay
            // 
            this.btnUzay.BackColor = System.Drawing.Color.DarkGreen;
            this.btnUzay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUzay.ForeColor = System.Drawing.Color.Black;
            this.btnUzay.Location = new System.Drawing.Point(474, 197);
            this.btnUzay.Name = "btnUzay";
            this.btnUzay.Size = new System.Drawing.Size(200, 150);
            this.btnUzay.TabIndex = 3;
            this.btnUzay.Text = "3D UZAY YÜZEYLERİ";
            this.btnUzay.UseVisualStyleBackColor = false;
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUzay);
            this.Controls.Add(this.btnTemel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaMenu";
            this.Text = "ANA MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemel;
        private System.Windows.Forms.Button btnUzay;
    }
}

