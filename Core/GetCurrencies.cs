using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class GetCurrencies : IGetCurrencies
    {
        public IList<string> GetCurrency()
        {
            return new List<string>();
        }
    }
}
