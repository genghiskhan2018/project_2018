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
        XML MyXML = new XML();
        public Login()
        {
            MyXML.Cargar_XML();
        }
    }
}
