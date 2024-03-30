using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tastaturi_mangaer
{
    public class Inchiriere
    {
        private int _id;
        private int _idUser;
        private int _idTastaura;

        public Inchiriere(int id, int idUser, int idTastatura)
        {
            Id = id;
            IdUser = idUser;
            IdTastatura = idTastatura;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        public int IdTastatura
        {
            get { return _idTastaura; }
            set { _idTastaura = value; }
        }

        public string InchiriereInfo()
        {
            string text = " ";
            text += "Idul" + Id + "\n";
            text += "Idul User " + IdUser + "\n";
            text += "Id Tastatura" + IdTastatura + "\n";
            return text;
        }

    }
}
