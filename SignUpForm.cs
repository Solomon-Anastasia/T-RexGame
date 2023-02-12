using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace T_RexGame
{
    public partial class SignUpForm : Form
    {
        // Metoda e intitializeaza componentele formularului
        public SignUpForm()
        {
            InitializeComponent();
        }

        // Metoda ce initializeaza formularul de salutare
        private void createAccountButton_Click(object sender, EventArgs e)
        {
            // Verificam daca parola a fost introdusa de 2 ori corect
            if (passwordTextBox.Text != repeatPasswordTextBox.Text) {
                MessageBox.Show("Incorrect password!");
                passwordTextBox.Text = "";
                repeatPasswordTextBox.Text = "";
            } else {
                List<string> users = DataAccess.GetUsername(usernameTextBox.Text);
                string username = usernameTextBox.Text;
                bool isPresent = false;

                // Verificam daca username deja exista
                for (int i = 0; i < users.Count; i++) {
                    if(users.Contains(username)) {
                        isPresent = true;
                        break;
                    }
                }

                // Daca aceast utilizator exista, afisam un mesaj sugestiv
                if (isPresent) {
                    MessageBox.Show("Username already exists!");
                    this.Hide(); // Ascundem formularul curent

                    // Cream o variabila de tip form
                    var welcomeForm1 = new WelcomeForm();

                    // Inchidem formularul curent, deschizand formularul de salutare
                    welcomeForm1.Closed += (s, args) => this.Close();
                    welcomeForm1.Show();
                } else { // Daca nu, in adaugam in baza de date
                    DataAccess.InsertUser(nameTextBox.Text, surnameTextBox.Text, emailTextBox.Text, usernameTextBox.Text, passwordTextBox.Text);
                    this.Hide(); // Ascundem formularul curent

                    // Cream o variabila de tip form
                    var welcomeForm = new WelcomeForm();

                    // Inchidem formularul curent, deschizand formularul de salutare
                    welcomeForm.Closed += (s, args) => this.Close();
                    welcomeForm.Show();
                }
            }
        }

        // Metoda ce initializeaza formularul de salutare
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var welcomeForm = new WelcomeForm();

            // Inchidem formularul curent, deschizand formularul de salutare
            welcomeForm.Closed += (s, args) => this.Close();
            welcomeForm.Show();
        }
    }
}
