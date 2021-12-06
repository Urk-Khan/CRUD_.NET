namespace webForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.binsert = new System.Windows.Forms.Button();
            this.bupdate = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.bsearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstatus = new System.Windows.Forms.Label();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.ldall = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.tstock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // tid
            // 
            this.tid.Location = new System.Drawing.Point(99, 13);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(100, 20);
            this.tid.TabIndex = 3;
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(99, 41);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(100, 20);
            this.tname.TabIndex = 4;
            // 
            // binsert
            // 
            this.binsert.Location = new System.Drawing.Point(16, 208);
            this.binsert.Name = "binsert";
            this.binsert.Size = new System.Drawing.Size(75, 23);
            this.binsert.TabIndex = 6;
            this.binsert.Text = "Insert";
            this.binsert.UseVisualStyleBackColor = true;
            this.binsert.Click += new System.EventHandler(this.binsert_Click);
            // 
            // bupdate
            // 
            this.bupdate.Location = new System.Drawing.Point(97, 207);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(75, 23);
            this.bupdate.TabIndex = 7;
            this.bupdate.Text = "Update";
            this.bupdate.UseVisualStyleBackColor = true;
            this.bupdate.Click += new System.EventHandler(this.bupdate_Click);
            // 
            // bdelete
            // 
            this.bdelete.Location = new System.Drawing.Point(178, 208);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(75, 23);
            this.bdelete.TabIndex = 8;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = true;
            this.bdelete.Click += new System.EventHandler(this.bdelete_Click);
            // 
            // bsearch
            // 
            this.bsearch.Location = new System.Drawing.Point(16, 249);
            this.bsearch.Name = "bsearch";
            this.bsearch.Size = new System.Drawing.Size(75, 23);
            this.bsearch.TabIndex = 10;
            this.bsearch.Text = "Search";
            this.bsearch.UseVisualStyleBackColor = true;
            this.bsearch.Click += new System.EventHandler(this.bsearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Status";
            // 
            // lstatus
            // 
            this.lstatus.AutoSize = true;
            this.lstatus.Location = new System.Drawing.Point(348, 19);
            this.lstatus.Name = "lstatus";
            this.lstatus.Size = new System.Drawing.Size(13, 13);
            this.lstatus.TabIndex = 12;
            this.lstatus.Text = "  ";
            // 
            // cbcat
            // 
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Items.AddRange(new object[] {
            "Allopathic",
            "Homeopathic",
            "Herbal"});
            this.cbcat.Location = new System.Drawing.Point(99, 75);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(119, 21);
            this.cbcat.TabIndex = 13;
            this.cbcat.SelectedIndexChanged += new System.EventHandler(this.tcatg_SelectedIndexChanged);
            // 
            // ldall
            // 
            this.ldall.AutoSize = true;
            this.ldall.Location = new System.Drawing.Point(266, 41);
            this.ldall.Name = "ldall";
            this.ldall.Size = new System.Drawing.Size(44, 13);
            this.ldall.TabIndex = 14;
            this.ldall.Text = "All Data";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Display All Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(269, 207);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(369, 118);
            this.dgv1.TabIndex = 17;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            // 
            // tstock
            // 
            this.tstock.Location = new System.Drawing.Point(99, 111);
            this.tstock.Name = "tstock";
            this.tstock.Size = new System.Drawing.Size(100, 20);
            this.tstock.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Stock";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 338);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tstock);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ldall);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.lstatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bsearch);
            this.Controls.Add(this.bdelete);
            this.Controls.Add(this.bupdate);
            this.Controls.Add(this.binsert);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Button binsert;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lstatus;
        private System.Windows.Forms.ComboBox cbcat;
        private System.Windows.Forms.Label ldall;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.TextBox tstock;
        private System.Windows.Forms.Label label5;
    }
}

