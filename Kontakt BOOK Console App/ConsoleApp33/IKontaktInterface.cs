using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    interface IKontaktInterface
    {
        KontaktBookOzellikleri New(KontaktBookOzellikleri kontakt);
        KontaktBookOzellikleri Update(int Id, KontaktBookOzellikleri kontakt);
        bool Dalete(int Id);
        KontaktBookOzellikleri[] Read();
        KontaktBookOzellikleri Find(int Id);
        int FindId();
    }
}
