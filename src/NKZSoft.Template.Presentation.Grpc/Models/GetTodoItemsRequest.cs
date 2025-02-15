﻿namespace NKZSoft.Template.Presentation.Grpc.Models;

[ProtoContract]
public sealed record GetTodoItemsRequest : PageContext
{
    [ProtoMember(1)]
    public Guid[] Ids { get; init; } = Array.Empty<Guid>();
}
