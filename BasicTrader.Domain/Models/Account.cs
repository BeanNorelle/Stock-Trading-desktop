using System;
using System.Collections.Generic;
using System.Text;

namespace BasicTrader.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public double balance { get; set; }
        public IEnumerable<AssetTransaction> AssetTransaction { get; set; }

    }
}


