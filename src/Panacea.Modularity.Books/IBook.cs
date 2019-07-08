using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Books
{
    public interface IBook
    {
        string Language {get;set; }

        string Writer { get; set; }

        string Year { get; set; }

        string Isbn { get; set; }

        string Img { get; set; }

        string Description { get; set; }

        List<IDataUrl> DataUrl { get; set; }

    }

    public interface IDataUrl
    {
        string Url { get; set; }

        string DataType { get; set; }
    }
}
