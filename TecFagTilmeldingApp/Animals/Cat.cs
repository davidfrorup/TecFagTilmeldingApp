using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Animals;

internal class Cat : Animals
{


    public override void MakeSound()
    {
        string myCurrentDir = System.IO.Directory.GetCurrentDirectory();
        string appDir = System.IO.Path.Combine(myCurrentDir, @"Animals\cat.wav");

        System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        soundPlayer.SoundLocation = appDir;
        soundPlayer.Play();
    }



}
