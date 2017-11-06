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
            Console.WriteLine("Zviera ma tieto vlastnosti:\nrasa: {0}, farba: {1}, vek: {2}, vaha: {3}, zviera je velke: {4} a pocet noh: {5}\n",
                rasa, farba, vek, vaha, velke, pocetNoh);
        }

        public void VydajZvuk()
        {
            Console.WriteLine("Toto je vseobecny zvuk zvierata.\n");
        }
    }
}
