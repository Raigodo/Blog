using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Infrastructure.DataAcess.Repositories;

public class PostRepository : IPostRepository
{
    private readonly ApplicationDbContext _dbCtx;

    public PostRepository(ApplicationDbContext dbCtx)
    {
        _dbCtx = dbCtx;
    }

    public Task DeleteAsync(PostId postId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PostEntity>> GetAllAsync(UserId userId)
    {
        throw new NotImplementedException();
    }

    public Task<PostEntity> GetAsync(PostId postId)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
