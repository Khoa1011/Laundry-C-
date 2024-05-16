using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Doan
{
    internal interface IXuLy<T>
    {
        LinkedList<T> GetValues();

        T Find(String ID);
        bool AddList(T value);
        bool EditList(T value);
        bool DeleteList(String ID);

    }
}
