using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories;

public interface ITransmissonRepository : IAsyncRepository<Transmission, Guid>, IRepository<Transmission, Guid>
{

}
