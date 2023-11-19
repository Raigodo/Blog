using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Comment.Vo;

namespace Blog.Infrastructure.DataAcess.Repositories;

public class CommentRepository : ICommentRepository
{
    private readonly ApplicationDbContext _dbCtx;

    public CommentRepository(ApplicationDbContext dbCtx)
    {
        _dbCtx = dbCtx;
    }

    public async Task DeleteAsync(CommentId commentId)
    {
        throw new NotImplementedException();
    }

    public async Task<CommentEntity> GetAsync(CommentId commentId)
    {
        throw new NotImplementedException();
    }

    public async Task SaveChangesAsync()
    {
        await _dbCtx.SaveChangesAsync();
    }
}
