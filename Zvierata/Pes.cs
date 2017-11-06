using System;

namespace Zvierata
{
    class Pes : Zviera
    {
        private bool strazny;

        public Pes(string rasa, string farba, int vek, float vaha, bool velke, int pocetNoh, bool strazny) 
            : base(rasa, farba, vek, vaha, velke, pocetNoh)
        {
            this.strazny = strazny;
        }

        public new void VypisVlastnosti()
        {
            Console.WriteLine("Pes ma tieto vlastnosti:\nrasa: {0}, farba: {1}, vek: {2}, vaha: {3} a informacia, ci je pes strazny: {4}\n",
                rasa, farba, vek, vaha, strazny);
        }

        public new void VydajZvuk()
        {
            Console.WriteLine("Zvuk psa:\nHAU.\n");
        }
    }
}
