using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Comment.Vo;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Infrastructure.DataAcess.Repositories;

public class CommentRepository : ICommentRepository
{
    private readonly ApplicationDbContext _dbCtx;

    public CommentRepository(ApplicationDbContext dbCtx)
    {
        _dbCtx = dbCtx;
    }

    public Task DeleteAsync(CommentId commentId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CommentEntity>> GetAll(PostId postId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CommentEntity>> GetAll(UserId postId)
    {
        throw new NotImplementedException();
    }

    public Task<CommentEntity> GetAsync(CommentId commentId)
    {
        throw new NotImplementedException();
    }

    public Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }
}
