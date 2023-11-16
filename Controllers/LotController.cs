using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{

    public class LotController
    {
        private LotModel model;

        public LotController()
        {
            LotModel m = new LotModel();
            model = m;
        }

        public List<LotModel> GetAll(int id_camion)
        {
            return model.GetAll(id_camion);
        }

        public bool MarkAsDelivered(int id, int id_almacen)
        {
            return model.MarkAsDelivered(id, id_almacen);
        }

        public bool UnmarkAsDelivered(int id, int id_almacen)
        {
            return model.UnmarkAsDelivered(id, id_almacen);
        }
    }

}
