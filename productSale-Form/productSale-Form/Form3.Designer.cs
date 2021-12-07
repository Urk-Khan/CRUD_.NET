namespace productSale_Form
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.lqty = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.trate = new System.Windows.Forms.TextBox();
            this.tfrate = new System.Windows.Forms.TextBox();
            this.bsub = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.lremaing = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Final Price";
            // 
            // lqty
            // 
            this.lqty.AutoSize = true;
            this.lqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqty.Location = new System.Drawing.Point(66, 125);
            this.lqty.Name = "lqty";
            this.lqty.Size = new System.Drawing.Size(40, 25);
            this.lqty.TabIndex = 3;
            this.lqty.Text = "    ";
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(93, 13);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(100, 20);
            this.tname.TabIndex = 4;
            // 
            // trate
            // 
            this.trate.Location = new System.Drawing.Point(93, 40);
            this.trate.Name = "trate";
            this.trate.Size = new System.Drawing.Size(100, 20);
            this.trate.TabIndex = 5;
            // 
            // tfrate
            // 
            this.tfrate.Location = new System.Drawing.Point(93, 67);
            this.tfrate.Name = "tfrate";
            this.tfrate.Size = new System.Drawing.Size(100, 20);
            this.tfrate.TabIndex = 6;
            // 
            // bsub
            // 
            this.bsub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsub.Location = new System.Drawing.Point(16, 120);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(33, 33);
            this.bsub.TabIndex = 7;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            // 
            // badd
            // 
            this.badd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badd.Location = new System.Drawing.Point(124, 120);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(33, 33);
            this.badd.TabIndex = 8;
            this.badd.Text = "+";
            this.badd.UseVisualStyleBackColor = true;
            // 
            // lremaing
            // 
            this.lremaing.AutoSize = true;
            this.lremaing.Location = new System.Drawing.Point(121, 174);
            this.lremaing.Name = "lremaing";
            this.lremaing.Size = new System.Drawing.Size(19, 13);
            this.lremaing.TabIndex = 9;
            this.lremaing.Text = "    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Remain Items";
            // 
            // bhome
            // 
            this.bhome.Location = new System.Drawing.Point(19, 214);
            this.bhome.Name = "bhome";
            this.bhome.Size = new System.Drawing.Size(72, 23);
            this.bhome.TabIndex = 36;
            this.bhome.Text = "Home";
            this.bhome.UseVisualStyleBackColor = true;
            this.bhome.Click += new System.EventHandler(this.bhome_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 372);
            this.Controls.Add(this.bhome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lremaing);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.tfrate);
            this.Controls.Add(this.trate);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.lqty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lqty;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox trate;
        private System.Windows.Forms.TextBox tfrate;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Label lremaing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bhome;
    }
}