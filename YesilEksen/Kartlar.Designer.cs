namespace YesilEksen
{
    partial class Kartlar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblbaslik = new System.Windows.Forms.Label();
            this.lblsektor = new System.Windows.Forms.Label();
            this.lblsehir = new System.Windows.Forms.Label();
            this.lbldurum = new System.Windows.Forms.Label();
            this.btndetay = new System.Windows.Forms.Button();
            this.piclogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbaslik
            // 
            this.lblbaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbaslik.Location = new System.Drawing.Point(5, 89);
            this.lblbaslik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbaslik.Name = "lblbaslik";
            this.lblbaslik.Size = new System.Drawing.Size(253, 37);
            this.lblbaslik.TabIndex = 1;
            this.lblbaslik.Text = "Firma :";
            // 
            // lblsektor
            // 
            this.lblsektor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsektor.Location = new System.Drawing.Point(5, 128);
            this.lblsektor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsektor.Name = "lblsektor";
            this.lblsektor.Size = new System.Drawing.Size(253, 37);
            this.lblsektor.TabIndex = 2;
            this.lblsektor.Text = "Sektör :";
            // 
            // lblsehir
            // 
            this.lblsehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsehir.Location = new System.Drawing.Point(5, 169);
            this.lblsehir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsehir.Name = "lblsehir";
            this.lblsehir.Size = new System.Drawing.Size(253, 49);
            this.lblsehir.TabIndex = 3;
            this.lblsehir.Text = "Şehir :";
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldurum.Location = new System.Drawing.Point(33, 228);
            this.lbldurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(74, 17);
            this.lbldurum.TabIndex = 4;
            this.lbldurum.Text = "Durumu :";
            this.lbldurum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndetay
            // 
            this.btndetay.Location = new System.Drawing.Point(71, 252);
            this.btndetay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndetay.Name = "btndetay";
            this.btndetay.Size = new System.Drawing.Size(115, 36);
            this.btndetay.TabIndex = 5;
            this.btndetay.Text = "Detay";
            this.btndetay.UseVisualStyleBackColor = true;
            this.btndetay.Click += new System.EventHandler(this.btndetay_Click);
            // 
            // piclogo
            // 
            this.piclogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.piclogo.Location = new System.Drawing.Point(0, 0);
            this.piclogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(264, 70);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piclogo.TabIndex = 0;
            this.piclogo.TabStop = false;
            this.piclogo.Click += new System.EventHandler(this.piclogo_Click);
            // 
            // Kartlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btndetay);
            this.Controls.Add(this.lbldurum);
            this.Controls.Add(this.lblsehir);
            this.Controls.Add(this.lblsektor);
            this.Controls.Add(this.lblbaslik);
            this.Controls.Add(this.piclogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Kartlar";
            this.Size = new System.Drawing.Size(264, 320);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.Label lblbaslik;
        private System.Windows.Forms.Label lblsektor;
        private System.Windows.Forms.Label lblsehir;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.Button btndetay;
    }
}
