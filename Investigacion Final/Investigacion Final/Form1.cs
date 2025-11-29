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
    public partial class FranklinC : Form
    {
        List<int> datos = new List<int>();
        Random rnd = new Random();

        public FranklinC()
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int BusquedaLineal (int objetivo)
        {
            for (int i = 0; i < datos.Count; i++)
            {
                if (datos[i] == objetivo)
                    return i;
            }
            return -1;
        }
        int BusquedaBinaria(int objetivo)
        {
            datos.Sort();
            int izquierda = 0;
            int derecha = datos.Count - 1;
            while (izquierda <= derecha)
            {
                int medio = izquierda + (derecha - izquierda) / 2;
                if (datos[medio] == objetivo)
                    return medio;
                if (datos[medio] < objetivo)
                    izquierda = medio + 1;
                else
                    derecha = medio - 1;
            }
            return -1;
        }
        void InsertionSort(List <int>arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        void QuickSort(List<int> arr, int low, int high)
        {
            if (low < high)
            {
                int p = Particion(arr, low, high);
                QuickSort(arr, low, p - 1);
                QuickSort(arr, p + 1, high);
            }
        }


        int Particion(List<int> arr, int low, int high)
        {
            int pivote = arr[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivote)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }

            (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]);
            return i + 1;
        }




        private void btnLineal_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Ingrese un número a buscar.");
                return;
            }
            int buscar = int.Parse (txtBuscar.Text);
            var sw = System.Diagnostics.Stopwatch.StartNew();
            int index = BusquedaLineal(buscar);
            sw.Stop();
            lblResultado.Text = $"Lineal → Posición: {index} | Tiempo: {sw.ElapsedMilliseconds} ms";
        }
    }
}
