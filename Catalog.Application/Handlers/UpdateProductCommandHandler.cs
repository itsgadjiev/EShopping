﻿using Catalog.Application.Commands;
using Catalog.Core.Entities;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<bool> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var productEntity = await _productRepository.UpdateProductAsync(new Product
            {
                Id = request.Id,
                Description = request.Description,
                ImageURL = request.ImageFile,
                Name = request.Name,
                Price = request.Price,
                Summary = request.Summary,
                ProductBrands = request.Brands,
                ProductTypes = request.Types
            });

            return productEntity;
        }
    }
}
