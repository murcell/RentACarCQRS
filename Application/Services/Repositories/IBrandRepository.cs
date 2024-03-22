using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface IBrandRepository:IAsyncRespository<Brand,Guid>, IRespository<Brand,Guid>
{

}
