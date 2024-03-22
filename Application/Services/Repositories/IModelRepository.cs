using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IModelRepository : IAsyncRespository<Model, Guid>, IRespository<Model, Guid>
{

}


