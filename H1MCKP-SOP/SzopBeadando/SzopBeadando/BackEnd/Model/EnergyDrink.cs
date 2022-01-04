using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzopBeadando.BackEnd.Model
{
    public class EnergyDrink
    {
        private int _id;
        private string _brand;
        private string _coffein_amount;
        private string _model;
        private string _price;

        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }


        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string Coffein_Amount
        {
            get { return _coffein_amount; }
            set { _coffein_amount = value; }
        }


        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    }
}
