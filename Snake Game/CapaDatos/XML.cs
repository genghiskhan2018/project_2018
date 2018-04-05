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
        
        public void _Añadir(string id, string clave, string inicios_sesion)
        {
            doc.Load(rutaXml);

            XmlNode usuario = _Crear_Empleado(id, clave, inicios_sesion);

            XmlNode nodoRaiz = doc.DocumentElement;

            nodoRaiz.InsertAfter(usuario, nodoRaiz.LastChild);

            doc.Save(rutaXml);


        }

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

        public string _ReadXml()
        {

            doc.Load(rutaXml);

            XmlNodeList listaUsuarios = doc.SelectNodes("Usuarios/usuario");

            XmlNode unUsu;

            string usuario = "";

            for (int i = 0; i < listaUsuarios.Count; i++)
            {

                unUsu = listaUsuarios.Item(i);

                string id = unUsu.SelectSingleNode("id_usuario").InnerText;
                string clave = unUsu.SelectSingleNode("clave").InnerText;
                string inicios_sesion = unUsu.SelectSingleNode("inicios_sesion").InnerText;
                usuario += (id + "," + clave + "," + inicios_sesion + Environment.NewLine);
            }

            return usuario;
        }

        public void _DeleteNodo(string id_borrar, string nodo)
        {
            doc.Load(rutaXml);

            XmlNode usuario = doc.DocumentElement;

            XmlNodeList listaUsuarios = doc.SelectNodes(nodo);

            foreach (XmlNode item in listaUsuarios)
            {

                if (item.SelectSingleNode("id_usuario").InnerText == id_borrar)
                {

                    XmlNode nodoOld = item;

                    usuario.RemoveChild(nodoOld);
                }
            }

            doc.Save(rutaXml);
        }

        public void _UpdateXml(string id_update, string clave, string inicios_sesion)
        {

            XmlElement usuarios = doc.DocumentElement;

            XmlNodeList listaUsuarios = doc.SelectNodes("Usuarios/usuario");

            XmlNode nuevo_usuario = _Crear_Empleado(id_update, clave, inicios_sesion);

            foreach (XmlNode item in listaUsuarios)
            {

                if (item.FirstChild.InnerText == id_update)
                {
                    XmlNode nodoOld = item;
                    usuarios.ReplaceChild(nuevo_usuario, nodoOld);

                }
            }

            doc.Save(rutaXml);
        }
    }
}
