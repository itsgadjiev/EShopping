using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Application.Handlers
{
    public class GetAllProductTypesQueryHandler : IRequestHandler<GetAllProductTypesQuery, IList<ProductTypeResponse>>
    {
        private readonly ITypeRepository _typeRepository;

        public GetAllProductTypesQueryHandler(ITypeRepository typeRepository)
        {
            _typeRepository = typeRepository;
        }
        public async Task<IList<ProductTypeResponse>> Handle(GetAllProductTypesQuery request, CancellationToken cancellationToken)
        {
            var prodTypes =await _typeRepository.GetAllProductTypesAsync();

            var prodTypeResponse= CustomMapper.Mapper.Map<IList<ProductTypeResponse>>(prodTypes);
            return prodTypeResponse;
        }
    }
}
