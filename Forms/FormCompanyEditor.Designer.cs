namespace CompanyManagerApp.WinForms.Forms
{
    partial class FormCompanyEditor
    {
        private System.ComponentModel.IContainer components = null;

        // Definición de los controles
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblCountry;

        private void InitializeComponent()
        {
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(150, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Formulario de Empresa";

            // lblCompanyName
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(20, 50);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(51, 15);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Nombre";

            // txtCompanyName
            this.txtCompanyName.Location = new System.Drawing.Point(150, 50);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(200, 23);
            this.txtCompanyName.TabIndex = 2;

            // lblCode
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(20, 90);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(44, 15);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Código";

            // txtCode
            this.txtCode.Location = new System.Drawing.Point(150, 90);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(200, 23);
            this.txtCode.TabIndex = 4;

            // lblAddress
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 130);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(57, 15);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Dirección";

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(150, 130);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 23);
            this.txtAddress.TabIndex = 6;

            // lblPhone
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 170);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 15);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "Teléfono";

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(150, 170);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 23);
            this.txtPhone.TabIndex = 8;

            // lblCity
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(20, 210);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(43, 15);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "Ciudad";

            // txtCity
            this.txtCity.Location = new System.Drawing.Point(150, 210);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 23);
            this.txtCity.TabIndex = 10;

            // lblDepartment
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(20, 250);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(80, 15);
            this.lblDepartment.TabIndex = 11;
            this.lblDepartment.Text = "Departamento";

            // txtDepartment
            this.txtDepartment.Location = new System.Drawing.Point(150, 250);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(200, 23);
            this.txtDepartment.TabIndex = 12;

            // lblCountry
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(20, 290);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(30, 15);
            this.lblCountry.TabIndex = 13;
            this.lblCountry.Text = "País";

            // txtCountry
            this.txtCountry.Location = new System.Drawing.Point(150, 290);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 23);
            this.txtCountry.TabIndex = 14;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(150, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 30);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Guardar";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(260, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // FormCompanyEditor
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
