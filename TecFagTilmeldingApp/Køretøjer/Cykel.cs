using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Køretøjer;

internal class Cykel : Køretøj
{

    public int PedalStørrelseCm { get; }

    public Cykel(string mærke, string model, int pedalStørrelse) : base(mærke, model)
    {

        PedalStørrelseCm = pedalStørrelse;


    }

    

}
