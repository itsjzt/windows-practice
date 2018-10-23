using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace MicroMusicPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void fetch_song()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";

            if (ofd.ShowDialog() == true)
            {
                mediaPlayer.Open(new Uri(ofd.FileName));
            }
        }

        private void play_audio(object sender, RoutedEventArgs e)
        {
            if (mediaPlayer.Source == null)
            {
                fetch_song();
            }
            mediaPlayer.Play();


            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Update_progressbar;
            timer.Start();
        }

        private void pause_audio(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }

        private void Update_progressbar(object sender, EventArgs e)
        {
            if (mediaPlayer.Source != null)
            {
                double getPercent = mediaPlayer.Position.TotalSeconds / mediaPlayer.NaturalDuration.TimeSpan.TotalSeconds * 100;
                musicProgess.Value = getPercent;
            }
        }
    }
}
