using System.Windows;
using System.Windows.Documents;
using CyberSecurityBot.Models;
using CyberSecurityBot.Services;

namespace CyberSecurityBot
{
    public partial class MainWindow : Window
    {
        private UserProfile currentUser;


    private UserManager manager;

        private ChatBotEngine bot;

        private VoiceManager voice;

        private ActivityLogService activityLog;

        private NLPService nlpService;

        public MainWindow(UserProfile user)
        {
            InitializeComponent();

            currentUser = user;

            manager = new UserManager();

            bot = new ChatBotEngine();

            voice = new VoiceManager();

            activityLog = new ActivityLogService();

            nlpService = new NLPService();

            string welcome =
    $"Hi {currentUser.Username}! Welcome to the Cyber Security Awareness Chatbot.\n\n" +
    "You can ask me about:\n" +
    "• Phishing\n" +
    "• Password Security\n" +
    "• Malware\n" +
    "• Privacy\n" +
    "• Online Scams\n\n" +
    "What would you like to learn about today?";

            AddMessage("Bot", welcome);

            voice.Speak(welcome);

            if (!string.IsNullOrEmpty(currentUser.FavouriteTopic))
            {
                string memoryMessage =
                    $"Welcome back {currentUser.Username}! " +
                    $"Last time you were interested in {currentUser.FavouriteTopic}. " +
                    $"Would you like to learn more about it today?";

                AddMessage("Bot", memoryMessage);

                voice.Speak(memoryMessage);
            }

            securityBar.Value =
                currentUser.SecurityScore;

            UpdateLevelText(
                currentUser.SecurityScore);
        }

        private void btnSend_Click(
            object sender,
            RoutedEventArgs e)
        {
            string userMessage =
                txtMessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(userMessage))
            {
                return;
            }

            AddMessage(
                "You",
                userMessage);

            string intent =
                nlpService.DetectIntent(userMessage);

            switch (intent)
            {
                case "TASK":

                    AddMessage(
                        "Bot",
                        "I detected a task-related request. Please use the Task Manager.");

                    activityLog.AddLog(
                        "Task command recognised");

                    break;

                case "QUIZ":

                    AddMessage(
                        "Bot",
                        "Opening Cyber Security Quiz...");

                    activityLog.AddLog(
                        "Quiz opened");

                    QuizWindow quiz =
                        new QuizWindow();

                    quiz.ShowDialog();

                    break;

                case "LOG":

                    btnActivity_Click(
                        null,
                        null);

                    break;

                default:

                    string response =
                        bot.GetResponse(userMessage);

                    AddMessage(
                        "Bot",
                        response);

                    voice.Speak(response);

                    break;
            }

            UpdateUserProgress(
                userMessage);

            txtMessage.Clear();

            txtMessage.Focus();
        }

        private void btnTasks_Click(
            object sender,
            RoutedEventArgs e)
        {
            activityLog.AddLog(
                "Task Manager opened");

            TaskWindow taskWindow =
                new TaskWindow();

            taskWindow.ShowDialog();
        }

        private void btnQuiz_Click(
            object sender,
            RoutedEventArgs e)
        {
            activityLog.AddLog(
                "Quiz started");

            QuizWindow quizWindow =
                new QuizWindow();

            quizWindow.ShowDialog();
        }

        private void btnActivity_Click(
            object sender,
            RoutedEventArgs e)
        {
            var logs =
                activityLog.GetRecentLogs();

            string output =
                "Recent Activity:\n\n";

            foreach (var log in logs)
            {
                output +=
                    $"{log.TimeStamp:g} - {log.Action}\n";
            }

            MessageBox.Show(
                output,
                "Activity Log");
        }

        private void UpdateUserProgress(string message)
{
    currentUser.QuestionsAsked++;

    currentUser.SecurityScore =
        currentUser.QuestionsAsked * 5;

    if (currentUser.SecurityScore > 100)
    {
        currentUser.SecurityScore = 100;
    }

    securityBar.Value =
        currentUser.SecurityScore;

    UpdateLevelText(
        currentUser.SecurityScore);

    manager.SaveUser(
        currentUser);
}

        private void UpdateLevelText(
            int score)
        {
            if (score < 40)
            {
                txtLevel.Text =
                    "Beginner";
            }
            else if (score < 60)
            {
                txtLevel.Text =
                    "Learning";
            }
            else if (score < 80)
            {
                txtLevel.Text =
                    "Improving";
            }
            else if (score < 100)
            {
                txtLevel.Text =
                    "Advanced";
            }
            else
            {
                txtLevel.Text =
                    "Cyber Expert";
            }
        }

        private void btnLogout_Click(
            object sender,
            RoutedEventArgs e)
        {
            string goodbye =
                $"Goodbye {currentUser.Username}! " +
                $"Thank you for using the Cyber Security Awareness Chatbot. " +
                $"Stay safe online and see you next time!";

            MessageBox.Show(
                goodbye,
                "Logout",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

            voice.Speak(goodbye);

            LoginWindow login =
                new LoginWindow();

            login.Show();

            this.Close();
        }

        private void AddMessage(
            string sender,
            string message)
        {
            Paragraph paragraph =
                new Paragraph();

            paragraph.Inlines.Add(
                new Run($"{sender}: {message}")
            );

            ChatBox.Document.Blocks.Add(
                paragraph);

            ChatBox.ScrollToEnd();
        }
    }


}
