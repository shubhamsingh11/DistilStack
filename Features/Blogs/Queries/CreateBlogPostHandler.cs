using MediatR;

public class CreateBlogPostHandler : IRequestHandler<CreateBlogPostCommand, string>
{
    public Task<string> Handle(CreateBlogPostCommand request, CancellationToken cancellationToken)
    {
        return Task.FromResult(
        $"Blog '{request.Title}' created successfully.");
    }
}