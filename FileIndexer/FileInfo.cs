using System;
namespace FileIndexer.Model
{
    class FileInfo : IDataInfo
    {
        public FileInfo(string Location, string Name, long Size)
        {

        }

        public FileInfo(string _location, string _name, long _size, string _type)
        {
            this._location = _location;
            this._name = _name;
            this._size = _size;
            this._type = _type;
        }

        private string _location;
        private string _name;
        private long _size;
        private string _type;

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
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        
    }
}
