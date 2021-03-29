using DesignPatterns_FactoryMethod_2.src.Produto;

namespace DesignPatterns_FactoryMethod_2.src.FactoriesConcretas
{
    public class LancheFrango : LanchesFactory
    {
        public override void CriarLanche()
        {
            this.Ingredientes.Add(new Queijo());
            this.Ingredientes.Add(new Frango());
            this.Ingredientes.Add(new Pao());
            this.Ingredientes.Add(new Oregano());

        }
    }
}