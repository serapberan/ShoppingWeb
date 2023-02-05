﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaretShooping.Areas.Admin.Models
{
    public class CurrencyApiViewModel  //api tarafındaki bilgiler
    {

        public Exchange_Rates[] exchange_rates { get; set; }
        public string base_currency_date { get; set; }
        public string base_currency { get; set; }

        public class Exchange_Rates
        {
            public string currency { get; set; }
            public string exchange_rate_buy { get; set; }
        }


    }
}
