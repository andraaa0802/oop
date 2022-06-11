using System;

namespace ArticleList
{
    internal class Article
    {
        string title, author, content;
        DateTime publication, lastUpdate;
        int likes, dislikes;

        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public string Content { get { return content; } set { content = value; } }
        public DateTime Publication { get => publication; }
        public DateTime LastUpdate { get => lastUpdate; }
        public int Likes { get => likes; }
        public int Dislikes { get => dislikes; }
       
        public Article (string title, string author, string content, DateTime publication, DateTime lastUpdate, int likes, int dislikes)
        {
            this.title = title;
            this.author = author;
            this.content = content;
            this.publication = publication;
            this.lastUpdate = lastUpdate;
            this.likes = likes;
            this.dislikes = dislikes;
        }
    }
}