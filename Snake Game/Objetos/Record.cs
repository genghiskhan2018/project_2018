using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Record
    {
        public Record(string id_user, int movimientos, int modo,int nivel, int puntos, string tiempo, DateTime fecha)
        {
            this.Id_user = id_user;
            this.Movimientos = movimientos;
            this.Modo = modo;
            this.Nivel = nivel;
            this.Puntos = puntos;
            this.Tiempo = tiempo;
            this.Fecha = fecha;
        }

        public string Id_user { get; set; }
        public int Movimientos { get; set; }
        public int Modo{ get; set; }
        public int Nivel { get; set; }
        public int Puntos { get; set; }
        public string Tiempo { get; set; }
        public DateTime Fecha { get; set; }
    }
}
