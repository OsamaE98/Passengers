﻿using Passengers.Models.Base;
using Passengers.Models.Main;
using Passengers.Models.Security;
using Passengers.SharedKernel.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Passengers.Models.Shared
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string LogoPath { get; set; }

        public Guid? ParentId { get; set; }
        public Category Parent { get; set; }

        public ICollection<Category> Categories { get; set; }
        public ICollection<ShopCategory> ShopCategories { get; set; }
    }
}
