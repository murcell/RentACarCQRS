﻿using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories
{
    public interface IRefreshTokenRepository : IAsyncRepository<RefreshToken, long>, IRepository<RefreshToken, long>
    {
        Task<List<RefreshToken>> GetOldRefreshTokensAsync(long userId, int refreshTokenTTL);
    }
}
