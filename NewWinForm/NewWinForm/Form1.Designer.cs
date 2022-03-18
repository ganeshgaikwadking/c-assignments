
namespace NewWinForm
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
            this.LblDept = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lbllocation = new System.Windows.Forms.Label();
            this.txtdeptid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.btncreatefile = new System.Windows.Forms.Button();
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btncreatefolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDept
            // 
            this.LblDept.AutoSize = true;
            this.LblDept.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDept.Location = new System.Drawing.Point(218, 117);
            this.LblDept.Name = "LblDept";
            this.LblDept.Size = new System.Drawing.Size(64, 24);
            this.LblDept.TabIndex = 0;
            this.LblDept.Text = "DeptId";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(218, 164);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lbllocation
            // 
            this.lbllocation.AutoSize = true;
            this.lbllocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllocation.Location = new System.Drawing.Point(217, 215);
            this.lbllocation.Name = "lbllocation";
            this.lbllocation.Size = new System.Drawing.Size(81, 24);
            this.lbllocation.TabIndex = 2;
            this.lbllocation.Text = "Location";
            // 
            // txtdeptid
            // 
            this.txtdeptid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeptid.Location = new System.Drawing.Point(365, 117);
            this.txtdeptid.Name = "txtdeptid";
            this.txtdeptid.Size = new System.Drawing.Size(100, 28);
            this.txtdeptid.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(365, 159);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 28);
            this.txtname.TabIndex = 4;
            // 
            // txtlocation
            // 
            this.txtlocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocation.Location = new System.Drawing.Point(365, 210);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(100, 28);
            this.txtlocation.TabIndex = 5;
            // 
            // btncreatefile
            // 
            this.btncreatefile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncreatefile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatefile.Location = new System.Drawing.Point(183, 37);
            this.btncreatefile.Name = "btncreatefile";
            this.btncreatefile.Size = new System.Drawing.Size(195, 38);
            this.btncreatefile.TabIndex = 6;
            this.btncreatefile.Text = "Create File";
            this.btncreatefile.UseVisualStyleBackColor = false;
            this.btncreatefile.Click += new System.EventHandler(this.btncreatefile_Click);
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbinarywrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbinarywrite.Location = new System.Drawing.Point(192, 283);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(167, 43);
            this.btnbinarywrite.TabIndex = 8;
            this.btnbinarywrite.Text = "Binary Write";
            this.btnbinarywrite.UseVisualStyleBackColor = false;
            this.btnbinarywrite.Click += new System.EventHandler(this.btnbinarywrite_Click);
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnbinaryread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbinaryread.Location = new System.Drawing.Point(410, 283);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(175, 43);
            this.btnbinaryread.TabIndex = 9;
            this.btnbinaryread.Text = "Binary Read";
            this.btnbinaryread.UseVisualStyleBackColor = false;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // btncreatefolder
            // 
            this.btncreatefolder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncreatefolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatefolder.Location = new System.Drawing.Point(429, 37);
            this.btncreatefolder.Name = "btncreatefolder";
            this.btncreatefolder.Size = new System.Drawing.Size(189, 38);
            this.btncreatefolder.TabIndex = 11;
            this.btncreatefolder.Text = "Create Folder";
            this.btncreatefolder.UseVisualStyleBackColor = false;
            this.btncreatefolder.Click += new System.EventHandler(this.btncreatefolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncreatefolder);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.btnbinarywrite);
            this.Controls.Add(this.btncreatefile);
            this.Controls.Add(this.txtlocation);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtdeptid);
            this.Controls.Add(this.lbllocation);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.LblDept);
            this.Name = "Form1";
            this.Text = "File IO Opeartion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDept;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbllocation;
        private System.Windows.Forms.TextBox txtdeptid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Button btncreatefile;
        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btncreatefolder;
    }
}

