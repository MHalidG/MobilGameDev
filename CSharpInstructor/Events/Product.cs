using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{


    public delegate void StockControl();

    public class Product
    {
        private int _Stock;
        public Product(int Stock) { 
        _Stock = Stock;        
        }

        public event StockControl StockControlEvent;

        public string UrunIsmi { get; set; }

        public int Stock { get {
            return _Stock;
            } set { 
            _Stock = value;
                if (value <= 15 && StockControlEvent != null) {
                    StockControlEvent();
                }
            } }

        public void Sell(int amount) {
        Stock-=amount;

            Console.WriteLine("{1} Stock Amount : {0}",Stock,UrunIsmi);
        
        }

    }
}
