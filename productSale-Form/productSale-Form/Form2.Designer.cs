namespace productSale_Form
{
    partial class Form2
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.lstatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bdisplay = new System.Windows.Forms.Button();
            this.bsearch = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.bupdate = new System.Windows.Forms.Button();
            this.binsert = new System.Windows.Forms.Button();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.trate = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.tid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bhome = new System.Windows.Forms.Button();
            this.tstock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(235, 44);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(522, 154);
            this.dgv1.TabIndex = 34;
            // 
            // lstatus
            // 
            this.lstatus.AutoSize = true;
            this.lstatus.Location = new System.Drawing.Point(301, 15);
            this.lstatus.Name = "lstatus";
            this.lstatus.Size = new System.Drawing.Size(13, 13);
            this.lstatus.TabIndex = 33;
            this.lstatus.Text = "  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Status";
            // 
            // bdisplay
            // 
            this.bdisplay.Location = new System.Drawing.Point(81, 204);
            this.bdisplay.Name = "bdisplay";
            this.bdisplay.Size = new System.Drawing.Size(90, 23);
            this.bdisplay.TabIndex = 31;
            this.bdisplay.Text = "Display All Data";
            this.bdisplay.UseVisualStyleBackColor = true;
            this.bdisplay.Click += new System.EventHandler(this.bdisplay_Click);
            // 
            // bsearch
            // 
            this.bsearch.Location = new System.Drawing.Point(22, 204);
            this.bsearch.Name = "bsearch";
            this.bsearch.Size = new System.Drawing.Size(50, 23);
            this.bsearch.TabIndex = 30;
            this.bsearch.Text = "Search";
            this.bsearch.UseVisualStyleBackColor = true;
            this.bsearch.Click += new System.EventHandler(this.bsearch_Click);
            // 
            // bdelete
            // 
            this.bdelete.Location = new System.Drawing.Point(152, 175);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(50, 23);
            this.bdelete.TabIndex = 29;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // bupdate
            // 
            this.bupdate.Location = new System.Drawing.Point(81, 175);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(50, 23);
            this.bupdate.TabIndex = 28;
            this.bupdate.Text = "Update";
            this.bupdate.UseVisualStyleBackColor = true;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // binsert
            // 
            this.binsert.Location = new System.Drawing.Point(22, 175);
            this.binsert.Name = "binsert";
            this.binsert.Size = new System.Drawing.Size(50, 23);
            this.binsert.TabIndex = 27;
            this.binsert.Text = "Insert";
            this.binsert.UseVisualStyleBackColor = true;
            this.binsert.Click += new System.EventHandler(this.binsert_Click);
            // 
            // cbcat
            // 
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Items.AddRange(new object[] {
            "Allopathic",
            "Homeopathic",
            "Herbal"});
            this.cbcat.Location = new System.Drawing.Point(81, 74);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(121, 21);
            this.cbcat.TabIndex = 26;
            // 
            // trate
            // 
            this.trate.Location = new System.Drawing.Point(81, 105);
            this.trate.Name = "trate";
            this.trate.Size = new System.Drawing.Size(100, 20);
            this.trate.TabIndex = 25;
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(81, 44);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(100, 20);
            this.tname.TabIndex = 24;
            // 
            // tid
            // 
            this.tid.Location = new System.Drawing.Point(81, 12);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(100, 20);
            this.tid.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            // 
            // bhome
            // 
            this.bhome.Location = new System.Drawing.Point(22, 234);
            this.bhome.Name = "bhome";
            this.bhome.Size = new System.Drawing.Size(72, 23);
            this.bhome.TabIndex = 35;
            this.bhome.Text = "Home";
            this.bhome.UseVisualStyleBackColor = true;
            this.bhome.Click += new System.EventHandler(this.bhome_Click);
            // 
            // tstock
            // 
            this.tstock.Location = new System.Drawing.Point(81, 137);
            this.tstock.Name = "tstock";
            this.tstock.Size = new System.Drawing.Size(100, 20);
            this.tstock.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Stock";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 385);
            this.Controls.Add(this.tstock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bhome);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lstatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bdisplay);
            this.Controls.Add(this.bsearch);
            this.Controls.Add(this.bdelete);
            this.Controls.Add(this.bupdate);
            this.Controls.Add(this.binsert);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.trate);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Label lstatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bdisplay;
        private System.Windows.Forms.Button bsearch;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Button binsert;
        private System.Windows.Forms.ComboBox cbcat;
        private System.Windows.Forms.TextBox trate;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bhome;
        private System.Windows.Forms.TextBox tstock;
        private System.Windows.Forms.Label label6;
    }
}