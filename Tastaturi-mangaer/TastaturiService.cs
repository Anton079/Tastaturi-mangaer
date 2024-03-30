using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tastaturi_mangaer
{
    public class TastaturiService
    {
        private List<Tastaturi> _tastaturi;

        public TastaturiService()
        {
            _tastaturi = new List<Tastaturi>();
            this.LoadData();
        }

        public void LoadData()
        {
            Tastaturi tastatura1 = new Tastaturi(1,"Logitech",100,true);
            Tastaturi tastatura2 = new Tastaturi(2,"Hyperx",60,false);
            Tastaturi tastatura3 = new Tastaturi(3,"Apple", 80,true);
            Tastaturi tastatura4 = new Tastaturi(4,"Samsung", 120, false);
            Tastaturi tastatura5 = new Tastaturi(5,"Marvo", 40,false);

            this._tastaturi.Add(tastatura1);
            this._tastaturi.Add(tastatura2);
            this._tastaturi.Add(tastatura3);
            this._tastaturi.Add(tastatura4);
            this._tastaturi.Add(tastatura5);
        }
    }
}
