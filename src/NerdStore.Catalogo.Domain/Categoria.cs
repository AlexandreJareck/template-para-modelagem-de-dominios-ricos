using NerdStore.Core.DomainObject;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }

        // EF Relation
        public ICollection<Produto> Produtos { get; set; }

        protected Categoria()
        { }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }
    }
}