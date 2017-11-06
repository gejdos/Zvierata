using System;

namespace Zvierata
{
    class Zviera
    {
        protected string rasa, farba;
        protected int vek;
        protected float vaha;
        private bool velke;
        private int pocetNoh;
        
        public Zviera(string rasa, string farba, int vek, float vaha, bool velke, int pocetNoh)
        {
            this.rasa = rasa;
            this.farba = farba;
            this.vek = vek;
            this.vaha = vaha;
            this.velke = velke;
            this.pocetNoh = pocetNoh;
        }

        public void VypisVlastnosti()
        {
            Console.WriteLine("Zviera ma tieto vlastnosti:\nrasa: {0}\nfarba: {1}\nvek: {2}\nvaha: {3}\nzviera je velke: {4}\npocet noh: {5}\n",
                rasa, farba, vek, vaha, velke, pocetNoh);
        }

        public void VydajZvuk()
        {
            Console.WriteLine("Zvuk zvierata:\nToto je vseobecny zvuk zvierata.\n");
        }
    }
}
