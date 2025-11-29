using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investigacion_Final
{
    public partial class Form1 : Form
    {
        List<int> datos = new List<int>();
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            datos.Clear();
            if (cmbTamaño .SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tamaño de conjunto de datos.");
                return;
            }
            int tamaño = int.Parse(cmbTamaño.SelectedItem.ToString());
            var sw = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < tamaño; i++)
            {
                datos.Add(rnd.Next(1, 10001));
            }
            sw.Stop();

            lblInfo.Text = $"Datos generados: {tamaño} elementos | Tiempo: {sw.ElapsedMilliseconds} ms";
        }
    }
}
