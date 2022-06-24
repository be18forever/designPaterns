using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05BuilderPattern.KeyValueCollection
{
    public interface IKeyValueCollectionBuilder
    {
        IKeyValueCollectionBuilder Add(string key, string value);
    }
}
