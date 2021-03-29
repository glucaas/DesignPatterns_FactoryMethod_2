
using DesignPatterns_FactoryMethod_2.src;
using DesignPatterns_FactoryMethod_2.src.FactoriesConcretas;

namespace DesignPatterns_FactoryMethod_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LanchesFactory factory ;
            var pedido = System.Console.ReadLine();
            System.Console.WriteLine("asdasd");

            if(pedido == "frango")
                factory = new LancheFrango();
            else
                factory = new LancheCalabresa();

            factory.CriarLanche();
            System.Console.WriteLine("termino");
            
        }
    }
}
