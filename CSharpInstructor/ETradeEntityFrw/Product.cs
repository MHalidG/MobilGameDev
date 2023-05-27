using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETradeEntityFrw
{
    
    public class Product

        //Classlar Nesnedir diye de bakabiliriz
        //Contex dedigimiz unit of works desen
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public int StockAmount { get; set; }
    }
}
