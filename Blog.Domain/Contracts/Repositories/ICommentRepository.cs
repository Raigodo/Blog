using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Comment.Vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Contracts.Repositories;

public interface ICommentRepository
{
    public Task<CommentEntity> GetAsync(CommentId commentId);
    public Task DeleteAsync(CommentId commentId);
    public Task UpdateAsync(CommentEntity entity);

    public Task SaveChangesAsync();
}
