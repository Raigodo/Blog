﻿using Blog.Domain.Base;
using Blog.Domain.Entities.Post;
using Blog.Domain.Entities.Post.Vo;
using Blog.Domain.Entities.User;
using Blog.Domain.Entities.User.Vo;

namespace Blog.Domain.Entities.Participant;

public sealed class ParticipantEntity : BaseEntity<PostId, UserId>
{
    private ParticipantEntity(PostId postId, UserId userId) : base(postId, userId) { }

    public PostId PostId => this.Left;  //BaseEntity protected property
    public UserId UserId => this.Right; //BaseEntity protected property
    public bool ReceiveNotifications { get; set; }

    //nullable to supress warnings about null to not-null conversion
    public PostEntity? Post { get; set; }
    public UserEntity? User { get; set; }

    public static ParticipantEntity Create(UserId userId, PostId postId)
    {
        var participant = new ParticipantEntity(postId, userId)
        {
            ReceiveNotifications = false,
        };

        return participant;
    }
}
