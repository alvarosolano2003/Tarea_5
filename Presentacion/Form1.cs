using Domain.Interfaces;
using Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmDepreciacion : Form
    {
        public BaseRepository obj;
        public FrmDepreciacion(IBase obj)
        {
            this.obj = obj;
            InitializeComponent();
        }

        private void BtnActivo_Click(object sender, EventArgs e)
        {

        }
    }
}
