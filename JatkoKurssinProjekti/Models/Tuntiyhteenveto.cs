using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JatkoKurssinProjekti.Models
{
    public class Tuntiyhteenveto
    {
        public int Tunti_id { get; set; }
        public int Henkilo_id { get; set; }
        public int Projekti_id { get; set; }
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Tunnit { get; set; }
        public string Pvm { get; set; }


    }
}