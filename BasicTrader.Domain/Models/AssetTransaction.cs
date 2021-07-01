using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTrader.Domain.Models
{
    public class AssetTransaction
    {
        public int Id { get; set; }
        public Account Account { get; set; }
        public Stock Stock { get; set; }
        public bool IsPurchase { get; set; }
        public int Shares { get; set; }
        public DateTime DateProcessed { get; set; }
    }
}
