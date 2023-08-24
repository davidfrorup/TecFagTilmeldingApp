using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.Køretøjer;

internal class Køretøj
{
    public string Mærke { get; }
    public string Model { get; }


    public Køretøj(string mærke, string model)
    {
        Mærke = mærke;
        Model = model;
        
        
    }
}
