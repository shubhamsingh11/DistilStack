using MediatR;

public class GetAllBlogsHandler : IRequestHandler<GetAllBlogsQuery, List<BlogPost>>
{
    private IBlogRepository _repository;

    public GetAllBlogsHandler(IBlogRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<BlogPost>> Handle(GetAllBlogsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAllAsync();
    }
}