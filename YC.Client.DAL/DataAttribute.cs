using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YC.Client.Data
{
    /// <summary>
    /// 通过model找到对应的Dal方法
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Method)]
    public class DataAttribute : Attribute
    {
        public string Data;

        public DataAttribute(string data)
        {
            this.Data = data;
        }
    }
}
