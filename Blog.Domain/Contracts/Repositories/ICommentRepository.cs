using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Comment.Vo;

namespace Blog.Domain.Contracts.Repositories;

public interface ICommentRepository
{
    public Task<CommentEntity> GetAsync(CommentId commentId);
    public Task DeleteAsync(CommentId commentId);

    public Task SaveChangesAsync();
}
