using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodService : IProizvodiService
    {
        List<Proizvodi> newList = new List<Proizvodi>()
        {
            new Proizvodi()
            {
                ProizvodId=1,
                Naziv="Laptopi"
            }
        };

        public IList<Proizvodi> Get()
        {
           return newList;
        }
    }
}
