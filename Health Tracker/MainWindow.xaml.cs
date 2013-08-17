using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace AdventureWorksOrdersViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection myConnection = new SqlConnection("Data source=Juan-PC\\SQLEXPRESS; Initial Catalog=Healthy ; Integrated Security=True");
        public MainWindow()
        {
            InitializeComponent();

        }


        private void newUser(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Grid_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            Boolean clear = true;

            if (string.IsNullOrWhiteSpace(this.user.Text))
            {
                MessageBox.Show("Username can't be empty");
                this.user.Focus();
                clear = false;
                return;
            }
            if (string.IsNullOrWhiteSpace(this.pass.Password))
            {
                MessageBox.Show("Password can't be empty");
                this.pass.Focus();
                clear = false;
            }


            if (clear == true)
            {
                try
                {

                    this.myConnection.Open();
                    SqlCommand getAll = new SqlCommand("SELECT *  FROM users where  userName = '" + this.user.Text + "' AND userPass = '" + this.pass.Password + "'", myConnection);
                    SqlDataReader runit = getAll.ExecuteReader();

                    if (runit.Read() == true)
                    {
                        MessageBox.Show("Welcome " + this.user.Text);
                        this.Hide();
                        userWindow userw = new userWindow();
                        userw.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("False Username or Password");
                        this.user.Clear();
                        this.pass.Clear();
                        this.user.Focus();
                    }


                }
                catch (SqlException d)
                {
                    MessageBox.Show(d.ToString());


                }
                finally
                {
                    this.myConnection.Close();

                }
            }
           

        }

        private void closeIt(object sender, EventArgs e)
        {
            Application.Current.Shutdown();

        }




    }
}
