using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace WindowsFormsApplication1
{
    public enum TableNames { dt }

    #region 枚举
    public enum dt { id, z, x, y, d }
    #endregion

    public class DiTu_DB
    {
        private string _id;
        public string id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private int _z;
        public int z
        {
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            }
        }
        private int _x;
        public int x
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        private int _y;
        public int y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
        private int _d;
        public int d
        {
            get
            {
                return _d;
            }
            set
            {
                _d = value;
            }
        }

        private const String insertSqlTem = "INSERT INTO dt (id,x,y,z) VALUES ({0},{1},{2},{3})";

        public string GetInsertString()
        {
            return string.Format(insertSqlTem, id, x, y, z);
        }
    }
}
