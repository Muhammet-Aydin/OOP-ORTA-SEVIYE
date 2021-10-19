
namespace OOP_8POLİFORMIZM
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
            this.btnphone1 = new System.Windows.Forms.Button();
            this.btnphone2 = new System.Windows.Forms.Button();
            this.btnphone3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnphone1
            // 
            this.btnphone1.Location = new System.Drawing.Point(206, 27);
            this.btnphone1.Name = "btnphone1";
            this.btnphone1.Size = new System.Drawing.Size(254, 106);
            this.btnphone1.TabIndex = 0;
            this.btnphone1.Text = "Nokıa";
            this.btnphone1.UseVisualStyleBackColor = true;
            this.btnphone1.Click += new System.EventHandler(this.btnphone1_Click);
            // 
            // btnphone2
            // 
            this.btnphone2.Location = new System.Drawing.Point(206, 155);
            this.btnphone2.Name = "btnphone2";
            this.btnphone2.Size = new System.Drawing.Size(254, 91);
            this.btnphone2.TabIndex = 1;
            this.btnphone2.Text = "Samsung";
            this.btnphone2.UseVisualStyleBackColor = true;
            this.btnphone2.Click += new System.EventHandler(this.btnphone2_Click);
            // 
            // btnphone3
            // 
            this.btnphone3.Location = new System.Drawing.Point(206, 274);
            this.btnphone3.Name = "btnphone3";
            this.btnphone3.Size = new System.Drawing.Size(254, 112);
            this.btnphone3.TabIndex = 2;
            this.btnphone3.Text = "Iphone";
            this.btnphone3.UseVisualStyleBackColor = true;
            this.btnphone3.Click += new System.EventHandler(this.btnphone3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnphone3);
            this.Controls.Add(this.btnphone2);
            this.Controls.Add(this.btnphone1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnphone1;
        private System.Windows.Forms.Button btnphone2;
        private System.Windows.Forms.Button btnphone3;
    }
}

