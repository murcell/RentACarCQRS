using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IFuelRepository : IAsyncRespository<Fuel, Guid>, IRespository<Fuel, Guid>
{

}


