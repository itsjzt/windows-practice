using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace soundBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void play_beep(object sender, RoutedEventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(@"C:\Users\jztsaurabh\Downloads\sounds\throat.wav");
            snd.Play();
        }

        private void play_sound2(object sender, RoutedEventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(@"C:\Users\jztsaurabh\Downloads\sounds\alarm_beep.wav");
            snd.Play();
        }

        private void play_sound3(object sender, RoutedEventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(@"C:\Users\jztsaurabh\Downloads\sounds\baby_cry.wav");
            snd.Play();
        }

        private void play_sound5(object sender, RoutedEventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(@"C:\Users\jztsaurabh\Downloads\sounds\clap.wav");
            snd.Play();
        }

        private void play_sound(object sender, RoutedEventArgs e)
        {
            SoundPlayer snd = new SoundPlayer(@"C:\Users\jztsaurabh\Downloads\sounds\bad_disk.wav");
            snd.Play();
        }
    }
}
