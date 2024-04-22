using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfAppGridspelletje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // For timer
        DispatcherTimer timer;
        int time;
        int timeSeconds;
        int speed = 500;

        // For screenposition of button
        Random rnd = new Random();
        int horPos = 0;
        int vertPos = 0;

        bool partyMode = false;
        bool clicked = false;

        public MainWindow()
        {
            InitializeComponent();

            // Create timer
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Stop if timer runs out
            if (timeSeconds == 0)
            {
                // Ends game as failed
                clicked = false;
                EndGame();
            }
            else
            {
                // countdown timer
                time -= speed;

                // time takes one second to get to zero, when it hits zero decrease second counter and reset timer counter
                if (time <= 0)
                {
                    timeSeconds--;
                    tbTimer.Text = timeSeconds.ToString();

                    // Remove excess time
                    time = 1000 + time;
                }

                // Place button on random position relative to the size of the grid
                horPos = rnd.Next(0, Convert.ToInt32(gameGrid.ActualWidth) - 50);
                vertPos = rnd.Next(0, Convert.ToInt32(gameGrid.ActualHeight) - 50);
                btnCatch.Margin = new Thickness(horPos,vertPos,0,0);

                // Decrease window when partymode is active
                if (partyMode)
                {
                    mainWindow.Width -= 15;
                    mainWindow.Height -= 10;
                }
            }
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            // Enable catchbutton and disable option buttons
            btnCatch.IsEnabled = true;
            btnStartGame.IsEnabled = false;
            options.IsEnabled = false;

            // Random position to start
            horPos = rnd.Next(0, Convert.ToInt32(gameGrid.ActualWidth) - 50);
            vertPos = rnd.Next(0, Convert.ToInt32(gameGrid.ActualHeight) - 50);
            btnCatch.Margin = new Thickness(horPos, vertPos, 0, 0);

            // Reset counters
            time = 1000;
            timeSeconds = 10;
            timer.Interval = TimeSpan.FromMilliseconds(speed);
            timer.Start();

            // Reset timer
            tbTimer.Text = timeSeconds.ToString();
        }

        public void EndGame()
        {
            // Stop the timer
            timer.Stop();

            // Disable catchbutton and enable option buttons
            btnCatch.IsEnabled = false;
            btnStartGame.IsEnabled = true;
            options.IsEnabled = true;

            // Reset window when partymode active
            if (partyMode)
            {
                mainWindow.Width = 800;
                mainWindow.Height = 450;
            }

            // When won
            if (clicked)
            {
                tbTimer.Text = "Gefeliciteerd :)";
                VictoryWindow win2 = new VictoryWindow(timeSeconds);
                win2.Show();
            }
            // When failed
            else
            {
                tbTimer.Text = "Gefaald :(";
            }
        }

        private void ClickButton(object sender, RoutedEventArgs e)
        {
            // When button has been catched
            clicked = true;
            EndGame();
        }

        private void ButtonFaster(object sender, RoutedEventArgs e)
        {
            // Increase how fast timer ticks
            speed -= 100;
            tbSpeed.Text = "Speed level: " + Convert.ToString(11 - speed / 100);

            // Check for min/max
            if (speed == 100)
            {
                btnFaster.IsEnabled = false;
            }

            else if (speed != 1000)
            {
                btnSlower.IsEnabled = true;
            }
        }

        private void ButtonSlower(object sender, RoutedEventArgs e)
        {
            // Decrease how fast timer ticks
            speed += 100;
            tbSpeed.Text = "Speed level: " + Convert.ToString(11 - speed / 100);

            // Check for min/max
            if (speed == 1000)
            {
                btnSlower.IsEnabled = false;
            }

            else if (speed != 100)
            {
                btnFaster.IsEnabled = true;
            }
        }

        private void ButtonParty(object sender, RoutedEventArgs e)
        {
            // Enable/disable party mode (screen shrink)
            if (partyMode)
            {
                partyMode = false;
                btnParty.Background = Brushes.Red;
            }
            else
            {
                partyMode = true;
                btnParty.Background = Brushes.Green;
            }
        }

        private void ChangeCharacter(object sender, SelectionChangedEventArgs e)
        {
            // Change image on button
            switch (cmbImage.SelectedIndex)
            {
                case 0:
                    btnImage.Source = new BitmapImage(new Uri(@"img/WOUD.jpg", UriKind.Relative));
                    break;
                case 1:
                    btnImage.Source = new BitmapImage(new Uri(@"img/Dikzakje.jpg", UriKind.Relative));
                    break;
                case 2:
                    btnImage.Source = new BitmapImage(new Uri(@"img/rat.gif", UriKind.Relative));
                    break;
            }
        }
    }
}
