using System;
using System.Windows;

namespace OP1
{
    public partial class MainWindow : Window
    {
        double randomNumber1;
        double randomNumber2;
        int playerLevel;
        string operatorForSum;
        double outcome;
        double roundedOutcome;
        Random random;

        public MainWindow()
        {
            InitializeComponent();
            random = new Random();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wanneer het antwoord van een som meer dan 2 decimalen getallen bevat, rond je dit antwoord af op 2 decimalen.");
            ResetInputControls();
        }

        private void btnGenereerSom_Click(object sender, RoutedEventArgs e)
        {
            EnableInputControls();
            playerLevel++;
            tbNiveauSpeler.Text = $"Huidig niveau: {playerLevel}";

            GenerateRandomNumbers(playerLevel);
            operatorForSum = GenerateRandomOperator();
            outcome = CalculateOutcome(randomNumber1, randomNumber2, operatorForSum);
            roundedOutcome = Math.Round(outcome, 2);

            tbSom.Text = $"{randomNumber1} {operatorForSum} {randomNumber2}";
        }

        private void btnCheckBerekening_Click(object sender, RoutedEventArgs e)
        {
            string answerFromUser = tbAntwoord.Text;
            if (double.TryParse(answerFromUser, out double givenAnswer))
            {
                if (givenAnswer == roundedOutcome)
                {
                    MessageBox.Show("Het gegeven antwoord is goed!");
                    ResetInputControls();
                    if (playerLevel == 5)
                    {
                        MessageBox.Show("Je hebt alle 5 niveaus gehaald. Gefeliciteerd!");
                        playerLevel = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Het gegeven antwoord is fout. Probeer het opnieuw.");
                    tbAntwoord.Text = "";
                }
            }
            else
            {
                MessageBox.Show(string.IsNullOrWhiteSpace(answerFromUser) ?
                    "Er is geen antwoord gegeven. Vul een antwoord in." :
                    "Er is een fout opgetreden: Het antwoord mag alleen getallen bevatten. Het gegeven antwoord voldoet niet aan deze voorwaarde.");
            }
        }

        private void GenerateRandomNumbers(int level)
        {
            int min = (level - 1) * 20;
            int max = level * 20 + 1;
            randomNumber1 = random.Next(min, max);
            randomNumber2 = random.Next(min, max);
        }

        private string GenerateRandomOperator()
        {
            switch (random.Next(1, 5))
            {
                case 1: return "+";
                case 2: return "-";
                case 3: return "*";
                case 4: return "/";
                default: throw new InvalidOperationException("Unexpected operator value");
            }
        }

        private double CalculateOutcome(double num1, double num2, string op)
        {
            return op switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num1 / num2,
                _ => throw new InvalidOperationException("Unexpected operator value")
            };
        }

        private void EnableInputControls()
        {
            tbAntwoord.IsEnabled = true;
            btnCheckBerekening.IsEnabled = true;
            btnGenereerSom.IsEnabled = false;
        }

        private void ResetInputControls()
        {
            tbAntwoord.IsEnabled = false;
            btnCheckBerekening.IsEnabled = false;
            btnGenereerSom.IsEnabled = true;
            tbSom.Text = "";
            tbAntwoord.Text = "";
        }
    }
}
