using Blog.Domain.Contracts.Repositories;
using Blog.Domain.Entities.Comment;
using Blog.Domain.Entities.Comment.Dto;
using Blog.Domain.Entities.Comment.Vo;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Application.Services.Features;

public sealed class CommentingService
{
    private readonly IParticipantRepository _participantsRepo;

    public CommentingService(
        IParticipantRepository participantsRepo)
    {
        _participantsRepo = participantsRepo;
    }

    public CommentEntity CreateComment(UserId issuerId, CreateCommentDto dto)
    {
        throw new NotImplementedException();
    }

    public CommentEntity UpdateComment(UserId issuerId, UpdateCommentDto dto)
    {
        throw new NotImplementedException();
    }

    public void DeleteComment(UserId issuerId, PostId postId, CommentId commentId)
    {
        throw new NotImplementedException();
    }
}
