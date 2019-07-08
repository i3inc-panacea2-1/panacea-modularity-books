using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Books
{
    public interface IBooksPlugin : IPlugin
    {
        void OpenBook(IBook book, string pluginName);
    }
}
