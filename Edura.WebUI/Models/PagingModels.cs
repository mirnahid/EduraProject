﻿using Edura.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Models
{
    public class PagingModels
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }
    }
    public class classProductListModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingModels PagingInfo { get; set; }
    }
}
