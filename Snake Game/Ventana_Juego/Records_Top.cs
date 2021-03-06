﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Objetos;

namespace Ventana_Juego
{
    public partial class Records_Top : Form
    {
        Login_XML lg_xml;
        public Records_Top()
        {
            InitializeComponent();
            this.cbTipo.SelectedIndex = 0;
            lg_xml = new Login_XML();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (dtpInicio.Value <= dtpFinal.Value && chbUsarFecha.Checked)
            {
                List<Record> lista_record = lg_xml.Records();
                SepararFecha(lista_record);
            }
            if (!chbUsarFecha.Checked)
            {
                List<Record> lista_record = lg_xml.Records();
                OrdenarLista(lista_record);
            }
        }

        private void OrdenarLista(List<Record> lista_record)
        {
            switch (cbTipo.Text)
            {
                
                case "Puntuacion":
                    DataGridInfo(lista_record.OrderByDescending(x => x.Puntos).ToList());
                    break;
                case "Tiempo":
                    DataGridInfo(lista_record.OrderBy(x => x.Tiempo).ToList());
                    break;
                case "Movimientos":
                    DataGridInfo(lista_record.OrderBy(x => x.Movimientos).ToList());
                    break;
            }
        }

        private void DataGridInfo(List<Record> lista_record)
        {
            int i = 0;
            List<Record> lista_top = new List<Record>();
            lista_record.ForEach(delegate(Record item)
            {
                if (i < 10)
                {
                    lista_top.Add(item);
                    i++;
                }
            });
            dataGridView1.DataSource = lista_top;
        }

        private void SepararFecha(List<Record> lista_record)
        {
            OrdenarLista(lista_record.Where(item => dtpInicio.Value <= item.Fecha && dtpFinal.Value >= item.Fecha).ToList());
        }
    }
}

/*
List<Record> nueva_lista = new List<Record>();
            foreach (Record item in lista_record)
            {
                if (dtpInicio.Value <= item.Fecha && dtpFinal.Value >= item.Fecha)
                {
                    nueva_lista.Add(item);
                }
            }
*/
