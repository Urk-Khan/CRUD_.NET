namespace Purposel_Project
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
            this.lid = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.ltype = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.TextBox();
            this.tname = new System.Windows.Forms.TextBox();
            this.ttype = new System.Windows.Forms.TextBox();
            this.binsert = new System.Windows.Forms.Button();
            this.bupdate = new System.Windows.Forms.Button();
            this.bdelete = new System.Windows.Forms.Button();
            this.bsearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lid
            // 
            this.lid.AutoSize = true;
            this.lid.Location = new System.Drawing.Point(28, 33);
            this.lid.Name = "lid";
            this.lid.Size = new System.Drawing.Size(18, 13);
            this.lid.TabIndex = 0;
            this.lid.Text = "ID";
            this.lid.Click += new System.EventHandler(this.label1_Click);
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Location = new System.Drawing.Point(31, 65);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(81, 13);
            this.lname.TabIndex = 1;
            this.lname.Text = "Medicine Name";
            // 
            // ltype
            // 
            this.ltype.AutoSize = true;
            this.ltype.Location = new System.Drawing.Point(34, 101);
            this.ltype.Name = "ltype";
            this.ltype.Size = new System.Drawing.Size(77, 13);
            this.ltype.TabIndex = 2;
            this.ltype.Text = "Medicine Type";
            // 
            // tid
            // 
            this.tid.Location = new System.Drawing.Point(131, 33);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(100, 20);
            this.tid.TabIndex = 3;
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(131, 65);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(100, 20);
            this.tname.TabIndex = 4;
            // 
            // ttype
            // 
            this.ttype.Location = new System.Drawing.Point(131, 101);
            this.ttype.Name = "ttype";
            this.ttype.Size = new System.Drawing.Size(100, 20);
            this.ttype.TabIndex = 5;
            // 
            // binsert
            // 
            this.binsert.Location = new System.Drawing.Point(37, 173);
            this.binsert.Name = "binsert";
            this.binsert.Size = new System.Drawing.Size(75, 23);
            this.binsert.TabIndex = 6;
            this.binsert.Text = "Insert";
            this.binsert.UseVisualStyleBackColor = true;
            this.binsert.Click += new System.EventHandler(this.binsert_Click);
            // 
            // bupdate
            // 
            this.bupdate.Location = new System.Drawing.Point(150, 172);
            this.bupdate.Name = "bupdate";
            this.bupdate.Size = new System.Drawing.Size(75, 23);
            this.bupdate.TabIndex = 7;
            this.bupdate.Text = "Update";
            this.bupdate.UseVisualStyleBackColor = true;
            // 
            // bdelete
            // 
            this.bdelete.Location = new System.Drawing.Point(259, 171);
            this.bdelete.Name = "bdelete";
            this.bdelete.Size = new System.Drawing.Size(75, 23);
            this.bdelete.TabIndex = 8;
            this.bdelete.Text = "Delete";
            this.bdelete.UseVisualStyleBackColor = true;
            // 
            // bsearch
            // 
            this.bsearch.Location = new System.Drawing.Point(369, 172);
            this.bsearch.Name = "bsearch";
            this.bsearch.Size = new System.Drawing.Size(75, 23);
            this.bsearch.TabIndex = 9;
            this.bsearch.Text = "Search";
            this.bsearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status";
            // 
            // lstatus
            // 
            this.lstatus.AutoSize = true;
            this.lstatus.Location = new System.Drawing.Point(131, 128);
            this.lstatus.Name = "lstatus";
            this.lstatus.Size = new System.Drawing.Size(10, 13);
            this.lstatus.TabIndex = 11;
            this.lstatus.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.lstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bsearch);
            this.Controls.Add(this.bdelete);
            this.Controls.Add(this.bupdate);
            this.Controls.Add(this.binsert);
            this.Controls.Add(this.ttype);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.ltype);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.lid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lid;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label ltype;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox ttype;
        private System.Windows.Forms.Button binsert;
        private System.Windows.Forms.Button bupdate;
        private System.Windows.Forms.Button bdelete;
        private System.Windows.Forms.Button bsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lstatus;
    }
}

