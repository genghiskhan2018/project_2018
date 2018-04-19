using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Objetos;

namespace CapaDatos
{
    public class XML_DatosJuegos
    {
        XmlDocument doc;
        string rutaXml;

        public XML_DatosJuegos()
        {

            this.rutaXml = "Datos.xml";
            doc = new XmlDocument();
            doc.Load(rutaXml);
        }

        public void _Añadir(string id_user,int movimientos, int modo, int lev, string puntos,string tiempo)
        {
            doc.Load(rutaXml);
            
                XmlNode record = CrearRecord(id_user, movimientos, modo, lev, puntos, tiempo);

                XmlNode nodoRaiz = doc.DocumentElement;

                nodoRaiz.InsertAfter(record, nodoRaiz.LastChild);

                doc.Save(rutaXml);
        }

        private XmlNode CrearRecord(string id_user, int movimientos, int modo, int lev, string puntos, string tiempo)
        {
            XmlNode record = doc.CreateElement("record");
            XmlElement xid = doc.CreateElement("id_usuario");
            xid.InnerText = id_user;
            record.AppendChild(xid);


            XmlElement xmovimientos = doc.CreateElement("movimientos");
            xmovimientos.InnerText = movimientos.ToString();
            record.AppendChild(xmovimientos);

            XmlElement xmodo = doc.CreateElement("modo");
            xmodo.InnerText = modo.ToString();
            record.AppendChild(xmodo);

            XmlElement xnivel = doc.CreateElement("nivel");
            xnivel.InnerText = lev.ToString();
            record.AppendChild(xnivel);

            XmlElement xpuntos = doc.CreateElement("puntos");
            xpuntos.InnerText = puntos;
            record.AppendChild(xpuntos);

            XmlElement xtiempo = doc.CreateElement("tiempo");
            xtiempo.InnerText = tiempo;
            record.AppendChild(xtiempo);

            XmlElement xfecha = doc.CreateElement("fecha");
            xfecha.InnerText = System.DateTime.Now.ToString("yyyy-MM-dd");
            record.AppendChild(xfecha);

            return record;
        }

        public List<Record> ObtenerInformacion()
        {
            List<Record> listarecord = new List<Record>();
            doc.Load(rutaXml);

            XmlNodeList listaRecords = doc.SelectNodes("Records/record");

            XmlNode unRecor;
            
            for (int i = 0; i < listaRecords.Count; i++)
            {
                unRecor = listaRecords.Item(i);
                string id_user = unRecor.SelectSingleNode("id_usuario").InnerText;
                int movimientos = int.Parse(unRecor.SelectSingleNode("movimientos").InnerText);
                int modo = int.Parse(unRecor.SelectSingleNode("modo").InnerText);
                int nivel = int.Parse(unRecor.SelectSingleNode("nivel").InnerText);
                int puntos = int.Parse(unRecor.SelectSingleNode("puntos").InnerText);
                string tiempo = unRecor.SelectSingleNode("tiempo").InnerText;
                DateTime fecha = DateTime.ParseExact(unRecor.SelectSingleNode("fecha").InnerText, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                listarecord.Add(new Record(id_user, movimientos, modo, nivel, puntos, tiempo, fecha));
            }

            return listarecord;
        }
    }
}
