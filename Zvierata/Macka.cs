using System;

namespace Zvierata
{
    class Macka : Zviera
    {
        private string oblubeneJedlo;

        public Macka(string rasa, string farba, int vek, float vaha, bool velke, int pocetNoh, string oblubeneJedlo) 
            : base(rasa, farba, vek, vaha, velke, pocetNoh)
        {
            this.oblubeneJedlo = oblubeneJedlo;
        }

        public new void VypisVlastnosti()
        {
            Console.WriteLine("Macka ma tieto vlastnosti:\nrasa: {0}, farba: {1}, vek: {2}, vaha: {3} a oblubene jedlo: {4}\n",
                rasa, farba, vek, vaha, oblubeneJedlo);
        }

        public new void VydajZvuk()
        {
            Console.WriteLine("Zvuk macky:\nMNAU.\n");
        }
    }
}
