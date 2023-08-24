using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Køretøjer;

// Det er ikke muligt, at en klasse arver direkte fra FLERE basisklasser.
// En måde man ville kunne løse dette på, ville fx være, at bruge grænseflader (interfaces) i stedet for flere baseklasser.
// 
internal class Bil : Køretøj //, FireHjulletKøretøj
{

    public int BagagerumVolumeKubikCm { get; }

    public const int SynInterval = 2;

    public Bil(string mærke, string model, int bagagerumVolume) : base(mærke, model)
    {

        BagagerumVolumeKubikCm = bagagerumVolume;

        
    }
}


