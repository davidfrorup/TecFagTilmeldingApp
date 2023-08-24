using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.MySounds
{
    internal class MainLyd
    {


        public void MainAfspiller()
        {

            string myCurrentDir = System.IO.Directory.GetCurrentDirectory();
            string appDir = System.IO.Path.Combine(myCurrentDir, @"MySounds\Mainlyden.wav");

            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
            soundPlayer.SoundLocation = appDir;
            soundPlayer.Play();
        }   

    }
}
