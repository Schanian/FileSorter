using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSorterLibrary
{
    public class CounterRowComparer : IEqualityComparer<SearchData.ExactDuplicateRow>
    {
        public bool Equals(SearchData.ExactDuplicateRow x, SearchData.ExactDuplicateRow y)
        {
            return (x.ID == y.ID && x.FileName == y.FileName && x.Size == y.Size && x.LastModifiedTime == y.LastModifiedTime);
        }

        public int GetHashCode(SearchData.ExactDuplicateRow bx)
        {
            return bx.ID.GetHashCode();
        }
    }
}
