
namespace MarketYönetimSistemi
{
    partial class AnaForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.KullanıcıBtn = new System.Windows.Forms.Button();
            this.YoneticiBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(519, 352);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MarketYönetimSistemi.Properties.Resources.anagiris;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(793, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoş Geldiniz";
            // 
            // KullanıcıBtn
            // 
            this.KullanıcıBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.KullanıcıBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KullanıcıBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullanıcıBtn.ForeColor = System.Drawing.Color.White;
            this.KullanıcıBtn.Location = new System.Drawing.Point(825, 214);
            this.KullanıcıBtn.Name = "KullanıcıBtn";
            this.KullanıcıBtn.Size = new System.Drawing.Size(255, 110);
            this.KullanıcıBtn.TabIndex = 3;
            this.KullanıcıBtn.Text = "Kullanıcı Girişi";
            this.KullanıcıBtn.UseVisualStyleBackColor = false;
            // 
            // YoneticiBtn
            // 
            this.YoneticiBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.YoneticiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.YoneticiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YoneticiBtn.ForeColor = System.Drawing.Color.White;
            this.YoneticiBtn.Location = new System.Drawing.Point(825, 378);
            this.YoneticiBtn.Name = "YoneticiBtn";
            this.YoneticiBtn.Size = new System.Drawing.Size(255, 110);
            this.YoneticiBtn.TabIndex = 5;
            this.YoneticiBtn.Text = "Yönetici Girişi";
            this.YoneticiBtn.UseVisualStyleBackColor = false;
            this.YoneticiBtn.Click += new System.EventHandler(this.YoneticiBtn_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 599);
            this.Controls.Add(this.YoneticiBtn);
            this.Controls.Add(this.KullanıcıBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button KullanıcıBtn;
        private System.Windows.Forms.Button YoneticiBtn;
    }
}