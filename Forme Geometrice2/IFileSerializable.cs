using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme_Geometrice2
{
    public interface IFileSerializable
    {
        void SaveToFile(string fileName);
        void LoadFromFile(string fileName);
    }
}
