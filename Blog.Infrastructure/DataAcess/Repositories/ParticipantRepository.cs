using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities.Participant;
using Blog.Domain.Entities.Post;
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

    public Task DeleteAsync(UserId userId, PostId postId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PostEntity>> GetAllAsync(PostId postId)
    {
        throw new NotImplementedException();
    }

    public Task<ParticipantEntity> GetAsync(UserId userId, PostId postId)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
