﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ventas.BL;
using ventas.Modelos;

namespace ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var productosBL = new ProductosBL();
            listadeProductosBindingSource.DataSource = productosBL.ListadeProductos;

            var categoriasBL = new CategoriasBL();
            listadeCategoriasBindingSource.DataSource = categoriasBL.ListadeCategorias;
                       
            }
    }
}
