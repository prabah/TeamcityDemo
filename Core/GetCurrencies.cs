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
            var currencies = new List<Currency>();

            currencies.Add(new Currency { Id = 1, Code = "USD", Rate = 1.16f });
            currencies.Add(new Currency { Id = 2, Code = "AUD", Rate = 0.87f });
            currencies.Add(new Currency { Id = 3, Code = "CAD", Rate = 1.45f });
            currencies.Add(new Currency { Id = 4, Code = "CHF", Rate = 1.92f });

            return currencies;
        }
    }
}
