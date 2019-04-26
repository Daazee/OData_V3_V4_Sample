﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OData.Api.Models
{
    public class ODataContext : DbContext
    {
        public ODataContext(): base("name=ODataContext")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}