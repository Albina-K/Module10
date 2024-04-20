using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface ILogger
    {
        void Write () { Console.WriteLine("Hello! I am Logger!"); }
    }

    public interface IWriter
    {
        void Write() { Console.WriteLine("Hello! I am Writer!"); }
    }
    public class BuisnessLogic : IWriter, ILogger
    {

    }
}
