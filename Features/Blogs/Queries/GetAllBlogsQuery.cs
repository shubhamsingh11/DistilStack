using MediatR;

public record GetAllBlogsQuery() : IRequest<List<BlogPost>>;