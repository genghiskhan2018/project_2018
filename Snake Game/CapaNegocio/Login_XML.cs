using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    
    public class Login_XML
    {
        XML MyXML;
        public Login_XML()
        {
            MyXML = new XML();
        }
        public bool AgregarUsuario(string id_usuario, string clave)
        {
            return MyXML._Añadir(id_usuario, clave, "0");
        }
        public string Verificar_Usuario(string id_usuario, string clave)
        {
            return MyXML.VerficarUsuarioLogin(id_usuario, clave);
        }
    }
}
