
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Alfavit.xaml
    /// </summary>
    public partial class Alfavit : Page
    {
        public static string MyName { get; set; }
        public Alfavit()
        {
            InitializeComponent();
            this.TextBlockName.Text ="Твое имя: " + MyName;
        }

        //Буква А

        private void imgA_MouseEnter(object sender, MouseEventArgs e)
        {
           btn1A.Visibility = Visibility.Visible;
           btn2A.Visibility = Visibility.Visible;
           btn3A.Visibility = Visibility.Visible;
           imgA.Opacity = 0.1;
           
        }

        private void imgA_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1A.Visibility = Visibility.Hidden;
            btn2A.Visibility = Visibility.Hidden;
            btn3A.Visibility = Visibility.Hidden;
            imgA.Opacity = 1;
        } 

        private void btn1A_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1A.Visibility = Visibility.Visible;
            btn2A.Visibility = Visibility.Visible;
            btn3A.Visibility = Visibility.Visible;
            imgA.Opacity = 0.1;
        }

        private void btn1A_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1A.Visibility = Visibility.Hidden;
            btn2A.Visibility = Visibility.Hidden;
            btn3A.Visibility = Visibility.Hidden;
            imgA.Opacity = 1;
        }

        private void btn2A_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1A.Visibility = Visibility.Visible;
            btn2A.Visibility = Visibility.Visible;
            btn3A.Visibility = Visibility.Visible;
            imgA.Opacity = 0.1;
        }

        private void btn2A_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1A.Visibility = Visibility.Hidden;
            btn2A.Visibility = Visibility.Hidden;
            btn3A.Visibility = Visibility.Hidden;
            imgA.Opacity = 1;
        }

        private void btn3A_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1A.Visibility = Visibility.Visible;
            btn2A.Visibility = Visibility.Visible;
            btn3A.Visibility = Visibility.Visible;
            imgA.Opacity = 0.1;
        }

        private void btn3A_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1A.Visibility = Visibility.Hidden;
            btn2A.Visibility = Visibility.Hidden;
            btn3A.Visibility = Visibility.Hidden;
            imgA.Opacity = 1;
        }

        private void btn2A_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/Aa.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Б

        private void imgB_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1B.Visibility = Visibility.Visible;
            btn2B.Visibility = Visibility.Visible;
            btn3B.Visibility = Visibility.Visible;
            imgB.Opacity = 0.1;

        }

        private void imgB_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1B.Visibility = Visibility.Hidden;
            btn2B.Visibility = Visibility.Hidden;
            btn3B.Visibility = Visibility.Hidden;
            imgB.Opacity = 1;
        }

        private void btn1B_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1B.Visibility = Visibility.Visible;
            btn2B.Visibility = Visibility.Visible;
            btn3B.Visibility = Visibility.Visible;
            imgB.Opacity = 0.1;
        }

        private void btn1B_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1B.Visibility = Visibility.Hidden;
            btn2B.Visibility = Visibility.Hidden;
            btn3B.Visibility = Visibility.Hidden;
            imgB.Opacity = 1;
        }

        private void btn2B_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1B.Visibility = Visibility.Visible;
            btn2B.Visibility = Visibility.Visible;
            btn3B.Visibility = Visibility.Visible;
            imgB.Opacity = 0.1;
        }

        private void btn2B_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1B.Visibility = Visibility.Hidden;
            btn2B.Visibility = Visibility.Hidden;
            btn3B.Visibility = Visibility.Hidden;
            imgB.Opacity = 1;
        }

        private void btn3B_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1B.Visibility = Visibility.Visible;
            btn2B.Visibility = Visibility.Visible;
            btn3B.Visibility = Visibility.Visible;
            imgB.Opacity = 0.1;
        }

        private void btn3B_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1B.Visibility = Visibility.Hidden;
            btn2B.Visibility = Visibility.Hidden;
            btn3B.Visibility = Visibility.Hidden;
            imgB.Opacity = 1;
        }

        private void btn2B_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/B.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква В

        private void imgV_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1V.Visibility = Visibility.Visible;
            btn2V.Visibility = Visibility.Visible;
            btn3V.Visibility = Visibility.Visible;
            imgV.Opacity = 0.1;

        }

        private void imgV_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1V.Visibility = Visibility.Hidden;
            btn2V.Visibility = Visibility.Hidden;
            btn3V.Visibility = Visibility.Hidden;
            imgV.Opacity = 1;
        }

        private void btn1V_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1V.Visibility = Visibility.Visible;
            btn2V.Visibility = Visibility.Visible;
            btn3V.Visibility = Visibility.Visible;
            imgV.Opacity = 0.1;
        }

        private void btn1V_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1V.Visibility = Visibility.Hidden;
            btn2V.Visibility = Visibility.Hidden;
            btn3V.Visibility = Visibility.Hidden;
            imgV.Opacity = 1;
        }

        private void btn2V_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1V.Visibility = Visibility.Visible;
            btn2V.Visibility = Visibility.Visible;
            btn3V.Visibility = Visibility.Visible;
            imgV.Opacity = 0.1;
        }

        private void btn2V_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1V.Visibility = Visibility.Hidden;
            btn2V.Visibility = Visibility.Hidden;
            btn3V.Visibility = Visibility.Hidden;
            imgV.Opacity = 1;
        }

        private void btn3V_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1V.Visibility = Visibility.Visible;
            btn2V.Visibility = Visibility.Visible;
            btn3V.Visibility = Visibility.Visible;
            imgV.Opacity = 0.1;
        }

        private void btn3V_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1V.Visibility = Visibility.Hidden;
            btn2V.Visibility = Visibility.Hidden;
            btn3V.Visibility = Visibility.Hidden;
            imgV.Opacity = 1;
        }

        private void btn2V_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/V.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Г

        private void imgG_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1G.Visibility = Visibility.Visible;
            btn2G.Visibility = Visibility.Visible;
            btn3G.Visibility = Visibility.Visible;
            imgG.Opacity = 0.1;

        }

        private void imgG_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1G.Visibility = Visibility.Hidden;
            btn2G.Visibility = Visibility.Hidden;
            btn3G.Visibility = Visibility.Hidden;
            imgG.Opacity = 1;
        }

        private void btn1G_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1G.Visibility = Visibility.Visible;
            btn2G.Visibility = Visibility.Visible;
            btn3G.Visibility = Visibility.Visible;
            imgG.Opacity = 0.1;
        }

        private void btn1G_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1G.Visibility = Visibility.Hidden;
            btn2G.Visibility = Visibility.Hidden;
            btn3G.Visibility = Visibility.Hidden;
            imgG.Opacity = 1;
        }

        private void btn2G_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1G.Visibility = Visibility.Visible;
            btn2G.Visibility = Visibility.Visible;
            btn3G.Visibility = Visibility.Visible;
            imgG.Opacity = 0.1;
        }

        private void btn2G_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1G.Visibility = Visibility.Hidden;
            btn2G.Visibility = Visibility.Hidden;
            btn3G.Visibility = Visibility.Hidden;
            imgG.Opacity = 1;
        }

        private void btn3G_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1G.Visibility = Visibility.Visible;
            btn2G.Visibility = Visibility.Visible;
            btn3G.Visibility = Visibility.Visible;
            imgG.Opacity = 0.1;
        }

        private void btn3G_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1G.Visibility = Visibility.Hidden;
            btn2G.Visibility = Visibility.Hidden;
            btn3G.Visibility = Visibility.Hidden;
            imgG.Opacity = 1;
        }

        private void btn2G_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/G.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Д

        private void imgD_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1D.Visibility = Visibility.Visible;
            btn2D.Visibility = Visibility.Visible;
            btn3D.Visibility = Visibility.Visible;
            imgD.Opacity = 0.1;

        }

        private void imgD_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1D.Visibility = Visibility.Hidden;
            btn2D.Visibility = Visibility.Hidden;
            btn3D.Visibility = Visibility.Hidden;
            imgD.Opacity = 1;
        }

        private void btn1D_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1D.Visibility = Visibility.Visible;
            btn2D.Visibility = Visibility.Visible;
            btn3D.Visibility = Visibility.Visible;
            imgD.Opacity = 0.1;
        }

        private void btn1D_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1D.Visibility = Visibility.Hidden;
            btn2D.Visibility = Visibility.Hidden;
            btn3D.Visibility = Visibility.Hidden;
            imgD.Opacity = 1;
        }

        private void btn2D_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1D.Visibility = Visibility.Visible;
            btn2D.Visibility = Visibility.Visible;
            btn3D.Visibility = Visibility.Visible;
            imgD.Opacity = 0.1;
        }

        private void btn2D_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1D.Visibility = Visibility.Hidden;
            btn2D.Visibility = Visibility.Hidden;
            btn3D.Visibility = Visibility.Hidden;
            imgD.Opacity = 1;
        }

        private void btn3D_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1D.Visibility = Visibility.Visible;
            btn2D.Visibility = Visibility.Visible;
            btn3D.Visibility = Visibility.Visible;
            imgD.Opacity = 0.1;
        }

        private void btn3D_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1D.Visibility = Visibility.Hidden;
            btn2D.Visibility = Visibility.Hidden;
            btn3D.Visibility = Visibility.Hidden;
            imgD.Opacity = 1;
        }

        private void btn2D_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/D.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Е

        private void imgE_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1E.Visibility = Visibility.Visible;
            btn2E.Visibility = Visibility.Visible;
            btn3E.Visibility = Visibility.Visible;
            imgE.Opacity = 0.1;

        }

        private void imgE_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1E.Visibility = Visibility.Hidden;
            btn2E.Visibility = Visibility.Hidden;
            btn3E.Visibility = Visibility.Hidden;
            imgE.Opacity = 1;
        }

        private void btn1E_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1E.Visibility = Visibility.Visible;
            btn2E.Visibility = Visibility.Visible;
            btn3E.Visibility = Visibility.Visible;
            imgE.Opacity = 0.1;
        }

        private void btn1E_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1E.Visibility = Visibility.Hidden;
            btn2E.Visibility = Visibility.Hidden;
            btn3E.Visibility = Visibility.Hidden;
            imgE.Opacity = 1;
        }

        private void btn2E_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1E.Visibility = Visibility.Visible;
            btn2E.Visibility = Visibility.Visible;
            btn3E.Visibility = Visibility.Visible;
            imgE.Opacity = 0.1;
        }

        private void btn2E_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1E.Visibility = Visibility.Hidden;
            btn2E.Visibility = Visibility.Hidden;
            btn3E.Visibility = Visibility.Hidden;
            imgE.Opacity = 1;
        }

        private void btn3E_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1E.Visibility = Visibility.Visible;
            btn2E.Visibility = Visibility.Visible;
            btn3E.Visibility = Visibility.Visible;
            imgE.Opacity = 0.1;
        }

        private void btn3E_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1E.Visibility = Visibility.Hidden;
            btn2E.Visibility = Visibility.Hidden;
            btn3E.Visibility = Visibility.Hidden;
            imgE.Opacity = 1;
        }

        private void btn2E_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/E.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Ё

        private void imgEE_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1EE.Visibility = Visibility.Visible;
            btn2EE.Visibility = Visibility.Visible;
            btn3EE.Visibility = Visibility.Visible;
            imgEE.Opacity = 0.1;

        }

        private void imgEE_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1EE.Visibility = Visibility.Hidden;
            btn2EE.Visibility = Visibility.Hidden;
            btn3EE.Visibility = Visibility.Hidden;
            imgEE.Opacity = 1;
        }

        private void btn1EE_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1EE.Visibility = Visibility.Visible;
            btn2EE.Visibility = Visibility.Visible;
            btn3EE.Visibility = Visibility.Visible;
            imgEE.Opacity = 0.1;
        }

        private void btn1EE_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1EE.Visibility = Visibility.Hidden;
            btn2EE.Visibility = Visibility.Hidden;
            btn3EE.Visibility = Visibility.Hidden;
            imgEE.Opacity = 1;
        }

        private void btn2EE_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1EE.Visibility = Visibility.Visible;
            btn2EE.Visibility = Visibility.Visible;
            btn3EE.Visibility = Visibility.Visible;
            imgEE.Opacity = 0.1;
        }

        private void btn2EE_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1EE.Visibility = Visibility.Hidden;
            btn2EE.Visibility = Visibility.Hidden;
            btn3EE.Visibility = Visibility.Hidden;
            imgEE.Opacity = 1;
        }

        private void btn3EE_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1EE.Visibility = Visibility.Visible;
            btn2EE.Visibility = Visibility.Visible;
            btn3EE.Visibility = Visibility.Visible;
            imgEE.Opacity = 0.1;
        }

        private void btn3EE_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1EE.Visibility = Visibility.Hidden;
            btn2EE.Visibility = Visibility.Hidden;
            btn3EE.Visibility = Visibility.Hidden;
            imgEE.Opacity = 1;
        }

        private void btn2EE_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/EE.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Ж

        private void imgJ_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1J.Visibility = Visibility.Visible;
            btn2J.Visibility = Visibility.Visible;
            btn3J.Visibility = Visibility.Visible;
            imgJ.Opacity = 0.1;

        }

        private void imgJ_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1J.Visibility = Visibility.Hidden;
            btn2J.Visibility = Visibility.Hidden;
            btn3J.Visibility = Visibility.Hidden;
            imgJ.Opacity = 1;
        }

        private void btn1J_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1J.Visibility = Visibility.Visible;
            btn2J.Visibility = Visibility.Visible;
            btn3J.Visibility = Visibility.Visible;
            imgJ.Opacity = 0.1;
        }

        private void btn1J_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1J.Visibility = Visibility.Hidden;
            btn2J.Visibility = Visibility.Hidden;
            btn3J.Visibility = Visibility.Hidden;
            imgJ.Opacity = 1;
        }

        private void btn2J_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1J.Visibility = Visibility.Visible;
            btn2J.Visibility = Visibility.Visible;
            btn3J.Visibility = Visibility.Visible;
            imgJ.Opacity = 0.1;
        }

        private void btn2J_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1J.Visibility = Visibility.Hidden;
            btn2J.Visibility = Visibility.Hidden;
            btn3J.Visibility = Visibility.Hidden;
            imgJ.Opacity = 1;
        }

        private void btn3J_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1J.Visibility = Visibility.Visible;
            btn2J.Visibility = Visibility.Visible;
            btn3J.Visibility = Visibility.Visible;
            imgJ.Opacity = 0.1;
        }

        private void btn3J_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1J.Visibility = Visibility.Hidden;
            btn2J.Visibility = Visibility.Hidden;
            btn3J.Visibility = Visibility.Hidden;
            imgJ.Opacity = 1;
        }

        private void btn2J_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/J.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква З

        private void imgZ_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1Z.Visibility = Visibility.Visible;
            btn2Z.Visibility = Visibility.Visible;
            btn3Z.Visibility = Visibility.Visible;
            imgZ.Opacity = 0.1;

        }

        private void imgZ_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1Z.Visibility = Visibility.Hidden;
            btn2Z.Visibility = Visibility.Hidden;
            btn3Z.Visibility = Visibility.Hidden;
            imgZ.Opacity = 1;
        }

        private void btn1Z_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1Z.Visibility = Visibility.Visible;
            btn2Z.Visibility = Visibility.Visible;
            btn3Z.Visibility = Visibility.Visible;
            imgZ.Opacity = 0.1;
        }

        private void btn1Z_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1Z.Visibility = Visibility.Hidden;
            btn2Z.Visibility = Visibility.Hidden;
            btn3Z.Visibility = Visibility.Hidden;
            imgZ.Opacity = 1;
        }

        private void btn2Z_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1Z.Visibility = Visibility.Visible;
            btn2Z.Visibility = Visibility.Visible;
            btn3Z.Visibility = Visibility.Visible;
            imgZ.Opacity = 0.1;
        }

        private void btn2Z_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1Z.Visibility = Visibility.Hidden;
            btn2Z.Visibility = Visibility.Hidden;
            btn3Z.Visibility = Visibility.Hidden;
            imgZ.Opacity = 1;
        }

        private void btn3Z_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1Z.Visibility = Visibility.Visible;
            btn2Z.Visibility = Visibility.Visible;
            btn3Z.Visibility = Visibility.Visible;
            imgZ.Opacity = 0.1;
        }

        private void btn3Z_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1Z.Visibility = Visibility.Hidden;
            btn2Z.Visibility = Visibility.Hidden;
            btn3Z.Visibility = Visibility.Hidden;
            imgZ.Opacity = 1;
        }

        private void btn2Z_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/Z.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква И

        private void imgI_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1I.Visibility = Visibility.Visible;
            btn2I.Visibility = Visibility.Visible;
            btn3I.Visibility = Visibility.Visible;
            imgI.Opacity = 0.1;

        }

        private void imgI_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1I.Visibility = Visibility.Hidden;
            btn2I.Visibility = Visibility.Hidden;
            btn3I.Visibility = Visibility.Hidden;
            imgI.Opacity = 1;
        }

        private void btn1I_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1I.Visibility = Visibility.Visible;
            btn2I.Visibility = Visibility.Visible;
            btn3I.Visibility = Visibility.Visible;
            imgI.Opacity = 0.1;
        }

        private void btn1I_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1I.Visibility = Visibility.Hidden;
            btn2I.Visibility = Visibility.Hidden;
            btn3I.Visibility = Visibility.Hidden;
            imgI.Opacity = 1;
        }

        private void btn2I_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1I.Visibility = Visibility.Visible;
            btn2I.Visibility = Visibility.Visible;
            btn3I.Visibility = Visibility.Visible;
            imgI.Opacity = 0.1;
        }

        private void btn2I_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1I.Visibility = Visibility.Hidden;
            btn2I.Visibility = Visibility.Hidden;
            btn3I.Visibility = Visibility.Hidden;
            imgI.Opacity = 1;
        }

        private void btn3I_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1I.Visibility = Visibility.Visible;
            btn2I.Visibility = Visibility.Visible;
            btn3I.Visibility = Visibility.Visible;
            imgI.Opacity = 0.1;
        }

        private void btn3I_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1I.Visibility = Visibility.Hidden;
            btn2I.Visibility = Visibility.Hidden;
            btn3I.Visibility = Visibility.Hidden;
            imgI.Opacity = 1;
        }

        private void btn2I_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/I.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Й

        private void imgII_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1II.Visibility = Visibility.Visible;
            btn2II.Visibility = Visibility.Visible;
            btn3II.Visibility = Visibility.Visible;
            imgII.Opacity = 0.1;

        }

        private void imgII_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1II.Visibility = Visibility.Hidden;
            btn2II.Visibility = Visibility.Hidden;
            btn3II.Visibility = Visibility.Hidden;
            imgII.Opacity = 1;
        }

        private void btn1II_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1II.Visibility = Visibility.Visible;
            btn2II.Visibility = Visibility.Visible;
            btn3II.Visibility = Visibility.Visible;
            imgII.Opacity = 0.1;
        }

        private void btn1II_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1II.Visibility = Visibility.Hidden;
            btn2II.Visibility = Visibility.Hidden;
            btn3II.Visibility = Visibility.Hidden;
            imgII.Opacity = 1;
        }

        private void btn2II_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1II.Visibility = Visibility.Visible;
            btn2II.Visibility = Visibility.Visible;
            btn3II.Visibility = Visibility.Visible;
            imgII.Opacity = 0.1;
        }

        private void btn2II_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1II.Visibility = Visibility.Hidden;
            btn2II.Visibility = Visibility.Hidden;
            btn3II.Visibility = Visibility.Hidden;
            imgII.Opacity = 1;
        }

        private void btn3II_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1II.Visibility = Visibility.Visible;
            btn2II.Visibility = Visibility.Visible;
            btn3II.Visibility = Visibility.Visible;
            imgII.Opacity = 0.1;
        }

        private void btn3II_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1II.Visibility = Visibility.Hidden;
            btn2II.Visibility = Visibility.Hidden;
            btn3II.Visibility = Visibility.Hidden;
            imgII.Opacity = 1;
        }

        private void btn2II_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/II.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква К

        private void imgK_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1K.Visibility = Visibility.Visible;
            btn2K.Visibility = Visibility.Visible;
            btn3K.Visibility = Visibility.Visible;
            imgK.Opacity = 0.1;

        }

        private void imgK_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1K.Visibility = Visibility.Hidden;
            btn2K.Visibility = Visibility.Hidden;
            btn3K.Visibility = Visibility.Hidden;
            imgK.Opacity = 1;
        }

        private void btn1K_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1K.Visibility = Visibility.Visible;
            btn2K.Visibility = Visibility.Visible;
            btn3K.Visibility = Visibility.Visible;
            imgK.Opacity = 0.1;
        }

        private void btn1K_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1K.Visibility = Visibility.Hidden;
            btn2K.Visibility = Visibility.Hidden;
            btn3K.Visibility = Visibility.Hidden;
            imgK.Opacity = 1;
        }

        private void btn2K_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1K.Visibility = Visibility.Visible;
            btn2K.Visibility = Visibility.Visible;
            btn3K.Visibility = Visibility.Visible;
            imgK.Opacity = 0.1;
        }

        private void btn2K_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1K.Visibility = Visibility.Hidden;
            btn2K.Visibility = Visibility.Hidden;
            btn3K.Visibility = Visibility.Hidden;
            imgK.Opacity = 1;
        }

        private void btn3K_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1K.Visibility = Visibility.Visible;
            btn2K.Visibility = Visibility.Visible;
            btn3K.Visibility = Visibility.Visible;
            imgK.Opacity = 0.1;
        }

        private void btn3K_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1K.Visibility = Visibility.Hidden;
            btn2K.Visibility = Visibility.Hidden;
            btn3K.Visibility = Visibility.Hidden;
            imgK.Opacity = 1;
        }

        private void btn2K_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/K.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Л

        private void imgL_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1L.Visibility = Visibility.Visible;
            btn2L.Visibility = Visibility.Visible;
            btn3L.Visibility = Visibility.Visible;
            imgL.Opacity = 0.1;

        }

        private void imgL_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1L.Visibility = Visibility.Hidden;
            btn2L.Visibility = Visibility.Hidden;
            btn3L.Visibility = Visibility.Hidden;
            imgL.Opacity = 1;
        }

        private void btn1L_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1L.Visibility = Visibility.Visible;
            btn2L.Visibility = Visibility.Visible;
            btn3L.Visibility = Visibility.Visible;
            imgL.Opacity = 0.1;
        }

        private void btn1L_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1L.Visibility = Visibility.Hidden;
            btn2L.Visibility = Visibility.Hidden;
            btn3L.Visibility = Visibility.Hidden;
            imgL.Opacity = 1;
        }

        private void btn2L_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1L.Visibility = Visibility.Visible;
            btn2L.Visibility = Visibility.Visible;
            btn3L.Visibility = Visibility.Visible;
            imgL.Opacity = 0.1;
        }

        private void btn2L_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1L.Visibility = Visibility.Hidden;
            btn2L.Visibility = Visibility.Hidden;
            btn3L.Visibility = Visibility.Hidden;
            imgL.Opacity = 1;
        }

        private void btn3L_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1L.Visibility = Visibility.Visible;
            btn2L.Visibility = Visibility.Visible;
            btn3L.Visibility = Visibility.Visible;
            imgL.Opacity = 0.1;
        }

        private void btn3L_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1L.Visibility = Visibility.Hidden;
            btn2L.Visibility = Visibility.Hidden;
            btn3L.Visibility = Visibility.Hidden;
            imgL.Opacity = 1;
        }

        private void btn2L_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/L.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква М

        private void imgM_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1M.Visibility = Visibility.Visible;
            btn2M.Visibility = Visibility.Visible;
            btn3M.Visibility = Visibility.Visible;
            imgM.Opacity = 0.1;

        }

        private void imgM_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1M.Visibility = Visibility.Hidden;
            btn2M.Visibility = Visibility.Hidden;
            btn3M.Visibility = Visibility.Hidden;
            imgM.Opacity = 1;
        }

        private void btn1M_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1M.Visibility = Visibility.Visible;
            btn2M.Visibility = Visibility.Visible;
            btn3M.Visibility = Visibility.Visible;
            imgM.Opacity = 0.1;
        }

        private void btn1M_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1M.Visibility = Visibility.Hidden;
            btn2M.Visibility = Visibility.Hidden;
            btn3M.Visibility = Visibility.Hidden;
            imgM.Opacity = 1;
        }

        private void btn2M_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1M.Visibility = Visibility.Visible;
            btn2M.Visibility = Visibility.Visible;
            btn3M.Visibility = Visibility.Visible;
            imgM.Opacity = 0.1;
        }

        private void btn2M_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1M.Visibility = Visibility.Hidden;
            btn2M.Visibility = Visibility.Hidden;
            btn3M.Visibility = Visibility.Hidden;
            imgM.Opacity = 1;
        }

        private void btn3M_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1M.Visibility = Visibility.Visible;
            btn2M.Visibility = Visibility.Visible;
            btn3M.Visibility = Visibility.Visible;
            imgM.Opacity = 0.1;
        }

        private void btn3M_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1M.Visibility = Visibility.Hidden;
            btn2M.Visibility = Visibility.Hidden;
            btn3M.Visibility = Visibility.Hidden;
            imgM.Opacity = 1;
        }

        private void btn2M_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/M.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Н

        private void imgH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1H.Visibility = Visibility.Visible;
            btn2H.Visibility = Visibility.Visible;
            btn3H.Visibility = Visibility.Visible;
            imgH.Opacity = 0.1;

        }

        private void imgH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1H.Visibility = Visibility.Hidden;
            btn2H.Visibility = Visibility.Hidden;
            btn3H.Visibility = Visibility.Hidden;
            imgH.Opacity = 1;
        }

        private void btn1H_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1H.Visibility = Visibility.Visible;
            btn2H.Visibility = Visibility.Visible;
            btn3H.Visibility = Visibility.Visible;
            imgH.Opacity = 0.1;
        }

        private void btn1H_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1H.Visibility = Visibility.Hidden;
            btn2H.Visibility = Visibility.Hidden;
            btn3H.Visibility = Visibility.Hidden;
            imgH.Opacity = 1;
        }

        private void btn2H_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1H.Visibility = Visibility.Visible;
            btn2H.Visibility = Visibility.Visible;
            btn3H.Visibility = Visibility.Visible;
            imgH.Opacity = 0.1;
        }

        private void btn2H_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1H.Visibility = Visibility.Hidden;
            btn2H.Visibility = Visibility.Hidden;
            btn3H.Visibility = Visibility.Hidden;
            imgH.Opacity = 1;
        }

        private void btn3H_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1H.Visibility = Visibility.Visible;
            btn2H.Visibility = Visibility.Visible;
            btn3H.Visibility = Visibility.Visible;
            imgH.Opacity = 0.1;
        }

        private void btn3H_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1H.Visibility = Visibility.Hidden;
            btn2H.Visibility = Visibility.Hidden;
            btn3H.Visibility = Visibility.Hidden;
            imgH.Opacity = 1;
        }
        private void btn2H_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/H.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква О

        private void imgO_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1O.Visibility = Visibility.Visible;
            btn2O.Visibility = Visibility.Visible;
            btn3O.Visibility = Visibility.Visible;
            imgO.Opacity = 0.1;

        }

        private void imgO_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1O.Visibility = Visibility.Hidden;
            btn2O.Visibility = Visibility.Hidden;
            btn3O.Visibility = Visibility.Hidden;
            imgO.Opacity = 1;
        }

        private void btn1O_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1O.Visibility = Visibility.Visible;
            btn2O.Visibility = Visibility.Visible;
            btn3O.Visibility = Visibility.Visible;
            imgO.Opacity = 0.1;
        }

        private void btn1O_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1O.Visibility = Visibility.Hidden;
            btn2O.Visibility = Visibility.Hidden;
            btn3O.Visibility = Visibility.Hidden;
            imgO.Opacity = 1;
        }

        private void btn2O_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1O.Visibility = Visibility.Visible;
            btn2O.Visibility = Visibility.Visible;
            btn3O.Visibility = Visibility.Visible;
            imgO.Opacity = 0.1;
        }

        private void btn2O_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1O.Visibility = Visibility.Hidden;
            btn2O.Visibility = Visibility.Hidden;
            btn3O.Visibility = Visibility.Hidden;
            imgO.Opacity = 1;
        }

        private void btn3O_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1O.Visibility = Visibility.Visible;
            btn2O.Visibility = Visibility.Visible;
            btn3O.Visibility = Visibility.Visible;
            imgO.Opacity = 0.1;
        }

        private void btn3O_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1O.Visibility = Visibility.Hidden;
            btn2O.Visibility = Visibility.Hidden;
            btn3O.Visibility = Visibility.Hidden;
            imgO.Opacity = 1;
        }

        private void btn2O_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/O.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква П

        private void imgP_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1P.Visibility = Visibility.Visible;
            btn2P.Visibility = Visibility.Visible;
            btn3P.Visibility = Visibility.Visible;
            imgP.Opacity = 0.1;

        }

        private void imgP_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1P.Visibility = Visibility.Hidden;
            btn2P.Visibility = Visibility.Hidden;
            btn3P.Visibility = Visibility.Hidden;
            imgP.Opacity = 1;
        }

        private void btn1P_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1P.Visibility = Visibility.Visible;
            btn2P.Visibility = Visibility.Visible;
            btn3P.Visibility = Visibility.Visible;
            imgP.Opacity = 0.1;
        }

        private void btn1P_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1P.Visibility = Visibility.Hidden;
            btn2P.Visibility = Visibility.Hidden;
            btn3P.Visibility = Visibility.Hidden;
            imgP.Opacity = 1;
        }

        private void btn2P_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1P.Visibility = Visibility.Visible;
            btn2P.Visibility = Visibility.Visible;
            btn3P.Visibility = Visibility.Visible;
            imgP.Opacity = 0.1;
        }

        private void btn2P_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1P.Visibility = Visibility.Hidden;
            btn2P.Visibility = Visibility.Hidden;
            btn3P.Visibility = Visibility.Hidden;
            imgP.Opacity = 1;
        }

        private void btn3P_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1P.Visibility = Visibility.Visible;
            btn2P.Visibility = Visibility.Visible;
            btn3P.Visibility = Visibility.Visible;
            imgP.Opacity = 0.1;
        }

        private void btn3P_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1P.Visibility = Visibility.Hidden;
            btn2P.Visibility = Visibility.Hidden;
            btn3P.Visibility = Visibility.Hidden;
            imgP.Opacity = 1;
        }

        private void btn2P_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/P.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Р

        private void imgR_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1R.Visibility = Visibility.Visible;
            btn2R.Visibility = Visibility.Visible;
            btn3R.Visibility = Visibility.Visible;
            imgR.Opacity = 0.1;

        }

        private void imgR_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1R.Visibility = Visibility.Hidden;
            btn2R.Visibility = Visibility.Hidden;
            btn3R.Visibility = Visibility.Hidden;
            imgR.Opacity = 1;
        }

        private void btn1R_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1R.Visibility = Visibility.Visible;
            btn2R.Visibility = Visibility.Visible;
            btn3R.Visibility = Visibility.Visible;
            imgR.Opacity = 0.1;
        }

        private void btn1R_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1R.Visibility = Visibility.Hidden;
            btn2R.Visibility = Visibility.Hidden;
            btn3R.Visibility = Visibility.Hidden;
            imgR.Opacity = 1;
        }

        private void btn2R_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1R.Visibility = Visibility.Visible;
            btn2R.Visibility = Visibility.Visible;
            btn3R.Visibility = Visibility.Visible;
            imgR.Opacity = 0.1;
        }

        private void btn2R_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1R.Visibility = Visibility.Hidden;
            btn2R.Visibility = Visibility.Hidden;
            btn3R.Visibility = Visibility.Hidden;
            imgR.Opacity = 1;
        }

        private void btn3R_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1R.Visibility = Visibility.Visible;
            btn2R.Visibility = Visibility.Visible;
            btn3R.Visibility = Visibility.Visible;
            imgR.Opacity = 0.1;
        }

        private void btn3R_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1R.Visibility = Visibility.Hidden;
            btn2R.Visibility = Visibility.Hidden;
            btn3R.Visibility = Visibility.Hidden;
            imgR.Opacity = 1;
        }

        private void btn2R_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/R.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква С

        private void imgC_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1C.Visibility = Visibility.Visible;
            btn2C.Visibility = Visibility.Visible;
            btn3C.Visibility = Visibility.Visible;
            imgC.Opacity = 0.1;

        }

        private void imgC_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1C.Visibility = Visibility.Hidden;
            btn2C.Visibility = Visibility.Hidden;
            btn3C.Visibility = Visibility.Hidden;
            imgC.Opacity = 1;
        }

        private void btn1C_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1C.Visibility = Visibility.Visible;
            btn2C.Visibility = Visibility.Visible;
            btn3C.Visibility = Visibility.Visible;
            imgC.Opacity = 0.1;
        }

        private void btn1C_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1C.Visibility = Visibility.Hidden;
            btn2C.Visibility = Visibility.Hidden;
            btn3C.Visibility = Visibility.Hidden;
            imgC.Opacity = 1;
        }

        private void btn2C_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1C.Visibility = Visibility.Visible;
            btn2C.Visibility = Visibility.Visible;
            btn3C.Visibility = Visibility.Visible;
            imgC.Opacity = 0.1;
        }

        private void btn2C_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1C.Visibility = Visibility.Hidden;
            btn2C.Visibility = Visibility.Hidden;
            btn3C.Visibility = Visibility.Hidden;
            imgC.Opacity = 1;
        }

        private void btn3C_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1C.Visibility = Visibility.Visible;
            btn2C.Visibility = Visibility.Visible;
            btn3C.Visibility = Visibility.Visible;
            imgC.Opacity = 0.1;
        }

        private void btn3C_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1C.Visibility = Visibility.Hidden;
            btn2C.Visibility = Visibility.Hidden;
            btn3C.Visibility = Visibility.Hidden;
            imgC.Opacity = 1;
        }

        private void btn2C_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/C.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Т

        private void imgT_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1T.Visibility = Visibility.Visible;
            btn2T.Visibility = Visibility.Visible;
            btn3T.Visibility = Visibility.Visible;
            imgT.Opacity = 0.1;

        }

        private void imgT_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1T.Visibility = Visibility.Hidden;
            btn2T.Visibility = Visibility.Hidden;
            btn3T.Visibility = Visibility.Hidden;
            imgT.Opacity = 1;
        }

        private void btn1T_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1T.Visibility = Visibility.Visible;
            btn2T.Visibility = Visibility.Visible;
            btn3T.Visibility = Visibility.Visible;
            imgT.Opacity = 0.1;
        }

        private void btn1T_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1T.Visibility = Visibility.Hidden;
            btn2T.Visibility = Visibility.Hidden;
            btn3T.Visibility = Visibility.Hidden;
            imgT.Opacity = 1;
        }

        private void btn2T_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1T.Visibility = Visibility.Visible;
            btn2T.Visibility = Visibility.Visible;
            btn3T.Visibility = Visibility.Visible;
            imgT.Opacity = 0.1;
        }

        private void btn2T_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1T.Visibility = Visibility.Hidden;
            btn2T.Visibility = Visibility.Hidden;
            btn3T.Visibility = Visibility.Hidden;
            imgT.Opacity = 1;
        }

        private void btn3T_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1T.Visibility = Visibility.Visible;
            btn2T.Visibility = Visibility.Visible;
            btn3T.Visibility = Visibility.Visible;
            imgT.Opacity = 0.1;
        }

        private void btn3T_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1T.Visibility = Visibility.Hidden;
            btn2T.Visibility = Visibility.Hidden;
            btn3T.Visibility = Visibility.Hidden;
            imgT.Opacity = 1;
        }

        private void btn2T_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/T.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква У

        private void imgU_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1U.Visibility = Visibility.Visible;
            btn2U.Visibility = Visibility.Visible;
            btn3U.Visibility = Visibility.Visible;
            imgU.Opacity = 0.1;

        }

        private void imgU_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1U.Visibility = Visibility.Hidden;
            btn2U.Visibility = Visibility.Hidden;
            btn3U.Visibility = Visibility.Hidden;
            imgU.Opacity = 1;
        }

        private void btn1U_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1U.Visibility = Visibility.Visible;
            btn2U.Visibility = Visibility.Visible;
            btn3U.Visibility = Visibility.Visible;
            imgU.Opacity = 0.1;
        }

        private void btn1U_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1U.Visibility = Visibility.Hidden;
            btn2U.Visibility = Visibility.Hidden;
            btn3U.Visibility = Visibility.Hidden;
            imgU.Opacity = 1;
        }

        private void btn2U_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1U.Visibility = Visibility.Visible;
            btn2U.Visibility = Visibility.Visible;
            btn3U.Visibility = Visibility.Visible;
            imgU.Opacity = 0.1;
        }

        private void btn2U_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1U.Visibility = Visibility.Hidden;
            btn2U.Visibility = Visibility.Hidden;
            btn3U.Visibility = Visibility.Hidden;
            imgU.Opacity = 1;
        }

        private void btn3U_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1U.Visibility = Visibility.Visible;
            btn2U.Visibility = Visibility.Visible;
            btn3U.Visibility = Visibility.Visible;
            imgU.Opacity = 0.1;
        }

        private void btn3U_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1U.Visibility = Visibility.Hidden;
            btn2U.Visibility = Visibility.Hidden;
            btn3U.Visibility = Visibility.Hidden;
            imgU.Opacity = 1;
        }

        private void btn2U_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/U.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Ф

        private void imgF_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1F.Visibility = Visibility.Visible;
            btn2F.Visibility = Visibility.Visible;
            btn3F.Visibility = Visibility.Visible;
            imgF.Opacity = 0.1;

        }

        private void imgF_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1F.Visibility = Visibility.Hidden;
            btn2F.Visibility = Visibility.Hidden;
            btn3F.Visibility = Visibility.Hidden;
            imgF.Opacity = 1;
        }

        private void btn1F_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1F.Visibility = Visibility.Visible;
            btn2F.Visibility = Visibility.Visible;
            btn3F.Visibility = Visibility.Visible;
            imgF.Opacity = 0.1;
        }

        private void btn1F_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1F.Visibility = Visibility.Hidden;
            btn2F.Visibility = Visibility.Hidden;
            btn3F.Visibility = Visibility.Hidden;
            imgF.Opacity = 1;
        }

        private void btn2F_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1F.Visibility = Visibility.Visible;
            btn2F.Visibility = Visibility.Visible;
            btn3F.Visibility = Visibility.Visible;
            imgF.Opacity = 0.1;
        }

        private void btn2F_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1F.Visibility = Visibility.Hidden;
            btn2F.Visibility = Visibility.Hidden;
            btn3F.Visibility = Visibility.Hidden;
            imgF.Opacity = 1;
        }

        private void btn3F_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1F.Visibility = Visibility.Visible;
            btn2F.Visibility = Visibility.Visible;
            btn3F.Visibility = Visibility.Visible;
            imgF.Opacity = 0.1;
        }

        private void btn3F_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1F.Visibility = Visibility.Hidden;
            btn2F.Visibility = Visibility.Hidden;
            btn3F.Visibility = Visibility.Hidden;
            imgF.Opacity = 1;
        }

        private void btn2F_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/F.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Х

        private void imgX_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1X.Visibility = Visibility.Visible;
            btn2X.Visibility = Visibility.Visible;
            btn3X.Visibility = Visibility.Visible;
            imgX.Opacity = 0.1;

        }

        private void imgX_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1X.Visibility = Visibility.Hidden;
            btn2X.Visibility = Visibility.Hidden;
            btn3X.Visibility = Visibility.Hidden;
            imgX.Opacity = 1;
        }

        private void btn1X_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1X.Visibility = Visibility.Visible;
            btn2X.Visibility = Visibility.Visible;
            btn3X.Visibility = Visibility.Visible;
            imgX.Opacity = 0.1;
        }

        private void btn1X_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1X.Visibility = Visibility.Hidden;
            btn2X.Visibility = Visibility.Hidden;
            btn3X.Visibility = Visibility.Hidden;
            imgX.Opacity = 1;
        }

        private void btn2X_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1X.Visibility = Visibility.Visible;
            btn2X.Visibility = Visibility.Visible;
            btn3X.Visibility = Visibility.Visible;
            imgX.Opacity = 0.1;
        }

        private void btn2X_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1X.Visibility = Visibility.Hidden;
            btn2X.Visibility = Visibility.Hidden;
            btn3X.Visibility = Visibility.Hidden;
            imgX.Opacity = 1;
        }

        private void btn3X_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1X.Visibility = Visibility.Visible;
            btn2X.Visibility = Visibility.Visible;
            btn3X.Visibility = Visibility.Visible;
            imgX.Opacity = 0.1;
        }

        private void btn3X_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1X.Visibility = Visibility.Hidden;
            btn2X.Visibility = Visibility.Hidden;
            btn3X.Visibility = Visibility.Hidden;
            imgX.Opacity = 1;
        }

        private void btn2X_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/X.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Ц

        private void imgCC_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1СС.Visibility = Visibility.Visible;
            btn2СС.Visibility = Visibility.Visible;
            btn3СС.Visibility = Visibility.Visible;
            imgCC.Opacity = 0.1;

        }

        private void imgCC_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1СС.Visibility = Visibility.Hidden;
            btn2СС.Visibility = Visibility.Hidden;
            btn3СС.Visibility = Visibility.Hidden;
            imgCC.Opacity = 1;
        }

        private void btn1СС_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1СС.Visibility = Visibility.Visible;
            btn2СС.Visibility = Visibility.Visible;
            btn3СС.Visibility = Visibility.Visible;
            imgCC.Opacity = 0.1;
        }

        private void btn1СС_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1СС.Visibility = Visibility.Hidden;
            btn2СС.Visibility = Visibility.Hidden;
            btn3СС.Visibility = Visibility.Hidden;
            imgCC.Opacity = 1;
        }

        private void btn2СС_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1СС.Visibility = Visibility.Visible;
            btn2СС.Visibility = Visibility.Visible;
            btn3СС.Visibility = Visibility.Visible;
            imgCC.Opacity = 0.1;
        }

        private void btn2СС_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1СС.Visibility = Visibility.Hidden;
            btn2СС.Visibility = Visibility.Hidden;
            btn3СС.Visibility = Visibility.Hidden;
            imgCC.Opacity = 1;
        }

        private void btn3СС_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1СС.Visibility = Visibility.Visible;
            btn2СС.Visibility = Visibility.Visible;
            btn3СС.Visibility = Visibility.Visible;
            imgCC.Opacity = 0.1;
        }

        private void btn3СС_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1СС.Visibility = Visibility.Hidden;
            btn2СС.Visibility = Visibility.Hidden;
            btn3СС.Visibility = Visibility.Hidden;
            imgCC.Opacity = 1;
        }

        private void btn2СС_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/CC.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Ч

        private void imgCH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1СH.Visibility = Visibility.Visible;
            btn2СH.Visibility = Visibility.Visible;
            btn3СH.Visibility = Visibility.Visible;
            imgCH.Opacity = 0.1;

        }

        private void imgCH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1СH.Visibility = Visibility.Hidden;
            btn2СH.Visibility = Visibility.Hidden;
            btn3СH.Visibility = Visibility.Hidden;
            imgCH.Opacity = 1;
        }

        private void btn1СH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1СH.Visibility = Visibility.Visible;
            btn2СH.Visibility = Visibility.Visible;
            btn3СH.Visibility = Visibility.Visible;
            imgCH.Opacity = 0.1;
        }

        private void btn1СH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1СH.Visibility = Visibility.Hidden;
            btn2СH.Visibility = Visibility.Hidden;
            btn3СH.Visibility = Visibility.Hidden;
            imgCH.Opacity = 1;
        }

        private void btn2СH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1СH.Visibility = Visibility.Visible;
            btn2СH.Visibility = Visibility.Visible;
            btn3СH.Visibility = Visibility.Visible;
            imgCH.Opacity = 0.1;
        }

        private void btn2СH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1СH.Visibility = Visibility.Hidden;
            btn2СH.Visibility = Visibility.Hidden;
            btn3СH.Visibility = Visibility.Hidden;
            imgCH.Opacity = 1;
        }

        private void btn3СH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1СH.Visibility = Visibility.Visible;
            btn2СH.Visibility = Visibility.Visible;
            btn3СH.Visibility = Visibility.Visible;
            imgCH.Opacity = 0.1;
        }

        private void btn3СH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1СH.Visibility = Visibility.Hidden;
            btn2СH.Visibility = Visibility.Hidden;
            btn3СH.Visibility = Visibility.Hidden;
            imgCH.Opacity = 1;
        }

        private void btn2СH_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/CH.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Ш

        private void imgSH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1SH.Visibility = Visibility.Visible;
            btn2SH.Visibility = Visibility.Visible;
            btn3SH.Visibility = Visibility.Visible;
            imgSH.Opacity = 0.1;

        }

        private void imgSH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1SH.Visibility = Visibility.Hidden;
            btn2SH.Visibility = Visibility.Hidden;
            btn3SH.Visibility = Visibility.Hidden;
            imgSH.Opacity = 1;
        }

        private void btn1SH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1SH.Visibility = Visibility.Visible;
            btn2SH.Visibility = Visibility.Visible;
            btn3SH.Visibility = Visibility.Visible;
            imgSH.Opacity = 0.1;
        }

        private void btn1SH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1SH.Visibility = Visibility.Hidden;
            btn2SH.Visibility = Visibility.Hidden;
            btn3SH.Visibility = Visibility.Hidden;
            imgSH.Opacity = 1;
        }

        private void btn2SH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1SH.Visibility = Visibility.Visible;
            btn2SH.Visibility = Visibility.Visible;
            btn3SH.Visibility = Visibility.Visible;
            imgSH.Opacity = 0.1;
        }

        private void btn2SH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1SH.Visibility = Visibility.Hidden;
            btn2SH.Visibility = Visibility.Hidden;
            btn3SH.Visibility = Visibility.Hidden;
            imgSH.Opacity = 1;
        }

        private void btn3SH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1SH.Visibility = Visibility.Visible;
            btn2SH.Visibility = Visibility.Visible;
            btn3SH.Visibility = Visibility.Visible;
            imgSH.Opacity = 0.1;
        }

        private void btn3SH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1SH.Visibility = Visibility.Hidden;
            btn2SH.Visibility = Visibility.Hidden;
            btn3SH.Visibility = Visibility.Hidden;
            imgSH.Opacity = 1;
        }

        private void btn2SH_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/SH.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Щ

        private void imgSHH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1SHH.Visibility = Visibility.Visible;
            btn2SHH.Visibility = Visibility.Visible;
            btn3SHH.Visibility = Visibility.Visible;
            imgSHH.Opacity = 0.1;

        }

        private void imgSHH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1SHH.Visibility = Visibility.Hidden;
            btn2SHH.Visibility = Visibility.Hidden;
            btn3SHH.Visibility = Visibility.Hidden;
            imgSHH.Opacity = 1;
        }

        private void btn1SHH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1SHH.Visibility = Visibility.Visible;
            btn2SHH.Visibility = Visibility.Visible;
            btn3SHH.Visibility = Visibility.Visible;
            imgSHH.Opacity = 0.1;
        }

        private void btn1SHH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1SHH.Visibility = Visibility.Hidden;
            btn2SHH.Visibility = Visibility.Hidden;
            btn3SHH.Visibility = Visibility.Hidden;
            imgSHH.Opacity = 1;
        }

        private void btn2SHH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1SHH.Visibility = Visibility.Visible;
            btn2SHH.Visibility = Visibility.Visible;
            btn3SHH.Visibility = Visibility.Visible;
            imgSHH.Opacity = 0.1;
        }

        private void btn2SHH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1SHH.Visibility = Visibility.Hidden;
            btn2SHH.Visibility = Visibility.Hidden;
            btn3SHH.Visibility = Visibility.Hidden;
            imgSHH.Opacity = 1;
        }

        private void btn3SHH_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1SHH.Visibility = Visibility.Visible;
            btn2SHH.Visibility = Visibility.Visible;
            btn3SHH.Visibility = Visibility.Visible;
            imgSHH.Opacity = 0.1;
        }

        private void btn3SHH_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1SHH.Visibility = Visibility.Hidden;
            btn2SHH.Visibility = Visibility.Hidden;
            btn3SHH.Visibility = Visibility.Hidden;
            imgSHH.Opacity = 1;
        }

        private void btn2SHH_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/SHH.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Ъ

        private void imgTV_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1TV.Visibility = Visibility.Visible;
            btn2TV.Visibility = Visibility.Visible;
            btn3TV.Visibility = Visibility.Visible;
            imgTV.Opacity = 0.1;

        }

        private void imgTV_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1TV.Visibility = Visibility.Hidden;
            btn2TV.Visibility = Visibility.Hidden;
            btn3TV.Visibility = Visibility.Hidden;
            imgTV.Opacity = 1;
        }

        private void btn1TV_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1TV.Visibility = Visibility.Visible;
            btn2TV.Visibility = Visibility.Visible;
            btn3TV.Visibility = Visibility.Visible;
            imgTV.Opacity = 0.1;
        }

        private void btn1TV_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1TV.Visibility = Visibility.Hidden;
            btn2TV.Visibility = Visibility.Hidden;
            btn3TV.Visibility = Visibility.Hidden;
            imgTV.Opacity = 1;
        }

        private void btn2TV_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1TV.Visibility = Visibility.Visible;
            btn2TV.Visibility = Visibility.Visible;
            btn3TV.Visibility = Visibility.Visible;
            imgTV.Opacity = 0.1;
        }

        private void btn2TV_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1TV.Visibility = Visibility.Hidden;
            btn2TV.Visibility = Visibility.Hidden;
            btn3TV.Visibility = Visibility.Hidden;
            imgTV.Opacity = 1;
        }

        private void btn3TV_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1TV.Visibility = Visibility.Visible;
            btn2TV.Visibility = Visibility.Visible;
            btn3TV.Visibility = Visibility.Visible;
            imgTV.Opacity = 0.1;
        }

        private void btn3TV_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1TV.Visibility = Visibility.Hidden;
            btn2TV.Visibility = Visibility.Hidden;
            btn3TV.Visibility = Visibility.Hidden;
            imgTV.Opacity = 1;
        }

        private void btn2TV_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/TV.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Ы

        private void imgBL_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1BL.Visibility = Visibility.Visible;
            btn2BL.Visibility = Visibility.Visible;
            btn3BL.Visibility = Visibility.Visible;
            imgBL.Opacity = 0.1;

        }

        private void imgBL_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1BL.Visibility = Visibility.Hidden;
            btn2BL.Visibility = Visibility.Hidden;
            btn3BL.Visibility = Visibility.Hidden;
            imgBL.Opacity = 1;
        }

        private void btn1BL_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1BL.Visibility = Visibility.Visible;
            btn2BL.Visibility = Visibility.Visible;
            btn3BL.Visibility = Visibility.Visible;
            imgBL.Opacity = 0.1;
        }

        private void btn1BL_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1BL.Visibility = Visibility.Hidden;
            btn2BL.Visibility = Visibility.Hidden;
            btn3BL.Visibility = Visibility.Hidden;
            imgBL.Opacity = 1;
        }

        private void btn2BL_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1BL.Visibility = Visibility.Visible;
            btn2BL.Visibility = Visibility.Visible;
            btn3BL.Visibility = Visibility.Visible;
            imgBL.Opacity = 0.1;
        }

        private void btn2BL_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1BL.Visibility = Visibility.Hidden;
            btn2BL.Visibility = Visibility.Hidden;
            btn3BL.Visibility = Visibility.Hidden;
            imgBL.Opacity = 1;
        }

        private void btn3BL_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1BL.Visibility = Visibility.Visible;
            btn2BL.Visibility = Visibility.Visible;
            btn3BL.Visibility = Visibility.Visible;
            imgBL.Opacity = 0.1;
        }

        private void btn3BL_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1BL.Visibility = Visibility.Hidden;
            btn2BL.Visibility = Visibility.Hidden;
            btn3BL.Visibility = Visibility.Hidden;
            imgBL.Opacity = 1;
        }

        private void btn2BL_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/BL.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Ь

        private void imgMYA_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1MYA.Visibility = Visibility.Visible;
            btn2MYA.Visibility = Visibility.Visible;
            btn3MYA.Visibility = Visibility.Visible;
            imgMYA.Opacity = 0.1;

        }

        private void imgMYA_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1MYA.Visibility = Visibility.Hidden;
            btn2MYA.Visibility = Visibility.Hidden;
            btn3MYA.Visibility = Visibility.Hidden;
            imgMYA.Opacity = 1;
        }

        private void btn1MYA_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1MYA.Visibility = Visibility.Visible;
            btn2MYA.Visibility = Visibility.Visible;
            btn3MYA.Visibility = Visibility.Visible;
            imgMYA.Opacity = 0.1;
        }

        private void btn1MYA_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1MYA.Visibility = Visibility.Hidden;
            btn2MYA.Visibility = Visibility.Hidden;
            btn3MYA.Visibility = Visibility.Hidden;
            imgMYA.Opacity = 1;
        }

        private void btn2MYA_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1MYA.Visibility = Visibility.Visible;
            btn2MYA.Visibility = Visibility.Visible;
            btn3MYA.Visibility = Visibility.Visible;
            imgMYA.Opacity = 0.1;
        }

        private void btn2MYA_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1MYA.Visibility = Visibility.Hidden;
            btn2MYA.Visibility = Visibility.Hidden;
            btn3MYA.Visibility = Visibility.Hidden;
            imgMYA.Opacity = 1;
        }

        private void btn3MYA_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1MYA.Visibility = Visibility.Visible;
            btn2MYA.Visibility = Visibility.Visible;
            btn3MYA.Visibility = Visibility.Visible;
            imgMYA.Opacity = 0.1;
        }

        private void btn3MYA_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1MYA.Visibility = Visibility.Hidden;
            btn2MYA.Visibility = Visibility.Hidden;
            btn3MYA.Visibility = Visibility.Hidden;
            imgMYA.Opacity = 1;
        }

        private void btn2MYA_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/MYA.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Э

        private void imgEEE_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1EEE.Visibility = Visibility.Visible;
            btn2EEE.Visibility = Visibility.Visible;
            btn3EEE.Visibility = Visibility.Visible;
            imgEEE.Opacity = 0.1;

        }

        private void imgEEE_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1EEE.Visibility = Visibility.Hidden;
            btn2EEE.Visibility = Visibility.Hidden;
            btn3EEE.Visibility = Visibility.Hidden;
            imgEEE.Opacity = 1;
        }

        private void btn1EEE_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1EEE.Visibility = Visibility.Visible;
            btn2EEE.Visibility = Visibility.Visible;
            btn3EEE.Visibility = Visibility.Visible;
            imgEEE.Opacity = 0.1;
        }

        private void btn1EEE_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1EEE.Visibility = Visibility.Hidden;
            btn2EEE.Visibility = Visibility.Hidden;
            btn3EEE.Visibility = Visibility.Hidden;
            imgEEE.Opacity = 1;
        }

        private void btn2EEE_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1EEE.Visibility = Visibility.Visible;
            btn2EEE.Visibility = Visibility.Visible;
            btn3EEE.Visibility = Visibility.Visible;
            imgEEE.Opacity = 0.1;
        }

        private void btn2EEE_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1EEE.Visibility = Visibility.Hidden;
            btn2EEE.Visibility = Visibility.Hidden;
            btn3EEE.Visibility = Visibility.Hidden;
            imgEEE.Opacity = 1;
        }

        private void btn3EEE_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1EEE.Visibility = Visibility.Visible;
            btn2EEE.Visibility = Visibility.Visible;
            btn3EEE.Visibility = Visibility.Visible;
            imgEEE.Opacity = 0.1;
        }

        private void btn3EEE_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1EEE.Visibility = Visibility.Hidden;
            btn2EEE.Visibility = Visibility.Hidden;
            btn3EEE.Visibility = Visibility.Hidden;
            imgEEE.Opacity = 1;
        }

        private void btn2EEE_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/EEE.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Ю

        private void imgYU_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1YU.Visibility = Visibility.Visible;
            btn2YU.Visibility = Visibility.Visible;
            btn3YU.Visibility = Visibility.Visible;
            imgYU.Opacity = 0.1;

        }

        private void imgYU_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1YU.Visibility = Visibility.Hidden;
            btn2YU.Visibility = Visibility.Hidden;
            btn3YU.Visibility = Visibility.Hidden;
            imgYU.Opacity = 1;
        }

        private void btn1YU_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1YU.Visibility = Visibility.Visible;
            btn2YU.Visibility = Visibility.Visible;
            btn3YU.Visibility = Visibility.Visible;
            imgYU.Opacity = 0.1;
        }

        private void btn1YU_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1YU.Visibility = Visibility.Hidden;
            btn2YU.Visibility = Visibility.Hidden;
            btn3YU.Visibility = Visibility.Hidden;
            imgYU.Opacity = 1;
        }

        private void btn2YU_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1YU.Visibility = Visibility.Visible;
            btn2YU.Visibility = Visibility.Visible;
            btn3YU.Visibility = Visibility.Visible;
            imgYU.Opacity = 0.1;
        }

        private void btn2YU_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1YU.Visibility = Visibility.Hidden;
            btn2YU.Visibility = Visibility.Hidden;
            btn3YU.Visibility = Visibility.Hidden;
            imgYU.Opacity = 1;
        }

        private void btn3YU_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1YU.Visibility = Visibility.Visible;
            btn2YU.Visibility = Visibility.Visible;
            btn3YU.Visibility = Visibility.Visible;
            imgYU.Opacity = 0.1;
        }

        private void btn3YU_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1YU.Visibility = Visibility.Hidden;
            btn2YU.Visibility = Visibility.Hidden;
            btn3YU.Visibility = Visibility.Hidden;
            imgYU.Opacity = 1;
        }

        private void btn2YU_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/YU.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        //Буква Ю

        private void imgYA_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1YA.Visibility = Visibility.Visible;
            btn2YA.Visibility = Visibility.Visible;
            btn3YA.Visibility = Visibility.Visible;
            imgYA.Opacity = 0.1;

        }

        private void imgYA_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1YA.Visibility = Visibility.Hidden;
            btn2YA.Visibility = Visibility.Hidden;
            btn3YA.Visibility = Visibility.Hidden;
            imgYA.Opacity = 1;
        }

        private void btn1YA_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1YA.Visibility = Visibility.Visible;
            btn2YA.Visibility = Visibility.Visible;
            btn3YA.Visibility = Visibility.Visible;
            imgYA.Opacity = 0.1;
        }

        private void btn1YA_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1YA.Visibility = Visibility.Hidden;
            btn2YA.Visibility = Visibility.Hidden;
            btn3YA.Visibility = Visibility.Hidden;
            imgYA.Opacity = 1;
        }

        private void btn2YA_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1YA.Visibility = Visibility.Visible;
            btn2YA.Visibility = Visibility.Visible;
            btn3YA.Visibility = Visibility.Visible;
            imgYA.Opacity = 0.1;
        }

        private void btn2YA_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1YA.Visibility = Visibility.Hidden;
            btn2YA.Visibility = Visibility.Hidden;
            btn3YA.Visibility = Visibility.Hidden;
            imgYA.Opacity = 1;
        }

        private void btn3YA_MouseEnter(object sender, MouseEventArgs e)
        {
            btn1YA.Visibility = Visibility.Visible;
            btn2YA.Visibility = Visibility.Visible;
            btn3YA.Visibility = Visibility.Visible;
            imgYA.Opacity = 0.1;
        }

        private void btn3YA_MouseLeave(object sender, MouseEventArgs e)
        {
            btn1YA.Visibility = Visibility.Hidden;
            btn2YA.Visibility = Visibility.Hidden;
            btn3YA.Visibility = Visibility.Hidden;
            imgYA.Opacity = 1;
        }

        private void btn2YA_Click(object sender, RoutedEventArgs e)
        {
            var player = new MediaPlayer();
            player.Open(new Uri("audio/YA.mp3", UriKind.RelativeOrAbsolute));
            player.Play();
        }

        private void btn1A_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaA());
        }
        private void btn1B_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaB());
        }
        private void btn1V_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaV());
        }
        private void btn1G_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaG());
        }
        private void btn1D_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaD());
        }
        private void btn1E_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaE());
        }
        private void btn1EE_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaEe());
        }
        private void btn1J_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaJ());
        }
        private void btn1Z_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaZ());
        }
        private void btn1I_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaI());
        }
        private void btn1II_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaIi());
        }
        private void btn1K_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaK());
        }
        private void btn1L_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaL());
        }
        private void btn1M_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaM());
        }
        private void btn1H_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaN());
        }
        private void btn1O_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaO());
        }
        private void btn1P_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaP());
        }
        private void btn1R_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaR());
        }
        private void btn1C_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaS());
        }
        private void btn1T_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaT());
        }
        private void btn1U_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaU());
        }
        private void btn1F_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaF());
        }
        private void btn1X_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaX());
        }
        private void btn1CC_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaCe());
        }
        private void btn1CH_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaCh());
        }
        private void btn1SH_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaSh());
        }
        private void btn1SHH_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaSch());
        }
        private void btn1TV_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaTz());
        }
        private void btn1BL_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaIy());
        }
        private void btn1MYA_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaMz());
        }
        private void btn1EEE_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaEa());
        }
        private void btn1YU_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaYu());
        }
        private void btn1YA_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.BukvaYa());
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            AboutPage a = new AboutPage();
            a.Show();
            
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите закрыть программу?","asdasd", MessageBoxButton.YesNo) == System.Windows.MessageBoxResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
            }
            else
            {
                
            }
        }
    }
}
