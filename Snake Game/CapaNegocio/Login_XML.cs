using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Objetos;

namespace CapaNegocio
{

    public class Login_XML
    {
        XML MyXML;
        XML_DatosJuegos XML_dj;
        public Login_XML()
        {
            MyXML = new XML();
            XML_dj = new XML_DatosJuegos();
        }
        public bool AgregarUsuario(string id_usuario, string clave)
        {
            return MyXML._Añadir(id_usuario, clave, "0");
        }

        public string Verificar_Usuario(string id_usuario, string clave)
        {
            return MyXML.VerficarUsuarioLogin(id_usuario, clave);
        }

        public List<Record> Records()
        {
            List<Record> listarecords = XML_dj.ObtenerInformacion();
            return listarecords;
        }

        public void AgregarRecord(string id_user, int movimientos, int modo,int lev, string puntos, string tiempo)
        {
            XML_dj._Añadir(id_user, movimientos, modo, lev, puntos, tiempo);
        }

        public object Inicios_Sesion()
        {
            return MyXML.LeerInfo().OrderByDescending(item => item.inicios_sesion).ToList();
        }

        public string Modo_Jugado()
        {
            int modo1 = 0, modo2 = 0, modo3 = 0;
            List<Record> lista_records = Records();
            modo1 = lista_records.Where(item => item.Modo == 1).Count();
            modo2 = lista_records.Where(item => item.Modo == 2).Count();
            modo3 = lista_records.Where(item => item.Modo == 3).Count();
            if (modo1 >= modo2 && modo1 >= modo3)
            {
                return "1";
            }
            else if (modo2 >= modo1 && modo2 >= modo3)
            {
                return "2";
            }
            else
            {
                return "3";
            }
        }

        public List<Record> UltimoNivelSup()
        {
            List<Record> lista = Records();
            return lista.Where(item => item.Nivel == 3 && item.Puntos == 10).ToList();
        }
    }
}
