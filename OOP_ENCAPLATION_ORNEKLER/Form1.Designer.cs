
namespace OOP_ENCAPLATION_ORNEKLER
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ÜrünId = new System.Windows.Forms.TextBox();
            this.txt_ÜrünAcıklama = new System.Windows.Forms.TextBox();
            this.txt_ÜrünFiyat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Acıklama:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Fiyat:";
            // 
            // txt_ÜrünId
            // 
            this.txt_ÜrünId.Location = new System.Drawing.Point(121, 11);
            this.txt_ÜrünId.Name = "txt_ÜrünId";
            this.txt_ÜrünId.Size = new System.Drawing.Size(131, 23);
            this.txt_ÜrünId.TabIndex = 3;
            // 
            // txt_ÜrünAcıklama
            // 
            this.txt_ÜrünAcıklama.Location = new System.Drawing.Point(121, 96);
            this.txt_ÜrünAcıklama.Name = "txt_ÜrünAcıklama";
            this.txt_ÜrünAcıklama.Size = new System.Drawing.Size(131, 23);
            this.txt_ÜrünAcıklama.TabIndex = 4;
            // 
            // txt_ÜrünFiyat
            // 
            this.txt_ÜrünFiyat.Location = new System.Drawing.Point(121, 220);
            this.txt_ÜrünFiyat.Name = "txt_ÜrünFiyat";
            this.txt_ÜrünFiyat.Size = new System.Drawing.Size(131, 23);
            this.txt_ÜrünFiyat.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ürün Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 356);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(315, 59);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 422);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_ÜrünFiyat);
            this.Controls.Add(this.txt_ÜrünAcıklama);
            this.Controls.Add(this.txt_ÜrünId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ÜrünId;
        private System.Windows.Forms.TextBox txt_ÜrünAcıklama;
        private System.Windows.Forms.TextBox txt_ÜrünFiyat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

