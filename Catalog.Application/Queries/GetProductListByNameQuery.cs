using Catalog.Application.Responses;
using MediatR;

namespace Catalog.Application.Queries
{
    public class GetProductListByNameQuery : IRequest<IList<ProductResponse>>
    {
        public string Name { get; set; }
        public GetProductListByNameQuery(string name)
        {
            Name = name;
        }
    }
}
