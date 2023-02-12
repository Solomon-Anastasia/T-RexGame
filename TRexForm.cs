using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Windows.Forms;

namespace T_RexGame
{
    public partial class TRexForm : Form
    {
        // Variabile globale
        bool jumping = false; // Daca sare
        int jumpSpeed; // Viteza cu care sare
        int force = 12; // Limita fortei
        int score = 0; // Scorul
        int obstacleSpeed = 10; // Viteza obstacolului
        Random rand = new Random();
        int position; // Pozitia
        bool isGameOver = false; // Daca ai pierdut

        // Variabile ce vor duce evidenta timer-ului
        System.Timers.Timer t = new System.Timers.Timer();
        int sec;
        int min;
        int h;

        // Obiectul ce reprezinta utilizatorul curent
        List<User> user = DataAccess.GetDataFromView();

        // Metoda ce initializeaza componentele
        public TRexForm()
        {
            InitializeComponent();
            ResetGame(); // Resetam jocul
        }

        // Metoda ce va initializa principalele functionalitati ale jocului
        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            tRex.Top += jumpSpeed; // Atribuim T-Rex viteza
            scoreLabel.Text = "Score: " + score; // Afisam scorul

            // Simulam saritura lui T-Rex
            if (jumping == true && force < 0) {
                jumping = false;
            }
            
            if (jumping == true) {
                jumpSpeed = -12;
                force -= 1;
            } else {
                jumpSpeed = 12;
            }

            if (tRex.Top > 284 && jumping == false) {
                force = 12;
                tRex.Top = 285;
                jumpSpeed = 0;
            }

            // Simulam miscarea obstaculelor
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    // Daca am trecut cu succes peste obstacol, incrementam scorul
                    if (x.Left < -100)  {
                        x.Left = this.ClientSize.Width + rand.Next(200, 500) + (x.Width * 15);
                        score++;
                    }

                    // Verificam daca T-Rex se intersecteaza cu un obstacol
                    if (tRex.Bounds.IntersectsWith(x.Bounds)) {
                        t.Stop();
                        gameTimer.Stop(); // Oprim timer-ul
                        tRex.Image = Properties.Resources.dead; // Afisam T-Rex ca mort
                        scoreLabel.Text += "  Press R to restart the game!"; // Afisam un mesaj sugestiv
                        isGameOver = true; // Setam ca jocul terminat

                        // Determinam scorul cel mai bun, impreuna cu timpul sau
                        if (score > Int32.Parse(bestScoreLabel.Text))
                        {
                            bestScoreLabel.Text = score.ToString();
                            user.First().Score = score;

                            if (h >= 0 && h <= 9) {
                                user.First().Hours = "0" + h.ToString();
                            } else {
                                user.First().Hours = h.ToString();
                            }

                            if (min >= 0 && min <= 9) {
                                user.First().Minutes = "0" + min.ToString();
                            } else {
                                user.First().Minutes = min.ToString();
                            }

                            if (sec >= 0 && sec <= 9) {
                                user.First().Seconds = "0" + sec.ToString();
                            } else {
                                user.First().Seconds = sec.ToString();
                            }

                            bestTimeLabel.Text = user.First().Hours + ":" +
                                                 user.First().Minutes + ":" +
                                                 user.First().Seconds;
                            DataAccess.UpdateCurentUser(user.First().Username, user.First().Score, user.First().Hours, user.First().Minutes, user.First().Seconds);
                        }
                    }
                }
            }

            // Daca scorul este mai mare ca 10, marim viteza
            if (score > 10) {
                obstacleSpeed = 15;
            }
        }

        // Metoda ce va misca T-Rex in sus, atunci cand va fi tastat pe space
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }
        }

        // Metoda ce va detecta daca T-Rex a sarit
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }

            // Daca tastam R, jocul se va reseta
            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                ResetGame();
            }
        }

        // Metoda ce reseteaza componentele jocului
        private void ResetGame()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            scoreLabel.Text = "Score: " + score;
            tRex.Image = Properties.Resources.running;
            isGameOver = false;
            tRex.Top = 285;

            // Resetarea timer-ului
            t.Stop();
            timerLabel.Text = "00:00:00";
            sec = 0;
            min = 0;
            h = 0;
            t.Start();

            // Generam random pozitia pentru cactusi
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500, 800) + (x.Width * 10);

                    x.Left = position;
                }
            }
            gameTimer.Start(); // Incepem timer-ul din nou
        }

        // Metoda ce va initializa timer-ul, atunci cand se va deschide aplicatia
        private void TRexForm_Load(object sender, EventArgs e)
        {
            // Aplicarea timer-ului
            t = new System.Timers.Timer();
            t.Interval = 1000; // 1s
            t.Elapsed += OnTimeEvent;

            // Inceperea timer-ului
            t.Start();

            usernameLabel.Text = "Hello " + user.First().Username;
            bestScoreLabel.Text = user.First().Score.ToString();

            bestTimeLabel.Text = user.First().Hours + ":" + user.First().Minutes + ":" + user.First().Seconds;
        }

        // Metoda ce va converti sec in min, min in h
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() => {
                sec++;

                if (sec == 60) {
                    sec = 0;
                    min += 1;
                }
                if (min == 60) {
                    min = 0;
                    h += 1;
                }

                // Afisarea timpului in aplicatie
                timerLabel.Text = string.Format("{0}:{1}:{2}",
                                  h.ToString().PadLeft(2, '0'),
                                  min.ToString().PadLeft(2, '0'),
                                  sec.ToString().PadLeft(2, '0'));
            }));
        }
    }
}
