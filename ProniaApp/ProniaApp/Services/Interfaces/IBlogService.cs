﻿using ProniaApp.Models;

namespace ProniaApp.Services.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetAllAsync();
        Task<Blog> GetByIdAsync(int? id);
        Task<Blog> GetByIdTrackAsync(int? id);
        Task<BlogImage> GetImageById(int? id);
        void RemoveImage(BlogImage img);
        Task<Blog> GetBlogByImageId(int? id);
        void AddRangeToBlog(List<BlogImage> images);
        Task<List<Blog>> GetPaginatedDatasAsync(int page, int take);
        Task<int> GetCountAsync();
        Task<List<BlogComment>> GetComments();
        Task<BlogComment> GetCommentById(int? id);
        Task<BlogComment> GetCommentByIdWithBlog(int? id);
    }
}
