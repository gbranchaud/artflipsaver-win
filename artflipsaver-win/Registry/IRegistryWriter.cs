using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtFlipSaver.Registry
{
    public interface IRegistryWriter
    {
        void WriteDword(string key, string dataName, int dataValue);
    }
}
