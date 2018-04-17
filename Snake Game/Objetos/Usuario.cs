using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Usuario
    {
        public Usuario(string is_usuario, int inicios_sesion)
        {
            this.is_usuario = is_usuario;
            this.inicios_sesion = inicios_sesion;
        }

        public string is_usuario { get; set; }
        public int inicios_sesion { get; set; }
    }
}
