using System.Collections.Generic;
using DesignPatterns_FactoryMethod_2.src.Produto;

namespace DesignPatterns_FactoryMethod_2.src
{
    public abstract class LanchesFactory
    {
        private List<Ingrediente> _ingredientes = new List<Ingrediente>();

        public List <Ingrediente> Ingredientes {get{ return _ingredientes;}}
        public int MyProperty { get; set; }       

        
        public LanchesFactory()
        {
            CriarLanche();
        }

        public abstract void CriarLanche();
        
         
    }
}