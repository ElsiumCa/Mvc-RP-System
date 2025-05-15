using System.Collections.Generic;

namespace Elsiumc.Models
{
    public class PagingViewModel<T>
    {
        public IEnumerable<T> Items { get; set; }
        public int PageNo { get; set; }
        public int PageSize { get; set; }
        public int TotalRecords { get; set; }

        public PagingViewModel()
        {
            Items = new List<T>();
        }
    }
}