using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIndexer.Model
{
    public class FolderInfo : IDataInfo
    {
        public FolderInfo(string _location, string _name, long _size)
        {
            this._location = _location;
            this._name = _name;
            this._size = _size;
        }

        private string _location;
        private string _name;
        private long _size;
        private List<IDataInfo> _containingData;


        public List<IDataInfo> Information
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        public string Location
        {
            get
            {
                return _location;
            }

            set
            {
                _location = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public long Size
        {
            get
            {
                return _size;
            }

            set
            {
                _size = value;
            }
        }
    }
}
