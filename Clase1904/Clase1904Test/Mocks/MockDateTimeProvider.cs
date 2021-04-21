using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase1904;

namespace Clase1904Test.Mocks
{
    public class MockDateTimeProvider : IDateTimeProvider
    {
        public DateTime Now()
        {
            return new DateTime(2021, 04, 19);
        }
    }
}
