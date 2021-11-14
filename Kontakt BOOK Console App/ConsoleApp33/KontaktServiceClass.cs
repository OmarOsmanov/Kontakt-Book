using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class KontaktServiceClass : IKontaktInterface
    {

        private KontaktBookOzellikleri[] Kontaks = new KontaktBookOzellikleri[0];

        public KontaktBookOzellikleri New(KontaktBookOzellikleri kontakt)
        {
            Array.Resize(ref Kontaks, Kontaks.Length + 1);
            Kontaks[Kontaks.Length - 1] = kontakt;
            return kontakt;
        }

        public bool Dalete(int Id)
        {
            Kontaks = Array.FindAll(Kontaks, a => a.ID! == Id);
            return true;
        }

        public KontaktBookOzellikleri Find(int Id)
        {
            KontaktBookOzellikleri kontaktbookozellikleri = Array.Find(Kontaks, a => a.ID == Id);
            return kontaktbookozellikleri;
        }

        public int FindId()
        {
            if (Kontaks.Length == 0)
            {
                return 1;
            }
            return Kontaks[Kontaks.Length - 1].ID + 1;
        }

        public KontaktBookOzellikleri[] Read()
        {
            return this.Kontaks;
        }

        public KontaktBookOzellikleri Update(int Id, KontaktBookOzellikleri kontakt)
        {
            KontaktBookOzellikleri updatekontakttOzellikleri = Array.Find(Kontaks, a => a.ID == Id);
            updatekontakttOzellikleri = kontakt;
            return updatekontakttOzellikleri;
        }
    }
}
