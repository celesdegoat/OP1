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

namespace OP1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double randomNumber1;
        double randomNumber2;
        int playerLevel;
        int getalVoorOperator;
        string operatorForSum;
        double outcome;
        double roundedOutcome;
        string answerFromUser;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wanneer het antwoord van een som meer dan 2 decimalen getallen bevat, rond je dit antwoord af op 2 decimalen.");
            tbAntwoord.IsEnabled = false;
            btnCheckBerekening.IsEnabled = false;
        }

        private void btnGenereerSom_Click(object sender, RoutedEventArgs e)
        {
            tbAntwoord.IsEnabled = true;
            btnCheckBerekening.IsEnabled = true;
            btnGenereerSom.IsEnabled = false;
            playerLevel++;
            tbNiveauSpeler.Text = $"Huidig niveau: {playerLevel}";
            var random = new Random();
            getalVoorOperator = random.Next(1, 5);
            switch (playerLevel)
            {
                case 1:
                    {
                        randomNumber1 = random.Next(0, 21);
                        randomNumber2 = random.Next(0, 21);
                        switch (getalVoorOperator)
                        {
                            case 1:
                                {
                                    operatorForSum = "+";
                                    outcome = randomNumber1 + randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 2:
                                {
                                    operatorForSum = "-";
                                    outcome = randomNumber1 - randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 3:
                                {
                                    operatorForSum = "*";
                                    outcome = randomNumber1 * randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 4:
                                {
                                    operatorForSum = "/";
                                    outcome = randomNumber1 / randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                        }
                        tbSom.Text = randomNumber1.ToString() + operatorForSum + randomNumber2.ToString();
                        break;
                    }
                case 2:
                    {
                        randomNumber1 = random.Next(20, 41);
                        randomNumber2 = random.Next(20, 41);
                        switch (getalVoorOperator)
                        {
                            case 1:
                                {
                                    operatorForSum = "+";
                                    outcome = randomNumber1 + randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 2:
                                {
                                    operatorForSum = "-";
                                    outcome = randomNumber1 - randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 3:
                                {
                                    operatorForSum = "*";
                                    outcome = randomNumber1 * randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 4:
                                {
                                    operatorForSum = "/";
                                    outcome = randomNumber1 / randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                        }
                        tbSom.Text = randomNumber1.ToString() + operatorForSum + randomNumber2.ToString();
                        break;
                    }
                case 3:
                    {
                        randomNumber1 = random.Next(40, 61);
                        randomNumber2 = random.Next(40, 61);
                        switch (getalVoorOperator)
                        {
                            case 1:
                                {
                                    operatorForSum = "+";
                                    outcome = randomNumber1 + randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 2:
                                {
                                    operatorForSum = "-";
                                    outcome = randomNumber1 - randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 3:
                                {
                                    operatorForSum = "*";
                                    outcome = randomNumber1 * randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 4:
                                {
                                    operatorForSum = "/";
                                    outcome = randomNumber1 / randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                        }
                        tbSom.Text = randomNumber1.ToString() + operatorForSum + randomNumber2.ToString();
                        break;
                    }
                case 4:
                    {
                        randomNumber1 = random.Next(60, 81);
                        randomNumber2 = random.Next(60, 81);
                        switch (getalVoorOperator)
                        {
                            case 1:
                                {
                                    operatorForSum = "+";
                                    outcome = randomNumber1 + randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 2:
                                {
                                    operatorForSum = "-";
                                    outcome = randomNumber1 - randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 3:
                                {
                                    operatorForSum = "*";
                                    outcome = randomNumber1 * randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 4:
                                {
                                    operatorForSum = "/";
                                    outcome = randomNumber1 / randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                        }
                        tbSom.Text = randomNumber1.ToString() + operatorForSum + randomNumber2.ToString();
                        break;
                    }
                case 5:
                    {
                        randomNumber1 = random.Next(80, 101);
                        randomNumber2 = random.Next(80, 101);
                        switch (getalVoorOperator)
                        {
                            case 1:
                                {
                                    operatorForSum = "+";
                                    outcome = randomNumber1 + randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 2:
                                {
                                    operatorForSum = "-";
                                    outcome = randomNumber1 - randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 3:
                                {
                                    operatorForSum = "*";
                                    outcome = randomNumber1 * randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                            case 4:
                                {
                                    operatorForSum = "/";
                                    outcome = randomNumber1 / randomNumber2;
                                    roundedOutcome = Math.Round(outcome, 2);
                                    break;
                                }
                        }
                        tbSom.Text = randomNumber1.ToString() + operatorForSum + randomNumber2.ToString();
                        break;
                    }
            }
        }

        private void btnCheckBerekening_Click(object sender, RoutedEventArgs e)
        {
            answerFromUser = tbAntwoord.Text;
            if (double.TryParse(answerFromUser, out double givenAnswer))
            {
                if (givenAnswer == roundedOutcome)
                {
                    MessageBox.Show("Het gegeven antwoord is goed!");
                    btnGenereerSom.IsEnabled = true;
                    tbSom.Text = "";
                    tbAntwoord.Text = "";
                    tbAntwoord.IsEnabled = false;
                    btnCheckBerekening.IsEnabled = false;
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
            else if (answerFromUser == "")
            {
                MessageBox.Show("Er is geen antwoord gegeven. Vul een antwoord in.");
            }
            else
            {
                MessageBox.Show("Er is een fout opgetreden: Het antwoord mag alleen getallen bevatten. Het gegeven antwoord voldoet niet aan deze voorwaarde.");
            }
        }
    }
}