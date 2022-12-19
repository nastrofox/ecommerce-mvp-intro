using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace Borelli_Verifica
{
    public class Verifica
    {
        private string _materia, _data;
        private int _id;
        private float _voto;

        public Verifica(int id, string materia, string data, float voto)
        {
            this.Id = id;
            this.Materia = materia;
            this.Data = data;
            this.Voto = voto;

        }

        //parte propertis 
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value >= 0)
                    _id = value;
                else
                    throw new Exception("Inserire un id valido");
            }
        }
        public string Materia
        {
            get
            {
                return _materia;
            }
            private set
            {
                if (value != String.Empty)
                    _materia = value.ToUpper();
                else
                    throw new Exception("Inserire una materia valida");
            }
        }
        public string Data
        {
            get
            {
                return _data;
            }
            set
            {
                Regex rx = new Regex("^[0-9]{1,2}-[0-9]{1,2}-[0-9]{2,4}$");
                if (value != String.Empty && rx.IsMatch(value))
                    _data = value;
                else
                    throw new Exception("Inserire la data in modo corretto [GG-MM-AAAA]");
            }
        }
        public float Voto
        {
            get
            {
                return _voto;
            }
            set
            {
                if (value <= 10 && value > 0)
                    _voto = value;
                else
                    throw new Exception("Inseire un voto valido compreso tra 0 e 10");
            }
        }
    }
}
