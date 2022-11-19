namespace SQLite_EFCore
{
    public partial class frmMyform : Form
    {
        public frmMyform()
        {
            InitializeComponent();
        }

        private void frmMyform_Load(object sender, EventArgs e)
        {
            //Populate Age combo
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
                context.Persons.Add(new DAL.Entities.Person
                {
                    Id = Guid.NewGuid(),
                    Name = txtName.Text,
                    Age = Convert.ToInt32(cmbAge.SelectedValue)
                });

                int affectedRows = context.SaveChanges();
                //if (affectedRows > 0)
                //{
                //    MessageBox.Show("Person Added Successfully");
                //}
            }
            LoadGridData();
        }
        private void dgPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= -1)
            {
                var personID = dgPersons.Rows[e.RowIndex].Cells[0].Value;
                using (var context = new DAL.SQLite_EFCore_Context())
                {
                    var person = context.Persons.Where(p => p.Id.ToString() == personID).FirstOrDefault();
                    if (person != null)
                    {
                        context.Persons.Remove(person);
                    }
                    context.SaveChanges();
                }
                LoadGridData();

            }
        }
        private void LoadGridData()
        {

            using (var context = new DAL.SQLite_EFCore_Context())
            {
                var persons = context.Persons.ToList();
                dgPersons.Rows.Clear();
                foreach (var person in persons)
                {
                    dgPersons.Rows.Add(person.Id, person.Name, person.Age);

                }
            }
        }

        private void frmMyform_Shown(object sender, EventArgs e)
        {

            LoadGridData();
        }

        
    }
}