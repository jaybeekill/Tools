using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvChecker
{
    public class DtoResult
    {
        public int NbColumn { get; set; }
        public string Content { get; set; }
    }

    public class DtoResults: List<DtoResult>
    {
    }
}
