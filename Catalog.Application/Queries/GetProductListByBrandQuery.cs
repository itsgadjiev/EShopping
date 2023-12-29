using Catalog.Application.Responses;
using MediatR;

namespace Catalog.Application.Queries
{
    public class GetProductListByBrandQuery : IRequest<IList<ProductResponse>>
    {
        public readonly string _brand;

        public GetProductListByBrandQuery(string brand)
        {
            _brand = brand;
        }
    }
}
