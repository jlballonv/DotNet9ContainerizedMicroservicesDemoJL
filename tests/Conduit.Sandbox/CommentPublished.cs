using System;

namespace Demo.Sandbox
{
    // Comment Added
    public class CommentPublished : IArticleEvent
    {
        public Guid ArticleId { get; set; }
    }
}