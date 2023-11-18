using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Entities.Participant;

public class ParticipantEntity
{
    private ParticipantEntity(Guid userId, Guid postId)
    {
        UserId = userId;
        PostId = postId;
    }
    public Guid UserId { get; set; }
    public Guid PostId { get; set; }
    public bool ReceiveNotifications { get; set; }

    public ParticipantEntity Create(Guid userId, Guid postId)
    {
        var participant = new ParticipantEntity(userId, postId)
        {
            ReceiveNotifications = false,
        };
        return participant;
    }
}
