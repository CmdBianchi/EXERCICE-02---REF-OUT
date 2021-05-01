using System;
namespace EXERCICE_02___REF_OUT {
    //-----> INICIO
    ////////////////////////////////////////////////////////////////////////////////////////////
    class Program {
        static void Main(string[] args) {
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);
            Console.WriteLine(triple);         
        }
    }
    ////////////////////////////////////////////////////////////////////////////////////////////
    //-----> FIM
}
