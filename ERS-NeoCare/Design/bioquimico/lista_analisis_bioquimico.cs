﻿using ERS_NeoCare.Logic;
using ERS_NeoCare.Model;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace ERS_NeoCare.Design
{
    public partial class lista_analisis_bioquimico : UserControl
    {
  

      
       

        private AnalisisPresenter presenter;
     

        public lista_analisis_bioquimico()
        {

            InitializeComponent();
            presenter = new AnalisisPresenter(this, new AnalisisService());
            presenter.TraerAnalisis();
          
        }
        public void MostrarDatosPaciente(DataTable data)
        {
            DGVAdministrativo.DataSource = data;
        }



        private void DGVAdministrativo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVAdministrativo.Columns["acciones"].Index)
            {
        
          
         

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DGVAdministrativo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}