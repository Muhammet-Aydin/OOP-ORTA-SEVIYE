
namespace OOP_18SpecialCollectıons
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnhashtable = new System.Windows.Forms.Button();
            this.btnlistdictianory = new System.Windows.Forms.Button();
            this.btnHybrd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(312, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(310, 238);
            this.listBox1.TabIndex = 0;
            // 
            // btnhashtable
            // 
            this.btnhashtable.Location = new System.Drawing.Point(383, 292);
            this.btnhashtable.Name = "btnhashtable";
            this.btnhashtable.Size = new System.Drawing.Size(120, 27);
            this.btnhashtable.TabIndex = 1;
            this.btnhashtable.Text = "hashtable";
            this.btnhashtable.UseVisualStyleBackColor = true;
            this.btnhashtable.Click += new System.EventHandler(this.btnhashtable_Click);
            // 
            // btnlistdictianory
            // 
            this.btnlistdictianory.Location = new System.Drawing.Point(383, 343);
            this.btnlistdictianory.Name = "btnlistdictianory";
            this.btnlistdictianory.Size = new System.Drawing.Size(120, 27);
            this.btnlistdictianory.TabIndex = 2;
            this.btnlistdictianory.Text = "ListDictianary";
            this.btnlistdictianory.UseVisualStyleBackColor = true;
            this.btnlistdictianory.Click += new System.EventHandler(this.btnlistdictianory_Click);
            // 
            // btnHybrd
            // 
            this.btnHybrd.Location = new System.Drawing.Point(383, 393);
            this.btnHybrd.Name = "btnHybrd";
            this.btnHybrd.Size = new System.Drawing.Size(120, 27);
            this.btnHybrd.TabIndex = 3;
            this.btnHybrd.Text = "Hybrd";
            this.btnHybrd.UseVisualStyleBackColor = true;
            this.btnHybrd.Click += new System.EventHandler(this.btnHybrd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHybrd);
            this.Controls.Add(this.btnlistdictianory);
            this.Controls.Add(this.btnhashtable);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnhashtable;
        private System.Windows.Forms.Button btnlistdictianory;
        private System.Windows.Forms.Button btnHybrd;
    }
}

