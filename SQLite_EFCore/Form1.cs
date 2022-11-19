using Microsoft.EntityFrameworkCore;

namespace SQLite_EFCore
{
    public partial class frmMyform : Form
    {
        public frmMyform()
        {
            InitializeComponent();
            LoadAgeComboBox();
            LoadGridData();
        }

        private void LoadAgeComboBox()
        {
            for (int i = 1; i <= 50; i++)
            {
                cmbAge.Items.Add(i);
            }
            cmbAge.SelectedItem = 20;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            using (var context = new DAL.SQLite_EFCore_Context())
            {
                Guid personID = Guid.NewGuid();
                var newPerson = new DAL.Entities.Person
                {
                    Id = personID,
                    Name = txtName.Text,
                    Age = Convert.ToInt32(cmbAge.SelectedItem)
                };
                context.Persons.Add(newPerson);

                var newAddress = new DAL.Entities.Address
                {
                    Id = Guid.NewGuid(),
                    PersonId = personID,
                    City = txtCity.Text,
                    State = txtState.Text
                };
                context.Addresses.Add(newAddress);

                context.SaveChanges();
            }
            LoadGridData();
        }

        private void dgPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                var personID = dgPersons.Rows[e.RowIndex].Cells[0].Value;
                using (var context = new DAL.SQLite_EFCore_Context())
                {
                    var person = context.Persons.Include(p => p.Address).FirstOrDefault(p => p.Id == Guid.Parse(personID.ToString()!));
                    if (person != null)
                    {
                        context.Addresses.Remove(person.Address);
                        context.Persons.Remove(person);
                        context.SaveChanges();
                    }
                }
                LoadGridData();
            }
        }

        private void LoadGridData()
        {
            using (var context = new DAL.SQLite_EFCore_Context())
            {
                var persons = context.Persons.Include(p => p.Address).ToList();
                dgPersons.Rows.Clear();
                foreach (var person in persons)
                {
                    dgPersons.Rows.Add(person.Id, person.Name, person.Age, person.Address.City, person.Address.State);
                }
            }
        }

        private void frmMyform_Shown(object sender, EventArgs e)
        {
            LoadGridData();
        }
    }
}