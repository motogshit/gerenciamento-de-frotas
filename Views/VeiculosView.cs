using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemasfrotas.Views
{
    public partial class VeiculosView : UserControl
    {
        private static VeiculosView _instance;

        public static VeiculosView Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VeiculosView();
                    return _instance;
                }
                else
                {
                    return _instance;
                }
            }
        }
        public VeiculosView()
        {
            InitializeComponent();
        }
    }
}
