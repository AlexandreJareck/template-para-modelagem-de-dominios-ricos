using MediatR;

namespace NerdStore.Vendas.Application.Commands
{
    public class PedidoCommandHandler :
        IRequestHandler<AdicionarItemPedidoCommand, bool>

    {
        public Task<bool> Handle(AdicionarItemPedidoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}