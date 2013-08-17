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
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace AdventureWorksOrdersViewer
{
    /// <summary>
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {
        public CreateUser()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            MessageBox.Show(today.ToShortDateString());
            this.dpBirth.DisplayDateEnd = DateTime.Today;
        }

        private void closeIt(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void closeIt(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.closeIt();
        }
        private void closeIt()
        {
            Application.Current.Shutdown();

        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {

            bool clear = true;
           

            

            if (string.IsNullOrWhiteSpace(this.txtName.Text) || !Regex.IsMatch(this.txtName.Text, @"^[a-zA-Z]+$")|| this.txtName.Text.Length>50)
            {
                MessageBox.Show("Name is a required Field , and remember names have  only chars ;)");
                clear = false;
                this.txtUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtEmail.Text) || !Regex.IsMatch(this.txtEmail.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$") || this.txtEmail.Text.Length > 50)
            {
                MessageBox.Show("You must provide a   valid E-Mail Adress to proceed");
                this.txtEmail.Focus();
                clear = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtUser.Text) || !Regex.IsMatch(this.txtUser.Text, @"^[a-zA-Z0-9]+$") || this.txtUser.Text.Length > 50)
            {
                MessageBox.Show("You must provide a valid Username ( Only Numbers and Chars are accepted)");
                this.txtUser.Focus();
                clear = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(this.txtPass.Password) || !Regex.IsMatch(this.txtPass.Password, @"^[a-zA-Z0-9]+$") || this.txtPass.Password.Length > 50)
            {
                MessageBox.Show("You must provide a valid Password ( Only Numbers and Chars are accepted)");
                this.txtPass.Focus();
                clear = false;
                return;
            }
            
            if (this.cbGender.SelectedIndex==0)
            {
                MessageBox.Show("You must provide your Gender");
                this.cbGender.Focus();
                clear = false;
                return;
            }

            

            

            
           



        }
       
    }
}
