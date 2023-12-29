using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetProductListByBrandQueryHandler : IRequestHandler<GetProductListByBrandQuery, IList<ProductResponse>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductListByBrandQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IList<ProductResponse>> Handle(GetProductListByBrandQuery request, CancellationToken cancellationToken)
        {
            var prodList = await _productRepository.GetProductListByBrandAsync(request._brand);
            var prodListResponse = CustomMapper.Mapper.Map<IList<ProductResponse>>(prodList);

            return prodListResponse;
        }
    }
}
