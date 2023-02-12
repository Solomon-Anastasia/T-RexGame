using System.Collections.Generic;
using System.Windows.Forms;

namespace T_RexGame
{
    public partial class LogInForm : Form
    {
        // Metoda e intitializeaza componentele formularului
        public LogInForm()
        {
            InitializeComponent();
        }

        // Metoda ce initializeaza formularul de inregistrare
        private void signUpButton_Click(object sender, System.EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var signUpForm = new SignUpForm();

            // Inchidem formularul curent, deschizand formularul de inregistrare
            signUpForm.Closed += (s, args) => this.Close();
            signUpForm.Show();
        }

        // Metoda ce initializeaza formularul de principal de joaca
        private void logInButton_Click(object sender, System.EventArgs e)
        {
            List<string> passwords = DataAccess.GetPassword(passwordTextBox.Text);
            List<string> usernames = DataAccess.GetUsername(userNameTextBox.Text);
            bool isPresent = false;

            // Verificam daca exista utilizatorul introdus
            if (passwords.Contains(passwordTextBox.Text)) {
                if (usernames.Contains(userNameTextBox.Text)) {
                    isPresent = true;
                }
            }

            if (isPresent) {
                DataAccess.CreateView(userNameTextBox.Text);

                this.Hide(); // Ascundem formularul curent

                // Cream o variabila de tip form
                var TRexForm = new TRexForm();

                // Inchidem formularul curent, deschizand formularul de joaca
                TRexForm.Closed += (s, args) => this.Close();
                TRexForm.Show();
            } else { // Daca nu s-a gasit un astfel de utilizator, ne intoarcem la pagina initiala
                MessageBox.Show("Incorrect username or password");
                this.Hide(); // Ascundem formularul curent

                // Cream o variabila de tip form
                var tetrisForm = new WelcomeForm();

                // Inchidem formularul curent, deschizand formularul de salutare
                tetrisForm.Closed += (s, args) => this.Close();
                tetrisForm.Show();
            }
        }
    }
}
