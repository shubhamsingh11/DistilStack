public interface IBlogRepository
{
    Task AddAsync(BlogPost blog);
    Task<List<BlogPost>> GetAllAsync();
}