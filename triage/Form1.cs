using System.ComponentModel.Design;
using System.Data;

using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using MySqlConnector;
namespace triage
{
    public partial class Form1 : Form




    {
        private ProjectTargetFrameworkAttribute Project { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost;Database=project;Uid=root;Pwd=12345;";
            MySqlConnection connection = new MySqlConnection(connectionString);



            try
            {
                connection.Open();
                MessageBox.Show("Connection to the database is successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Connection is now open, you can perform database operations here.
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that may occur when trying to open the connection.
                Console.WriteLine("Error: " + ex.Message);
            }
            string query1 = "select * from patient";

            using (MySqlCommand command = new MySqlCommand(query1, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                }
            }
            string query2 = "select * from  module";

            using (MySqlCommand command = new MySqlCommand(query2, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView2.DataSource = dataTable;

                }
            }


        }
        public DataTable ReadDataP()
        {
            string connectionString = "Server=localhost;Database=project;Uid=root;Pwd=12345;";
            MySqlConnection connection = new MySqlConnection(connectionString);



            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            DataTable dataTable = new DataTable();
            string query = "Select * from patient";



            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }
            connection.Close();
            return dataTable;
        }
        public DataTable dataM()
        {
            string connectionString = "Server=localhost;Database=project;Uid=root;Pwd=12345;";
            MySqlConnection connection = new MySqlConnection(connectionString);



            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }



            DataTable dataTable = new DataTable();
            string query = "Select * from module";



            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }
            connection.Close();
            return dataTable;
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool hasId = !string.IsNullOrWhiteSpace(ID.Text);


            string query = "insert into patient (";


            string connectionString = "Server=localhost;Database=project;Uid=root;Pwd=12345;";
            MySqlConnection connection = new MySqlConnection(connectionString);



