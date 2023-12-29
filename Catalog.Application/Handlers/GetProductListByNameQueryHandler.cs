using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetProductListByNameQueryHandler : IRequestHandler<GetProductListByNameQuery, IList<ProductResponse>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductListByNameQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IList<ProductResponse>> Handle(GetProductListByNameQuery request, CancellationToken cancellationToken)
        {
            var prodList = await _productRepository.GetProductListByNameAsync(request.Name);
            var prodListResponse = CustomMapper.Mapper.Map<IList<ProductResponse>>(prodList);

            return prodListResponse;
        }
    }
}
