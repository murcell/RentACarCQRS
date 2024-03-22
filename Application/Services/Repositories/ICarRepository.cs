using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface ICarRepository : IAsyncRespository<Car, Guid>, IRespository<Car, Guid>
{

}


