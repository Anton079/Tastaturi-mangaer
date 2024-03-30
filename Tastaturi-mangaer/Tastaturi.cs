using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tastaturi_mangaer
{
    public class Tastaturi
    {
        private int _id;
        private string _model;
        private int _catLaSuta;
        private bool _disponibila;

        public Tastaturi(int id, string model, int catLaSuta, bool disponibila)
        {
            Id = id;
            Model = model;
            CatLaSuta = catLaSuta;
            Disponibila = disponibila;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int CatLaSuta
        {
            get { return _catLaSuta; }
            set { _catLaSuta = value; }
        }

        public bool Disponibila
        {
            get { return _disponibila; }
            set { _disponibila = value; }
        }

        public string TastaturiInfo()
        {
            string text = " ";
            text += "Id tastatura " + Id + "\n";
            text += "Model " + Model + "\n";
            text += "Cat la suta " + CatLaSuta + "\n";
            text += "Disponibila " + Disponibila + "\n";
            return text;
        }
    }
}
