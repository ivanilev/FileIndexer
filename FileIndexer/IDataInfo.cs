using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileIndexer.Model
{
    public interface IDataInfo
    {
        string Name { get; set; }
        long Size { get; set; }
        string Location { get; set; }
    }
}
