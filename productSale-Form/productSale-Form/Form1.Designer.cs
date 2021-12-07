namespace productSale_Form
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
            this.bsale = new System.Windows.Forms.Button();
            this.bstock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bsale
            // 
            this.bsale.Location = new System.Drawing.Point(104, 39);
            this.bsale.Name = "bsale";
            this.bsale.Size = new System.Drawing.Size(75, 23);
            this.bsale.TabIndex = 7;
            this.bsale.Text = "Sale Page";
            this.bsale.UseVisualStyleBackColor = true;
            this.bsale.Click += new System.EventHandler(this.bsale_Click);
            // 
            // bstock
            // 
            this.bstock.Location = new System.Drawing.Point(12, 39);
            this.bstock.Name = "bstock";
            this.bstock.Size = new System.Drawing.Size(75, 23);
            this.bstock.TabIndex = 6;
            this.bstock.Text = "Stock Page";
            this.bstock.UseVisualStyleBackColor = true;
            this.bstock.Click += new System.EventHandler(this.bstock_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Online Medical Store";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 338);
            this.Controls.Add(this.bsale);
            this.Controls.Add(this.bstock);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bsale;
        private System.Windows.Forms.Button bstock;
        private System.Windows.Forms.Label label1;
    }
}

