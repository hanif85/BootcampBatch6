using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        NewsAgency newsAgency = new NewsAgency();
        RegularReader reader1 = new RegularReader("Alice");
        RegularReader reader2 = new RegularReader("Bob");
        PremiumSubscriber premiumSubscriber = new PremiumSubscriber("John");

        newsAgency.ArticlePublished += reader1.OnNewArticlePublished;
        newsAgency.ArticlePublished += reader2.OnNewArticlePublished;
        newsAgency.ArticlePublished += premiumSubscriber.OnNewArticlePublished;

        newsAgency.PublishArticle(new Article("Breaking News", "Important update for all subscribers!"));
    }
}

class NewsAgency
{
    public event EventHandler<ArticleEventArgs> ArticlePublished;

    public void PublishArticle(Article article)
    {
        Console.WriteLine($"Publishing article: {article.Title}");
        ArticlePublished?.Invoke(this, new ArticleEventArgs(article));
    }
}

class ArticleEventArgs : EventArgs
{
    public Article Article { get; }

    public ArticleEventArgs(Article article)
    {
        Article = article;
    }
}

class Article
{
    public string Title { get; }
    public string Content { get; }

    public Article(string title, string content)
    {
        Title = title;
        Content = content;
    }
}

class RegularReader
{
    public string Name { get; }

    public RegularReader(string name)
    {
        Name = name;
    }

    public void OnNewArticlePublished(object sender, ArticleEventArgs e)
    {
        Console.WriteLine($"{Name} received a new article: {e.Article.Title}");
    }
}

class PremiumSubscriber
{
    public string Name { get; }

    public PremiumSubscriber(string name)
    {
        Name = name;
    }

    public void OnNewArticlePublished(object sender, ArticleEventArgs e)
    {
        Console.WriteLine($"{Name}, a premium subscriber, received a new article: {e.Article.Title}");
    }
}
