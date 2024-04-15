using System.Data.SQLite;
using System.Drawing.Text;

namespace elso
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=Person.db;Version = 3;";

        private void createDatabase()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string createTablePeople = @"CREATE TABLE IF NOT EXISTS People (
                                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                                Firstname TEXT,
                                                Lastname TEXT,
                                                City TEXT
                                            );";

                using (var createTable = new SQLiteCommand(createTablePeople, conn))
                {
                    createTable.ExecuteNonQuery();
                }
            }
        }

        private void insertPerson(string firstname, string lastname, string city)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string insertPerson = "INSERT INTO People (Firstname, Lastname, City)" +
                                      "VALUES (@firstname, @lastname, @city);";

                using (var insPerson = new SQLiteCommand(insertPerson, conn))
                {
                    insPerson.Parameters.AddWithValue("@firstname", firstname);
                    insPerson.Parameters.AddWithValue("@lastnaem", lastname);
                    insPerson.Parameters.AddWithValue("@city", city);
                    insPerson.ExecuteNonQuery();
                }
            }
        }

        private void deletePerson(int id)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string deletePerson = "DELETE FROM People WHERE id = @id;";

                using (var delPerson = new SQLiteCommand(deletePerson, conn))
                {
                    delPerson.Parameters.AddWithValue("@id", firstname);
                    delPerson.ExecuteNonQuery();
                }
            }
        }

        private void updatePerson()
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string updatePerson = "UPDATE People SET Firstname = @firstname " +
                                      "Lastname = @lastname " +
                                      "City = @city " +
                                      "WHERE Id = @id;";

                using (var updPerson = new SQLiteCommand(updatePerson, conn))
                {
                    updPerson.Parameters.AddWithValue("@firstname", firstname);
                    updPerson.Parameters.AddWithValue("@lastnaem", lastname);
                    updPerson.Parameters.AddWithValue("@city", city);
                    updPerson.Parameters.AddWithValue("@id", id);
                    updPerson.ExecuteNonQuery();
                }
            }
        }

        private List<Person> ListPeople()
        {
            var peopleList = new List<Person>();

            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                string selectPerson = "SELECT * FROM People;";

                using (var selPerson = new SQLiteCommand(selectPerson, conn))
                {
                    using (var reader = selPerson.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            peopleList.Add(new Person(
                                           Convert.ToInt32(reader["Id"]),
                                           reader["Firstname"].ToString(),
                                           reader["Lastname"].ToString(),
                                           reader["city"].ToString()
                                           ));
                        }
                    }
                }
            }
            return peopleList;
        }

        private void populateDataGridView()
        {
            List<Person> people = ListPeople();

            foreach (var p in people)
            {
                string[] row = new[] { p.Id.ToString(), p.Firstname, p.Lastname, p.City };
                databaseGridView.Rows.Add(row);
            }
        }

        private void updateDataGridView()
        {
            databaseGridView.Rows.Clear();
            populateDataGridView();
        }

        private void clearFields()
        {
            idTextBox.Clear();
            firstnameTextBox.Clear();
            lastnameTextBox.Clear();
            cityTextBox.Clear();
        }






        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            createDatabase();
            populateDataGridView();


        }

        private void addButton_Click(object sender, EventArgs e)
        {
            insertPerson(firstnameTextBox.Text, lastnameTextBox.Text, cityTextBox.Text);
            updateDataGridView();
            clearFields();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = databaseGridView.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = databaseGridView.Rows[selectedRowIndex];
            string cellValue = selectedRow.Cells["id"].Value.ToString();

            deletePerson(Convert.ToInt32(cellValue));
            updateDataGridView();

        }
    }
}
