
namespace ProductWithArchitectureAssignment
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
            this.components = new System.ComponentModel.Container();
            this.txtcompanyname = new System.Windows.Forms.TextBox();
            this.txtproductname = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.lblcategoryname = new System.Windows.Forms.Label();
            this.lblcompanyname = new System.Windows.Forms.Label();
            this.lblproductname = new System.Windows.Forms.Label();
            this.lblproductid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcategoryname = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.assignmentDataSet = new ProductWithArchitectureAssignment.AssignmentDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new ProductWithArchitectureAssignment.AssignmentDataSetTableAdapters.CategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcompanyname
            // 
            this.txtcompanyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompanyname.Location = new System.Drawing.Point(413, 234);
            this.txtcompanyname.Name = "txtcompanyname";
            this.txtcompanyname.Size = new System.Drawing.Size(170, 27);
            this.txtcompanyname.TabIndex = 14;
            // 
            // txtproductname
            // 
            this.txtproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductname.Location = new System.Drawing.Point(413, 177);
            this.txtproductname.Name = "txtproductname";
            this.txtproductname.Size = new System.Drawing.Size(170, 27);
            this.txtproductname.TabIndex = 13;
            // 
            // txtproductid
            // 
            this.txtproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductid.Location = new System.Drawing.Point(413, 125);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(170, 27);
            this.txtproductid.TabIndex = 12;
            // 
            // lblcategoryname
            // 
            this.lblcategoryname.AutoSize = true;
            this.lblcategoryname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcategoryname.Location = new System.Drawing.Point(217, 299);
            this.lblcategoryname.Name = "lblcategoryname";
            this.lblcategoryname.Size = new System.Drawing.Size(125, 20);
            this.lblcategoryname.TabIndex = 11;
            this.lblcategoryname.Text = "Category Name";
            // 
            // lblcompanyname
            // 
            this.lblcompanyname.AutoSize = true;
            this.lblcompanyname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcompanyname.Location = new System.Drawing.Point(217, 234);
            this.lblcompanyname.Name = "lblcompanyname";
            this.lblcompanyname.Size = new System.Drawing.Size(128, 20);
            this.lblcompanyname.TabIndex = 10;
            this.lblcompanyname.Text = "Company Name";
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(217, 177);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(116, 20);
            this.lblproductname.TabIndex = 9;
            this.lblproductname.Text = "Product Name";
            // 
            // lblproductid
            // 
            this.lblproductid.AutoSize = true;
            this.lblproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductid.Location = new System.Drawing.Point(217, 125);
            this.lblproductid.Name = "lblproductid";
            this.lblproductid.Size = new System.Drawing.Size(89, 20);
            this.lblproductid.TabIndex = 8;
            this.lblproductid.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Details";
            // 
            // cmbcategoryname
            // 
            this.cmbcategoryname.DataSource = this.categoryBindingSource;
            this.cmbcategoryname.DisplayMember = "Name";
            this.cmbcategoryname.FormattingEnabled = true;
            this.cmbcategoryname.Location = new System.Drawing.Point(413, 299);
            this.cmbcategoryname.Name = "cmbcategoryname";
            this.cmbcategoryname.Size = new System.Drawing.Size(170, 24);
            this.cmbcategoryname.TabIndex = 17;
            this.cmbcategoryname.ValueMember = "Code";
            this.cmbcategoryname.SelectedIndexChanged += new System.EventHandler(this.cmbcategoryname_SelectedIndexChanged);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(606, 369);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(151, 39);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            // 
            // btnsearch
            // 
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(240, 370);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(132, 39);
            this.btnsearch.TabIndex = 20;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(429, 367);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(121, 42);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(69, 370);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(128, 42);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // assignmentDataSet
            // 
            this.assignmentDataSet.DataSetName = "AssignmentDataSet";
            this.assignmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.assignmentDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cmbcategoryname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcompanyname);
            this.Controls.Add(this.txtproductname);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.lblcategoryname);
            this.Controls.Add(this.lblcompanyname);
            this.Controls.Add(this.lblproductname);
            this.Controls.Add(this.lblproductid);
            this.Name = "Form1";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assignmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtcompanyname;
        private System.Windows.Forms.TextBox txtproductname;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label lblcategoryname;
        private System.Windows.Forms.Label lblcompanyname;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.Label lblproductid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcategoryname;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private AssignmentDataSet assignmentDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private AssignmentDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
    }
}

