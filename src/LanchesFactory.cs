using System.Collections.Generic;
using DesignPatterns_FactoryMethod_2.src.Produto;

namespace DesignPatterns_FactoryMethod_2.src
{
    public abstract class LanchesFactory
    {
        public List<Ingrediente> Ingredientes { get{ return new List<Ingrediente>();} }
        private IEnumerable<Ingrediente> _ingredientes = new List<Ingrediente>();

        
        public LanchesFactory()
        {
            CriarLanche();
        }

        public abstract void CriarLanche();
        
         
    }
}