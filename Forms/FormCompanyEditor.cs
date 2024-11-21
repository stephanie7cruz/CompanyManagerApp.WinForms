using System;
using System.Windows.Forms;
using CompanyManagerApp.Models;

namespace CompanyManagerApp.WinForms.Forms
{
    public partial class FormCompanyEditor : Form
    {
        private AppDbContext _context;
        private Company _company;

        public FormCompanyEditor(Company company = null)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _company = company;

            if (_company != null)
            {
                // Si se pasa una empresa, cargamos los datos en los campos.
                txtCompanyName.Text = _company.Name;
                txtCode.Text = _company.Code.ToString();
                txtAddress.Text = _company.Address;
                txtPhone.Text = _company.Phone;
                txtCity.Text = _company.City;
                txtDepartment.Text = _company.Department;
                txtCountry.Text = _company.Country;
                lblTitle.Text = "Editando Empresa";
            }
            else
            {
                lblTitle.Text = "Creando nueva Empresa";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_company == null)
            {
                _company = new Company();
                _context.Companies.Add(_company);
            }

            _company.Name = txtCompanyName.Text;
            _company.Code = int.Parse(txtCode.Text);
            _company.Address = txtAddress.Text;
            _company.Phone = txtPhone.Text;
            _company.City = txtCity.Text;
            _company.Department = txtDepartment.Text;
            _company.Country = txtCountry.Text;
            _company.UpdatedAt = DateTime.Now;

            _context.SaveChanges();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCompanyEditor_Load(object sender, EventArgs e)
        {
        }
    }
}
