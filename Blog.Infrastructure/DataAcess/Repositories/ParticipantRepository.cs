using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities.Participant;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Infrastructure.DataAcess.Repositories;

public class ParticipantRepository : IParticipantRepository
{
    private readonly ApplicationDbContext _dbCtx;

    public ParticipantRepository(ApplicationDbContext dbCtx)
    {
        _dbCtx = dbCtx;
    }

    public async Task DeleteAsync(UserId userId, PostId postId)
    {
        throw new NotImplementedException();
    }

    public async Task<ParticipantEntity> GetAsync(UserId userId, PostId postId)
    {
        throw new NotImplementedException();
    }

    public async Task SaveChangesAsync()
    {
        await _dbCtx.SaveChangesAsync();
    }
}
