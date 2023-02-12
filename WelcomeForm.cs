using System;
using System.Windows.Forms;

namespace T_RexGame
{
    public partial class WelcomeForm : Form
    {
        // Metoda e intitializeaza componentele formularului
        public WelcomeForm()
        {
            InitializeComponent();
        }

        // Metoda ce initializeaza formularul de logare
        private void log_InButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var logInForm = new LogInForm();

            // Inchidem formularul curent, deschizand formularul de logare
            logInForm.Closed += (s, args) => this.Close();
            logInForm.Show();
        }

        // Metoda ce initializeaza formularul de inregistrare
        private void sign_UpButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ascundem formularul curent

            // Cream o variabila de tip form
            var signUpForm = new SignUpForm();

            // Inchidem formularul curent, deschizand formularul de inregistrare
            signUpForm.Closed += (s, args) => this.Close();
            signUpForm.Show();
        }
    }
}
