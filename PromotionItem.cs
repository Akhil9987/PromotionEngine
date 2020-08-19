using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PromotionItem
    {
        public string Id { get; set; }
        public decimal UnitPrice { get; set; }
        public PromotionItem(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    UnitPrice = 50m;

                    break;
                case "B":
                    UnitPrice = 30m;

                    break;
                case "C":
                    UnitPrice = 20m;

                    break;
                case "D":
                    UnitPrice = 15m;
                    break;
            }
        }

    }
}

