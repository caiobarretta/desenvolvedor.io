using NerdStore.Core.Messages;
using System;

namespace NerdStore.Vendas.Application.Commands
{
    public partial class RemoverItemPedidoCommand : Command
    {
        public Guid ClienteId { get; private set; }
        public Guid ProdutoId { get; private set; }

        public RemoverItemPedidoCommand(Guid clienteId, Guid produtoId)
        {
            ClienteId = clienteId;
            ProdutoId = produtoId;
        }
        public override bool EhValido()
        {
            ValidationResult = new RemoverItemPedidoValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
