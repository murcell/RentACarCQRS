using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface ITransmissionRepository : IAsyncRespository<Transmission, Guid>, IRespository<Transmission, Guid>
{

}


