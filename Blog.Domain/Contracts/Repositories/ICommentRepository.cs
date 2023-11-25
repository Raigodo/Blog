using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Comment.Vo;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Domain.Contracts.Repositories;

public interface ICommentRepository
{
    public Task<IEnumerable<CommentEntity>> GetAll(PostId postId);
    public Task<IEnumerable<CommentEntity>> GetAll(UserId postId);
    public Task<CommentEntity> GetAsync(CommentId commentId);
    public Task DeleteAsync(CommentId commentId);

    public Task SaveChangesAsync();
}
