using Contracts;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class GetCurrencies : IGetCurrencies
    {
        public IList<Currency> GetCurrency()
        {
            return new List<Currency>();
        }
    }
}
