using MediatR;

public record CreateBlogPostCommand(
    string Title,
    string Content
) : IRequest<string>;