﻿using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIGestaoAcademia
{
    public partial class FormTipoDeMoeda : Form
    {
        public TipoDeMoeda TipoMoeda { get; set; }
        public FormTipoDeMoeda()
        {
            InitializeComponent();
        }
    }
}
