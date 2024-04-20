using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    internal class Worker1
    {
        ILogger Logger { get; } //перменная с модификатором гет
        public Worker1(ILogger logger) //конструктор с параметром интерфес айлоггер
        {

        }
    }
}
