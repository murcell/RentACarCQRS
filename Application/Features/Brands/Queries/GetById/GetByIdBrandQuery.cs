using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Queries.GetById;

public class GetByIdBrandQuery:IRequest<GetByIdBrandResponse>
{
    public Guid Id { get; set; }
    public bool WithDeleted { get; set; } = false;

    public class GetByIdBrandQueryHandler : IRequestHandler<GetByIdBrandQuery, GetByIdBrandResponse>
    {
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;

        public GetByIdBrandQueryHandler(IMapper mapper, IBrandRepository brandRepository)
        {
            _mapper = mapper;
            _brandRepository = brandRepository;
        }

        public async Task<GetByIdBrandResponse> Handle(GetByIdBrandQuery request, CancellationToken cancellationToken)
        {
            Brand? brand = await _brandRepository.GetAsync(predicate: b => b.Id == request.Id, withDeleted:request.WithDeleted, cancellationToken: cancellationToken);
            GetByIdBrandResponse getByIdBrandResponse = _mapper.Map<GetByIdBrandResponse>(brand);
            return getByIdBrandResponse;
        }

    }
}
