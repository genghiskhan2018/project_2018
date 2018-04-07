using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    
    public class Login
    {
        XML MyXML;
        public Login()
        {
            MyXML = new XML();
        }
        public void AgregarUsuario(string id_usuario, string clave)
        {
            MyXML._Añadir(id_usuario, clave, "0");
        }
        public string Verificar_Usuario(string id_usuario, string clave)
        {
            return MyXML.VerficarUsuarioLogin(id_usuario, clave);
        }
    }
}