            try
            {
                connection.Open();
                MessageBox.Show("Connection to the database is successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Connection is now open, you can perform database operations here.
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that may occur when trying to open the connection.
                Console.WriteLine("Error: " + ex.Message);
            }



            if (hasId)
            {
                query += "id, ";
            }






            query += "other_id, name, telephone, mobile, fax, other_telephone, email, sex, birth_date, process_number, postal_code, postal_area, locality, postal_code_id, address, town, postal_code_full, nif, sns) VALUES (";




            if (hasId)
            {
                query += "@IdValue, ";
            }







            query += "@OtherIDValue, @NameValue, @TelephoneValue, @MobileValue, @FaxValue, @OtherTelephoneValue, @EmailValue, @SexValue, @BirthDateValue, @ProcessNumberValue, @PostalCodeValue, @PostalAreaValue, @LocalityValue, @PostalCodeIDValue, @AddressValue, @TownValue, @PostalCodeFullValue, @NIFValue, @SNSValue)";



            using (MySqlCommand command = new MySqlCommand(query, connection))

            {



                if (hasId)
                {
                    command.Parameters.AddWithValue("@IdValue", ID.Text);
                }





                command.Parameters.AddWithValue("@OtherIDValue", Other_id.Text);

                command.Parameters.AddWithValue("@NameValue", name.Text);

                command.Parameters.AddWithValue("@TelephoneValue", telephone.Text);

                command.Parameters.AddWithValue("@MobileValue", Moble.Text);

                command.Parameters.AddWithValue("@FaxValue", fax.Text);

                command.Parameters.AddWithValue("@OtherTelephoneValue", Other_telephone.Text);

                command.Parameters.AddWithValue("@EmailValue", email.Text);

                command.Parameters.AddWithValue("@SexValue", sex.Text);

                command.Parameters.AddWithValue("@BirthDateValue", BirthDate.Text);

                command.Parameters.AddWithValue("@ProcessNumberValue", Process_Number.Text);

                command.Parameters.AddWithValue("@PostalCodeValue", Postal_Code.Text);

                command.Parameters.AddWithValue("@PostalAreaValue", Postal_Area.Text);

                command.Parameters.AddWithValue("@LocalityValue", Locality.Text);

                command.Parameters.AddWithValue("@PostalCodeIDValue", PostalCode_Id.Text);

                command.Parameters.AddWithValue("@AddressValue", Andress.Text);

                command.Parameters.AddWithValue("@TownValue", town.Text);

                command.Parameters.AddWithValue("@PostalCodeFullValue", PostalCode_Full.Text);

                command.Parameters.AddWithValue("@NIFValue", NIF.Text);

                command.Parameters.AddWithValue("@SNSValue", SNS.Text);



                command.ExecuteNonQuery();
                dataGridView1.DataSource = ReadDataP();







            }





        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertM1_Click(object sender, EventArgs e)
        {
            bool hasId = !string.IsNullOrWhiteSpace(ID.Text);


            string query = "insert into module (";


            string connectionString = "Server=localhost;Database=project;Uid=root;Pwd=12345;";
            MySqlConnection connection = new MySqlConnection(connectionString);



            try
            {
                connection.Open();
                MessageBox.Show("Connection to the database is successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Connection is now open, you can perform database operations here.
            }
            catch (MySqlException ex)
            {
                // Handle any exceptions that may occur when trying to open the connection.
                Console.WriteLine("Error: " + ex.Message);

            }
            if (hasId)
            {
                query += "id, ";
            }


            query += "patient_id,episode, module) values (";

            if (hasId)
            {
                query += "@mID, ";
            }

            query += "@MPatentID,@MEpsode,@Mmodule)";
            using (MySqlCommand command = new MySqlCommand(query, connection))

            {


                if (hasId)
                {
                    command.Parameters.AddWithValue("@mID", mID.Text);
                }






                command.Parameters.AddWithValue("@MPatentID", MPatentID.Text);

                command.Parameters.AddWithValue("@MEpsode", MEpsode.Text);

                command.Parameters.AddWithValue("@Mmodule", Mmodule.Text);

                command.ExecuteNonQuery();
                dataGridView2.DataSource = dataM();

            }

        }

        private void Edit2_Click(object sender, EventArgs e)
        {

            if (int.TryParse(ID.Text, out int id))
            {
                string connectionString = "Server=localhost;Database=project;Uid=root;Pwd=12345;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    using (MySqlCommand cmd = connection.CreateCommand())

                    {

                        cmd.CommandType = CommandType.Text;
                        string edit = "";
                        if (!string.IsNullOrEmpty(Other_id.Text))
                        {
                            edit += "other_id = @OtherIDValue, ";
                            cmd.Parameters.AddWithValue("@OtherIDValue", Other_id.Text);
                        }
                        if (!string.IsNullOrEmpty(telephone.Text))
                        {
                            edit += "telephone =  @TelephoneValue, ";
                            cmd.Parameters.AddWithValue("@TelephoneValue", telephone.Text);
                        }
                        if (!string.IsNullOrEmpty(name.Text))
                        {
                            edit += "name = @NameValue, ";
                            cmd.Parameters.AddWithValue("@NameValue", name.Text);
                        }
                        if (!string.IsNullOrEmpty(Moble.Text))
                        {
                            edit += "mobile= @MobileValue, ";
                            cmd.Parameters.AddWithValue("@MobileValue", Moble.Text); ;
                        }
                        if (!string.IsNullOrEmpty(fax.Text))
                        {
                            edit += "fax = @FaxValue, ";
                            cmd.Parameters.AddWithValue("@FaxValue", fax.Text); ;
                        }
                        if (!string.IsNullOrEmpty(email.Text))
                        {
                            edit += "email= @EmailValue, ";
                            cmd.Parameters.AddWithValue("@EmailValue", email.Text); ;
                        }
                        if (!string.IsNullOrEmpty(sex.Text))
                        {
                            edit += "sex = @SexValue, ";
                            cmd.Parameters.AddWithValue("@SexValue", sex.Text);
                        }
                        if (!string.IsNullOrEmpty(BirthDate.Text))
                        {
                            edit += "birth_date = @BirthDateValue, ";
                            cmd.Parameters.AddWithValue("@BirthDateValue", BirthDate.Text);
                        }
                        if (!string.IsNullOrEmpty(Process_Number.Text))
                        {
                            edit += " process_number= @ProcessNumberValue, ";
                            cmd.Parameters.AddWithValue("@ProcessNumberValue", Process_Number.Text);
                        }
                        if (!string.IsNullOrEmpty(Postal_Code.Text))
                        {
                            edit += "postal_code=@PostalCodeValue, ";
                            cmd.Parameters.AddWithValue("@PostalCodeValue", Postal_Code.Text);
                        }
                        if (!string.IsNullOrEmpty(Postal_Area.Text))
                        {
                            edit += "postal_area= @PostalAreaValue, ";
                            cmd.Parameters.AddWithValue("@PostalAreaValue", Postal_Area.Text);
                        }
                        if (!string.IsNullOrEmpty(Locality.Text))
                        {
                            edit += "locality= @LocalityValue, ";
                            cmd.Parameters.AddWithValue("@LocalityValue", Locality.Text);
                        }
                        if (!string.IsNullOrEmpty(PostalCode_Id.Text))
                        {
                            edit += "postal_code_id= @PostalCodeIDValue, ";
                            cmd.Parameters.AddWithValue("@PostalCodeIDValue", PostalCode_Id.Text);
                        }
                        if (!string.IsNullOrEmpty(Andress.Text))
                        {
                            edit += "address= @AddressValue, ";
                            cmd.Parameters.AddWithValue("@AddressValue", Andress.Text);
                        }
                        if (!string.IsNullOrEmpty(town.Text))
                        {
                            edit += "town=@TownValue, ";
                            cmd.Parameters.AddWithValue("@TownValue", town.Text);
                        }
                        if (!string.IsNullOrEmpty(PostalCode_Full.Text))
                        {
                            edit += " postal_code_full=@PostalCodeFullValue, ";
                            cmd.Parameters.AddWithValue("@PostalCodeFullValue", PostalCode_Full.Text);
                        }
                        if (!string.IsNullOrEmpty(NIF.Text))
                        {
                            edit += "nif=@NIFValue, ";
                            cmd.Parameters.AddWithValue("@NIFValue", NIF.Text);
                        }
                        if (!string.IsNullOrEmpty(SNS.Text))
                        {
                            edit += "sns=@SNSValue, ";
                            cmd.Parameters.AddWithValue("@SNSValue", SNS.Text);
                        }
                        if (!string.IsNullOrEmpty(edit))
                        {
                            edit = edit.TrimEnd(',', ' ');
                        }



                        if (!string.IsNullOrEmpty(edit))
                        {
                            cmd.CommandText = $"update patient set {edit} where id = @Id";
                            cmd.Parameters.AddWithValue("@Id", id);



                            connection.Open();



                            int rowsAffected = cmd.ExecuteNonQuery();



                            connection.Close();



                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows were updated. Check the provided ID.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data to update. Please enter values in at least one TextBox.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid ID.");
            }
            dataGridView1.DataSource = ReadDataP();
        }


















        private void listM_Click(object sender, EventArgs e)
        {
            if (int.TryParse(mID.Text, out int id))
            {
                string connectionString = "Server=localhost;Database=project;Uid=root;Pwd=12345;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "select patient_id,episode,module from module where id = @Id";



                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);



                        connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MPatentID.Text = reader["patient_id"].ToString();
                            MEpsode.Text = reader["episode"].ToString();
                            Mmodule.Text = reader["module"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("No data found for the specified ID.");
                        }



                        reader.Close();
                        connection.Close();
                    }
                }
            }
        }

        private void List3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(ID.Text, out int id))
            {
                string connectionString = "Server=localhost;Database=project;Uid=root;Pwd=12345;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "select other_id, name, telephone, mobile, fax, other_telephone, email, sex, birth_date, process_number, postal_code, postal_area, locality, postal_code_id, address, town, postal_code_full, nif, sns from patient where id = @ID";



                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);



