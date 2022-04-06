
namespace ProductWinFromAssignment
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
            this.lblcode = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.btnjsonwrite = new System.Windows.Forms.Button();
            this.btnjsonread = new System.Windows.Forms.Button();
            this.btnsoapwrite = new System.Windows.Forms.Button();
            this.btnsoapread = new System.Windows.Forms.Button();
            this.btnxmlwrite = new System.Windows.Forms.Button();
            this.btnxmlread = new System.Windows.Forms.Button();
            this.btnbinaryread = new System.Windows.Forms.Button();
            this.btnbinarywrite = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcode
            // 
            this.lblcode.AutoSize = true;
            this.lblcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcode.Location = new System.Drawing.Point(258, 64);
            this.lblcode.Name = "lblcode";
            this.lblcode.Size = new System.Drawing.Size(56, 24);
            this.lblcode.TabIndex = 0;
            this.lblcode.Text = "Code";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(253, 115);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(61, 24);
            this.lblname.TabIndex = 1;
            this.lblname.Text = "Name";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(253, 170);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(53, 24);
            this.lblprice.TabIndex = 2;
            this.lblprice.Text = "Price";
            // 
            // txtcode
            // 
            this.txtcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(350, 64);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(186, 28);
            this.txtcode.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(350, 115);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(186, 28);
            this.txtname.TabIndex = 4;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(350, 170);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(186, 28);
            this.txtprice.TabIndex = 5;
            // 
            // btnjsonwrite
            // 
            this.btnjsonwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjsonwrite.Location = new System.Drawing.Point(638, 258);
            this.btnjsonwrite.Name = "btnjsonwrite";
            this.btnjsonwrite.Size = new System.Drawing.Size(161, 32);
            this.btnjsonwrite.TabIndex = 27;
            this.btnjsonwrite.Text = "JSON Write";
            this.btnjsonwrite.UseVisualStyleBackColor = true;
            this.btnjsonwrite.Click += new System.EventHandler(this.btnjsonwrite_Click);
            // 
            // btnjsonread
            // 
            this.btnjsonread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjsonread.Location = new System.Drawing.Point(638, 348);
            this.btnjsonread.Name = "btnjsonread";
            this.btnjsonread.Size = new System.Drawing.Size(161, 32);
            this.btnjsonread.TabIndex = 26;
            this.btnjsonread.Text = "JSON Read";
            this.btnjsonread.UseVisualStyleBackColor = true;
            this.btnjsonread.Click += new System.EventHandler(this.btnjsonread_Click);
            // 
            // btnsoapwrite
            // 
            this.btnsoapwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoapwrite.Location = new System.Drawing.Point(453, 258);
            this.btnsoapwrite.Name = "btnsoapwrite";
            this.btnsoapwrite.Size = new System.Drawing.Size(152, 32);
            this.btnsoapwrite.TabIndex = 25;
            this.btnsoapwrite.Text = "Soap Write";
            this.btnsoapwrite.UseVisualStyleBackColor = true;
            this.btnsoapwrite.Click += new System.EventHandler(this.btnsoapwrite_Click);
            // 
            // btnsoapread
            // 
            this.btnsoapread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsoapread.Location = new System.Drawing.Point(453, 348);
            this.btnsoapread.Name = "btnsoapread";
            this.btnsoapread.Size = new System.Drawing.Size(152, 32);
            this.btnsoapread.TabIndex = 24;
            this.btnsoapread.Text = "Soap Read";
            this.btnsoapread.UseVisualStyleBackColor = true;
            this.btnsoapread.Click += new System.EventHandler(this.btnsoapread_Click);
            // 
            // btnxmlwrite
            // 
            this.btnxmlwrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxmlwrite.Location = new System.Drawing.Point(249, 258);
            this.btnxmlwrite.Name = "btnxmlwrite";
            this.btnxmlwrite.Size = new System.Drawing.Size(154, 32);
            this.btnxmlwrite.TabIndex = 23;
            this.btnxmlwrite.Text = "Xml Write";
            this.btnxmlwrite.UseVisualStyleBackColor = true;
            this.btnxmlwrite.Click += new System.EventHandler(this.btnxmlwrite_Click);
            // 
            // btnxmlread
            // 
            this.btnxmlread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxmlread.Location = new System.Drawing.Point(249, 348);
            this.btnxmlread.Name = "btnxmlread";
            this.btnxmlread.Size = new System.Drawing.Size(154, 32);
            this.btnxmlread.TabIndex = 22;
            this.btnxmlread.Text = "Xml Read";
            this.btnxmlread.UseVisualStyleBackColor = true;
            this.btnxmlread.Click += new System.EventHandler(this.btnxmlread_Click);
            // 
            // btnbinaryread
            // 
            this.btnbinaryread.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbinaryread.Location = new System.Drawing.Point(23, 348);
            this.btnbinaryread.Name = "btnbinaryread";
            this.btnbinaryread.Size = new System.Drawing.Size(177, 32);
            this.btnbinaryread.TabIndex = 21;
            this.btnbinaryread.Text = "Binary Read";
            this.btnbinaryread.UseVisualStyleBackColor = true;
            this.btnbinaryread.Click += new System.EventHandler(this.btnbinaryread_Click);
            // 
            // btnbinarywrite
            // 
            this.btnbinarywrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbinarywrite.Location = new System.Drawing.Point(23, 258);
            this.btnbinarywrite.Name = "btnbinarywrite";
            this.btnbinarywrite.Size = new System.Drawing.Size(177, 32);
            this.btnbinarywrite.TabIndex = 20;
            this.btnbinarywrite.Text = "Binary Write";
            this.btnbinarywrite.UseVisualStyleBackColor = true;
            this.btnbinarywrite.Click += new System.EventHandler(this.btnbinarywrite_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Product Details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnjsonwrite);
            this.Controls.Add(this.btnjsonread);
            this.Controls.Add(this.btnsoapwrite);
            this.Controls.Add(this.btnsoapread);
            this.Controls.Add(this.btnxmlwrite);
            this.Controls.Add(this.btnxmlread);
            this.Controls.Add(this.btnbinaryread);
            this.Controls.Add(this.btnbinarywrite);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtcode);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblcode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcode;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Button btnjsonwrite;
        private System.Windows.Forms.Button btnjsonread;
        private System.Windows.Forms.Button btnsoapwrite;
        private System.Windows.Forms.Button btnsoapread;
        private System.Windows.Forms.Button btnxmlwrite;
        private System.Windows.Forms.Button btnxmlread;
        private System.Windows.Forms.Button btnbinaryread;
        private System.Windows.Forms.Button btnbinarywrite;
        private System.Windows.Forms.Label label1;
    }
}

