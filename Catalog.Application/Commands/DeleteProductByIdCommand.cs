using MediatR;

namespace Catalog.Application.Commands
{
    public class DeleteProductByIdCommand : IRequest<bool>
    {
        public readonly string _id;

        public DeleteProductByIdCommand(string id)
        {
            _id = id;
        }
    }
}
