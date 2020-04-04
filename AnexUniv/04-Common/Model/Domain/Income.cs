﻿using Common;
using Common.CustomFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Domain
{
    public class Income: AudityEntity, ISoftDeleted
    {
        public int Id { get; set; }
        public Enums.EntityType EntityType { get; set; }
        public Enums.IncomeType IncomeType { get; set; }
        public decimal Total { get; set; }
        public string EntityId { get; set; }
        public bool Deleted { get; set; }
    }
}