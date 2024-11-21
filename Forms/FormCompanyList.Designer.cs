namespace CompanyManagerApp.WinForms.Forms
{
    partial class FormCompanyList
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewCompanies;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFilter;

        private void InitializeComponent()
        {
            this.dataGridViewCompanies = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).BeginInit();
            this.SuspendLayout();

            // dataGridViewCompanies
            this.dataGridViewCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompanies.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCompanies.Name = "dataGridViewCompanies";
            this.dataGridViewCompanies.Size = new System.Drawing.Size(776, 150);
            this.dataGridViewCompanies.TabIndex = 0;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(12, 200);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnEdit
            this.btnEdit.Location = new System.Drawing.Point(93, 200);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(174, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // txtFilter
            this.txtFilter.Location = new System.Drawing.Point(12, 180);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(238, 20);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);

            // FormCompanyList
            this.ClientSize = new System.Drawing.Size(800, 250);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewCompanies);
            this.Name = "FormCompanyList";
            this.Text = "Company List";
            this.Load += new System.EventHandler(this.FormCompanyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
