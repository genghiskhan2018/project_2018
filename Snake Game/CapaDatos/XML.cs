using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CapaDatos
{
    public class XML
    {
        XmlDocument doc;
        string rutaXml;

        public void Cargar_XML()
        {

            this.rutaXml = "Usuario.xml";
            doc = new XmlDocument();
            doc.Load(rutaXml);
            
        }
        /// <summary>
        /// Crea un nuevo usuario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clave"></param>
        /// <param name="inicios_sesion"></param>
        /// <returns>Retorna un booleano para saber si fue creado o no</returns>
        public bool _Añadir(string id, string clave, string inicios_sesion)
        {
            doc.Load(rutaXml);

            if (!VerificarNombre(id))
            {
                XmlNode usuario = _Crear_Empleado(id, clave, inicios_sesion);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(usuario, nodoRaiz.LastChild);

                doc.Save(rutaXml);

                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// Verifica que el nombre no se repita con el nuevo
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna un booleano para saber si esta repetido o no</returns>
        private bool VerificarNombre(string id)
        {
            doc.Load(rutaXml);
            XmlNodeList listaUsuarios = doc.SelectNodes("Usuarios/usuario");
            XmlNode unUsu;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                unUsu = listaUsuarios.Item(i);
                if (unUsu.SelectSingleNode("id_usuario").InnerText.Equals(id)) return true;
            }
            return false;
        }
        /// <summary>
        /// Crea un usuario tipo XMLNode con la informacion recibida por parametro
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clave"></param>
        /// <param name="inicios_sesion"></param>
        /// <returns>Retorna un XMLNode para ser agregado a un archivo xml</returns>
        private XmlNode _Crear_Empleado(string id, string clave, string inicios_sesion)
        {
            XmlNode usuario = doc.CreateElement("usuario");
            XmlElement xid = doc.CreateElement("id_usuario");
            xid.InnerText = id;
            usuario.AppendChild(xid);

            XmlElement xclave = doc.CreateElement("clave");
            xclave.InnerText = clave;
            usuario.AppendChild(xclave);
            
            XmlElement xcantinicios = doc.CreateElement("inicios_sesion");
            xcantinicios.InnerText = inicios_sesion;
            usuario.AppendChild(xcantinicios);
            
            return usuario;
        }
        /// <summary>
        /// Este metodo verifica que el usuario y la contraseña sean iguales
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clave"></param>
        /// <returns>Y retorna el id del usuario si es correcto</returns>
        public string VerficarUsuarioLogin(string id, string clave)
        {
            doc.Load(rutaXml);
            XmlNodeList listaUsuarios = doc.SelectNodes("Usuarios/usuario");
            XmlNode unUsu;
            XmlNode unUsupdate;
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                unUsu = listaUsuarios.Item(i);
                int incios = int.Parse(unUsu.SelectSingleNode("inicios_sesion").InnerText);
                if (unUsu.SelectSingleNode("id_usuario").InnerText.Equals(id) && unUsu.SelectSingleNode("clave").InnerText.Equals(clave))
                {
                    unUsupdate = _Crear_Empleado(id, clave, (incios++).ToString());
                    ModificarIniciosSesion(unUsupdate);
                    return id;
                }
            }
            return "";
        }
        /// <summary>
        /// Le suma la cantidad de inicios de sesion al usuario por ingresar al juego
        /// </summary>
        /// <param name="unUsupdate"></param>
        private void ModificarIniciosSesion(XmlNode unUsupdate)
        {
            try
            {
                doc.Load(rutaXml);
                XmlElement usuarios = doc.DocumentElement;
                XmlNodeList listaUsuarios = doc.SelectNodes("Usuarios/usuario");
                foreach (XmlNode item in listaUsuarios)
                {
                    if (item.FirstChild.InnerText.Equals(unUsupdate.SelectSingleNode("id_usuario").InnerText))
                    {
                        XmlNode nodoOld = item;
                        usuarios.ReplaceChild(unUsupdate, nodoOld);
                    }
                }
                doc.Save(rutaXml);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
    