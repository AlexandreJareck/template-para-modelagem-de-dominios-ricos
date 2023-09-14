using MediatR;

namespace NerdStore.Catalogo.Domain.Events
{
    public class ProdutoEventHandler : INotificationHandler<ProdutoAbaixoEstoqueEvent>
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoEventHandler(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Handle(ProdutoAbaixoEstoqueEvent mensagem, CancellationToken cancellationToken)
        {
            var produto = _produtoRepository.ObterPorId(mensagem.AggregateId);

            // Aqui é somente um exemplo do pode agora com essa regra de negócio.
            // 1. Você pode enviar email
            // 2. Você pode enviar um whats app
            // Várias possibilidades...

            // Essa foi uma implementação de exemplo, no caso poderia existir varias regras de negocio, e essas regras seguirem essas estrutura.

            return;
        }
    }
}