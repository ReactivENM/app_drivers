using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Models;

namespace app_drivers.Forms
{
    public partial class FormTruck : Form
    {
        public FormTruck(int user_id)
        {
            InitializeComponent();
            fetchData(user_id);
        }

        public void fetchData(int user_id)
        {
            TruckController controller = new TruckController();
            TruckModel truck = controller.GetTruckByUserId(user_id);

            lblMarca.Text = truck.marca;
            lblModelo.Text = truck.modelo;
            lblMatricula.Text = truck.matricula;
            lblCapacidad.Text = $"{truck.capacidad} Toneladas";
        }
    }
}
