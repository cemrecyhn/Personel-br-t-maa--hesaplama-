using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelOdevProject
{
    public class PersonelBilgi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public string SicilNo { get; set; }
        public decimal BrutUcret { get; set; }
        public decimal SSKPrimiIsciPayi { get; set; }
        public decimal IssizlikSigortasiIsciPayi { get; set; }
        public decimal GelirVergisiMatrah { get; set; }
        public decimal GelirVergisiMiktar { get; set; }
        public decimal DamgaVergisiMiktari { get; set; }
        public decimal Kesinti { get; set; }
        public decimal NetUcret { get; set; }


        public PersonelBilgi Hesapla(decimal brutUcret)
        {
            
            PersonelBilgi personel = new PersonelBilgi();
            personel.SSKPrimiIsciPayi = (brutUcret * 14) / 100;
            personel.IssizlikSigortasiIsciPayi = (brutUcret * 1) / 100;
            personel.GelirVergisiMatrah = brutUcret - (personel.SSKPrimiIsciPayi + personel.IssizlikSigortasiIsciPayi);
            personel.GelirVergisiMiktar=(personel.GelirVergisiMatrah*15)/ 100;
            personel.DamgaVergisiMiktari=(brutUcret*759)/100000;
            personel.Kesinti = (personel.SSKPrimiIsciPayi + personel.IssizlikSigortasiIsciPayi  + personel.GelirVergisiMiktar+personel.DamgaVergisiMiktari);
            personel.NetUcret = brutUcret - personel.Kesinti;
            return personel;

        }
    }
}
