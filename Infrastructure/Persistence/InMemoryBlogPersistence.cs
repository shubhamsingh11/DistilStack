public class InMemoryBlogRepository : IBlogRepository
{
    private static readonly List<BlogPost> _blogs = new();

    public Task AddAsync(BlogPost blog)
    {
        _blogs.Add(blog);
        return Task.CompletedTask;
    }

    public Task<List<BlogPost>> GetAllAsync()
    {
        return Task.FromResult(_blogs.ToList());
    }
}