                        connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            Other_id.Text = reader["other_id"].ToString();
                            name.Text = reader["name"].ToString();
                            telephone.Text = reader["telephone"].ToString();
                            Moble.Text = reader["mobile"].ToString();
                            fax.Text = reader["fax"].ToString();
                            Other_telephone.Text = reader["other_telephone"].ToString();
                            email.Text = reader["email"].ToString();
                            sex.Text = reader["sex"].ToString();
                            BirthDate.Text = reader["birth_date"].ToString();
                            ProcessNumber.Text = reader["process_number"].ToString();
                            Postal_Code.Text = reader["postal_code"].ToString();
                            Postal_Area.Text = reader["postal_area"].ToString();
                            Locality.Text = reader["locality"].ToString();
                            PostalCode_Id.Text = reader["postal_code_id"].ToString();
                            Andress.Text = reader["address"].ToString();
                            town.Text = reader["town"].ToString();
                            PostalCode_Full.Text = reader["postal_code_Full"].ToString();
                            NIF.Text = reader["nif"].ToString();
                            SNS.Text = reader["sns"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No data found for the specified ID.");
                        }



                        reader.Close();
                        connection.Close();

                    }
                }
            }
        }

        private void EditM_Click(object sender, EventArgs e)
        {

            if (int.TryParse(mID.Text, out int id))
            {
                string connectionString = "Server=localhost;Database=project;Uid=root;Pwd=12345;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    using (MySqlCommand cmd = connection.CreateCommand())

                    {





                        cmd.CommandType = CommandType.Text;
                        string edit = "";
                        if (!string.IsNullOrEmpty(MPatentID.Text))
                        {
                            edit += "patient_id=@MPatentID, ";
                            cmd.Parameters.AddWithValue("@MPatentID", MPatentID.Text);
                        }
                        if (!string.IsNullOrEmpty(MEpsode.Text))
                        {
                            edit += "episode=@MEpsode, ";
                            cmd.Parameters.AddWithValue("@MEpsode", MEpsode.Text);
                        }
                        if (!string.IsNullOrEmpty(Mmodule.Text))
                        {
                            edit += "module=@Mmodule, ";
                            cmd.Parameters.AddWithValue("@Mmodule", Mmodule.Text);
                        }

                        if (!string.IsNullOrEmpty(edit))
                        {
                            edit = edit.TrimEnd(',', ' ');
                        }



                        if (!string.IsNullOrEmpty(edit))
                        {
                            cmd.CommandText = $"update module set {edit} where id = @Id";
                            cmd.Parameters.AddWithValue("@Id", id);



                            connection.Open();



                            int rowsAffected = cmd.ExecuteNonQuery();



                            connection.Close();



                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data updated successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No rows were updated. Check the provided ID.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No data to update. Please enter values in at least one TextBox.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a valid ID.");
            }
            dataGridView2.DataSource = dataM();
        }
    }
}

















