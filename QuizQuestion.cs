using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Threading;
using CyberSecurityBot.Models;
using CyberSecurityBot.Services;

namespace CyberSecurityBot
{
    public partial class LoginWindow : Window
    {
        private UserManager manager;

        private int failedAttempts = 0;

        private DateTime lockoutEnd;

        private DispatcherTimer timer;

        public LoginWindow()
        {
            InitializeComponent();

            manager =
                new UserManager();
        }

        private bool ValidatePassword(
            string password)
        {
            if (password.Length < 8 ||
                password.Length > 13)
            {
                return false;
            }

            bool hasUpper =
                Regex.IsMatch(password, "[A-Z]");

            bool hasNumber =
                Regex.IsMatch(password, "[0-9]");

            bool hasSpecial =
                Regex.IsMatch(password, @"[\W_]");

            return hasUpper &&
                   hasNumber &&
                   hasSpecial;
        }

        private void btnLogin_Click(
            object sender,
            RoutedEventArgs e)
        {
            if (DateTime.Now < lockoutEnd)
            {
                return;
            }

            string username =
                txtUsername.Text.Trim();

            string password =
                txtPassword.Password;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Enter username.");

                return;
            }

            UserProfile user =
                manager.GetUser(username);

            if (user == null)
            {
                if (!ValidatePassword(password))
                {
                    MessageBox.Show(
                        "New users must create a strong password.");

                    return;
                }

                user =
                    new UserProfile
                    {
                        Username = username,
                        Password = password,
                        FavouriteTopic = "",
                        SecurityScore = 0
                    };

                manager.SaveUser(user);

                MessageBox.Show(
                    "New account created successfully.");
            }
            else
            {
                if (user.Password != password)
                {
                    failedAttempts++;

                    MessageBox.Show(
                        "Incorrect password.");

                    if (failedAttempts >= 5)
                    {
                        StartCooldown();
                    }

                    return;
                }

                failedAttempts = 0;
            }

            MainWindow main =
                new MainWindow(user);

            main.Show();

            Close();
        }

        private void StartCooldown()
        {
            lockoutEnd =
                DateTime.Now.AddMinutes(5);

            btnLogin.IsEnabled = false;

            timer =
                new DispatcherTimer();

            timer.Interval =
                TimeSpan.FromSeconds(1);

            timer.Tick += Timer_Tick;

            timer.Start();
        }

        private void Timer_Tick(
            object sender,
            EventArgs e)
        {
            TimeSpan remaining =
                lockoutEnd - DateTime.Now;

            if (remaining.TotalSeconds <= 0)
            {
                timer.Stop();

                btnLogin.IsEnabled = true;

                failedAttempts = 0;

                txtCooldown.Text = "";
            }
            else
            {
                txtCooldown.Text =
                    $"Locked. Try again in {remaining:mm\\:ss}";
            }
        }
    }
}