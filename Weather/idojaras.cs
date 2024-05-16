using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    internal class idojaras
    {
        public string Varos {  get; set; }
        public double Homerseklet { get; set;}
        public int Paratartalom { get; set; }
       

        public idojaras(string sorok)
        {
            var sor= sorok.Split(';');
            Varos = sor[0];
            Homerseklet = Convert.ToDouble(sor[1]);
            Paratartalom = Convert.ToInt32(sor[2]);
            
                
        }
    }
}
