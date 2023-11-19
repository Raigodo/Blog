using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.Post.Vo;

namespace Blog.Infrastructure.DataAcess.Repositories;

public class PostRepository : IPostRepository
{
    private readonly ApplicationDbContext _dbCtx;

    public PostRepository(ApplicationDbContext dbCtx)
    {
        _dbCtx = dbCtx;
    }

    public async Task DeleteAsync(PostId postId)
    {
        throw new NotImplementedException();
    }

    public async Task<PostEntity> GetAsync(PostId postId)
    {
        throw new NotImplementedException();
    }

    public async Task SaveChangesAsync()
    {
        await _dbCtx.SaveChangesAsync();
    }
}
