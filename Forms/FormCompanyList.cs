using System;
using System.Linq;
using System.Windows.Forms;
using CompanyManagerApp.Models;

namespace CompanyManagerApp.WinForms.Forms
{
    public partial class FormCompanyList : Form
    {
        private AppDbContext _context;

        public FormCompanyList()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void FormCompanyList_Load(object sender, EventArgs e)
        {
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            var companies = _context.Companies.ToList();
            dataGridViewCompanies.DataSource = companies;
            dataGridViewCompanies.Columns["CompanyID"].Visible = false; // Ocultar CompanyID
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editorForm = new FormCompanyEditor();
            editorForm.ShowDialog();
            LoadCompanies();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewCompanies.SelectedRows.Count == 1)
            {
                var selectedRow = dataGridViewCompanies.SelectedRows[0];
                int companyId = (int)selectedRow.Cells["CompanyID"].Value;
                var company = _context.Companies.Find(companyId);

                var editorForm = new FormCompanyEditor(company);
                editorForm.ShowDialog();
                LoadCompanies();
            }
            else
            {
                MessageBox.Show("Please select one company to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewCompanies.SelectedRows)
            {
                int companyId = (int)row.Cells["CompanyID"].Value;
                var company = _context.Companies.Find(companyId);
                _context.Companies.Remove(company);
            }
            _context.SaveChanges();
            LoadCompanies();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            var filter = txtFilter.Text.ToLower();
            var filteredCompanies = _context.Companies
                .Where(c => c.Name.ToLower().Contains(filter))
                .ToList();
            dataGridViewCompanies.DataSource = filteredCompanies;
        }
    }
}
