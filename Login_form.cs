using System.Data.SqlClient;
namespace ShuchiDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fix: Remove the spaces in "TrustServerCertificate"
            string ConnectionString = "Data Source=DESKTOP-N6H0FEQ\\SQLEXPRESS;Initial Catalog=practiceDB;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection con = new SqlConnection(ConnectionString);

            con.Open();

            string firstname = tbfirstname.Text;
            string secondname = tbsecondname.Text;

            // Note: This works, but using parameters (as shown below) is safer for real apps!
            string Query = "INSERT INTO Names (FirstName, LastName) VALUES ('" + firstname + "', '" + secondname + "')";

            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data has been saved successfully!");
        }
    }
}
