using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ecommerce_mvp_intro
{
    public class Elenco
    {
        private const int dimMax = 999;
        private int _idVerifiche = 0, _indiceInVettore = 0;
        private Verifica[] _verifiche;

        public Elenco()
        {
            _verifiche = new Verifica[dimMax];
        }

        public void OrdinaData()
        {

            for (int i = 0; i < this.IdVerifiche - 1; i++)
            {
                string[] fieldsI = _verifiche[i].Data.Split('-');
                for (int j = i + 1; j < this.IdVerifiche; j++)
                {
                    string[] fieldsI1 = _verifiche[j].Data.Split('-');
                    if (fieldsI[2] == fieldsI1[2])
                    {
                        if (fieldsI[1] == fieldsI1[1])
                        {
                            if (int.Parse(fieldsI[0]) > int.Parse(fieldsI1[0]))
                                ScambiaDate(i, j, _verifiche);
                        }
                        else
                        {
                            if (int.Parse(fieldsI[1]) > int.Parse(fieldsI1[1]))
                                ScambiaDate(i, j, _verifiche);
                        }
                    }
                    else
                    {
                        if (int.Parse(fieldsI[2]) > int.Parse(fieldsI1[2]))
                            ScambiaDate(i, j, _verifiche);

                    }
                }
            }

        }
        private int cercaIndice(int id)
        {
            for (int i = 0; i < _verifiche.Length; i++)
                if (_verifiche[i] != null && _verifiche[i].Id == id)
                    return i;

            return -1;
        }
        private void ScambiaDate(int indiceId1, int indiceId2, Verifica[] verifichette)
        {

            Verifica temp = verifichette[indiceId1];
            verifichette[indiceId1] = verifichette[indiceId2];
            verifichette[indiceId2] = temp;
        }
        public void ModificaVerifica(string materia, string data, float voto, int id)
        {
            if (id < this.IdVerifiche)
            {
                Verifica temp = new Verifica(cercaIndice(id), materia, data, voto);

                _verifiche[cercaIndice(id)] = temp;

            }
            else
                throw new Exception("Inserire un id valido");
        }
        public void EliminaVoto(int id)
        {
            if (id < this.IdVerifiche)
            {
                int indiceIDDD = cercaIndice(id);

                for (int i = indiceIDDD; i < dimMax - 1; i++) 
                    if (_verifiche[i] != null)
                        _verifiche[i] = _verifiche[i + 1];

                _verifiche[_verifiche.Length - 1] = null;


                for (int i = 0; i < dimMax - 1; i++)
                    if (_verifiche[i] != null && _verifiche[i].Id >= id)
                        _verifiche[i].Id--;

                this.IdVerifiche--;

            }
            else
                throw new Exception("Inserire un id valido");
        }
        public void AggiungiVerifica(string materia, string data, float voto)
        {
            Verifica temp = new Verifica(this.IdVerifiche, materia, data, voto);

            _verifiche[this.IndiceInVettore] = temp;

            
            this.IdVerifiche++;
            this.IndiceInVettore++;
        }

        public int IdVerifiche
        {
            get
            {
                return _idVerifiche;
            }
            private set
            {
                if (value < 999)
                    _idVerifiche = value;
                else
                    throw new Exception("L'array è pieno. Impossibile aggiungere");
            }
        }
        public int IndiceInVettore
        {
            get
            {
                return _indiceInVettore;
            }
            set
            {
                if (value >= 0)
                    _indiceInVettore = value;
                else
                    throw new Exception("Errore in IndiceInVettore");
            }
        }
        public Verifica[] Verifiche
        {
            get
            {
                Verifica[] temp = new Verifica[this.IdVerifiche];

                for (int i = 0; i < temp.Length; i++)
                    temp[i] = _verifiche[i];

                return temp;
            }
        }

        public string ToString(int indiceID)//
        {
            
            return $"{_verifiche[indiceID].Id};{_verifiche[indiceID].Materia};{_verifiche[indiceID].Data};{_verifiche[indiceID].Voto};";

        }

        public float CalcoloMedia(string materia)
        {
            if (materia != String.Empty)
            {
                float mediaTemp = 0;
                int count = 0;

                for (int i = 0; i < this.IdVerifiche; i++)
                {
                    if (_verifiche[i].Materia == materia.ToUpper())
                    {
                        mediaTemp += _verifiche[i].Voto;
                        count++;
                    }
                }

                if (count > 0)
                    return (mediaTemp / count);
                else
                    throw new Exception("Non è stato possibile trovare la materia inserita");
            }
            else
                throw new Exception("Inserire una materia");
        }
    }
}
