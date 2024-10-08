using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Helpers
{
    public class QueryObject
    {
        public string? Symbol { get; set; } = null;
        public string? CompanyName { get; set; } = null;
        public string? SortBy { get; set; } = null;
        public bool? IsSortAscending { get; set; } = true;
        public int PageNumber { get; set; } = 1;
        public byte PageSize { get; set; } = 3;


    }
}