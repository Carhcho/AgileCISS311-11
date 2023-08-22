using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox11
{
    public partial class AddAdviseeForm : Form
    {
        string connectionString;
        SqlConnection conn;
        public AddAdviseeForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings
                ["dropbox11.Properties.Settings.AdvisingDBConnectionString"].ConnectionString;
        }

        private void AddAdviseeForm_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM advisor", conn))
            {
                DataTable advisorTable = new DataTable();
                adapter.Fill(advisorTable);
                advisorComboBox.DisplayMember = "advisorName";
                advisorComboBox.ValueMember = "advisorId";
                advisorComboBox.DataSource = advisorTable;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(connectionString))
            using (SqlCommand comd = new SqlCommand("INSERT INTO avisee (adviseeName, advisorId)" + "VALUES (@adviseeName, @advisorId)", conn))
            {
                conn.Open();
                comd.Parameters.AddWithValue("@adviseeName", adviseeNameTextBox.Text);
                comd.Parameters.AddWithValue("@advisorId", advisorComboBox.SelectedValue);
                comd.ExecuteScalar();
                MessageBox.Show("Advisee added.");
            }
        }
    }
}
