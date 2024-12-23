﻿using smp_api.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace smp_api.Dtos.Stock
{
    public class StockDto
    {

        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public string Industry { get; set; }
        public long MarketCap { get; set; }

    }
}