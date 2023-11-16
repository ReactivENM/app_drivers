using System;
using System.Collections.Generic;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
using Models;
using Controllers;
using Drivers.Dictionary;

namespace app_drivers.Forms
{
    public partial class FormLot : Form
    {
        private List<LotModel> onTripLots = new List<LotModel>();
        private List<LotModel> deliveredLots = new List<LotModel>();

        public FormLot(int user_id)
        {
            InitializeComponent();
            listDeliveredLots.SelectedIndexChanged += lotsInTruck_SelectedItem;
            listOnTripLots.SelectedIndexChanged += lotsWithoutTruck_SelectedItem;

            fetchData(user_id);
        }

        public void fetchData(int user_id)
        {
            TruckController truckController = new TruckController();
            TruckModel truck = truckController.GetTruckByUserId(user_id);

            LotController lotController = new LotController();
            List<LotModel> lots = new List<LotModel>(lotController.GetAll(truck.id));
            foreach(LotModel lot in lots)
            {
                if(lot.estado == "entregado")
                {
                    deliveredLots.Add(lot);
                } else
                {
                    onTripLots.Add(lot);
                }
            }

            UpdateListBox(listDeliveredLots, deliveredLots);
            UpdateListBox(listOnTripLots, onTripLots);
        }

        private void btnMoveToDelivered_Click(object sender, EventArgs e)
        {
            if (listOnTripLots.SelectedItem != null)
            {
                var selectedLot = listOnTripLots.SelectedItem as dynamic;

                LotModel lot = onTripLots.Find(l => l.id == selectedLot.LoteId);
                deliveredLots.Add(lot);
                onTripLots.Remove(lot);

                UpdateListBox(listDeliveredLots, deliveredLots);
                UpdateListBox(listOnTripLots, onTripLots);

                LotController controller = new LotController();
                controller.MarkAsDelivered(lot.id, lot.id_almacen);

                btnMoveToDelivered.Enabled = (listOnTripLots.SelectedItem != null || listOnTripLots.Items.Count > 0);
                btnRemoveFromDelivered.Enabled = (listDeliveredLots.SelectedItem != null || listDeliveredLots.Items.Count > 0);
            }
        }

        private void btnRemoveFromDelivered_Click(object sender, EventArgs e)
        {
            if (listDeliveredLots.SelectedItem != null)
            {
                var selectedLot = listDeliveredLots.SelectedItem as dynamic;

                LotModel lot = deliveredLots.Find(l => l.id == selectedLot.LoteId);
                onTripLots.Add(lot);
                deliveredLots.Remove(lot);

                UpdateListBox(listDeliveredLots, deliveredLots);
                UpdateListBox(listOnTripLots, onTripLots);

                LotController controller = new LotController();
                controller.UnmarkAsDelivered(lot.id, lot.id_almacen);

                btnMoveToDelivered.Enabled = (listOnTripLots.SelectedItem != null || listOnTripLots.Items.Count > 0);
                btnRemoveFromDelivered.Enabled = (listDeliveredLots.SelectedItem != null || listDeliveredLots.Items.Count > 0);
            }
        }

        public class LoteItem
        {
            public string DisplayText { get; set; }
            public int LoteId { get; set; }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void UpdateListBox(KryptonListBox listBox, List<LotModel> lots)
        {
            Dictionaries dictionaries = new Dictionaries();
            Dictionary<string, string> warehouseSelect = dictionaries.DepartmentByWarehouseID();

            listBox.Items.Clear();
            foreach (LotModel lot in lots)
            {
                listBox.Items.Add(new LoteItem
                {
                    DisplayText = $"Lote #{lot.id} - A.Destino: {warehouseSelect[lot.id_almacen.ToString()]}",
                    LoteId = lot.id
                });
            }
            listBox.SelectedItem = null;
        }

        private void lotsInTruck_SelectedItem(object sender, EventArgs e)
        {
            btnRemoveFromDelivered.Enabled = (listDeliveredLots.SelectedItem != null);
        }

        private void lotsWithoutTruck_SelectedItem(object sender, EventArgs e)
        {
            btnMoveToDelivered.Enabled = (listOnTripLots.SelectedItem != null);
        }
    }
}
