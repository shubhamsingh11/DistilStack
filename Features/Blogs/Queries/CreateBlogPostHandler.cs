using MediatR;

public class CreateBlogPostHandler : IRequestHandler<CreateBlogPostCommand, Guid>
{
    private readonly IBlogRepository _repository;

    public CreateBlogPostHandler(IBlogRepository repository)
    {
        _repository = repository;
    }
    public async Task<Guid> Handle(CreateBlogPostCommand request, CancellationToken cancellationToken)
    {
        var blog = new BlogPost(request.Title, request.Content);
        await _repository.AddAsync(blog);

        return blog.Id;
    }
}