using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Domain.Entities.Participant;

public class ParticipantEntity
{
    private ParticipantEntity(UserId userId, PostId postId)
    {
        UserId = userId;
        PostId = postId;
    }
    public UserId UserId { get; private init; }
    public PostId PostId { get; private init; }
    public bool ReceiveNotifications { get; set; }

    public static ParticipantEntity Create(UserId userId, PostId postId)
    {
        var participant = new ParticipantEntity(userId, postId)
        {
            ReceiveNotifications = false,
        };
        return participant;
    }
}
