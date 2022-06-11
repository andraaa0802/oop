using System;
using System.Collections.Generic;
namespace ArticleList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();
            articles.Add(new Article("Cheesecake", "Samuel", "recipe", new DateTime(2008, 10, 8), new DateTime(2011, 11, 3), 1452, 23));
            articles.Add(new Article("Cheesecake with strawberry", "Samuel", "recipe", new DateTime(2008, 10, 8), new DateTime(2011, 11, 3), 1452, 23));
            articles.Add(new Article("Cheesecake with chocolate", "Samuel", "recipe", new DateTime(2008, 10, 8), new DateTime(2011, 11, 3), 1452, 23));
            articles.Add(new Article("Lava cake", "Ivan", "recipe", new DateTime(2015, 9, 3), new DateTime(2015, 9, 6), 4203, 74));
            articles.Add(new Article("Lava cake with vanilla", "Ivan", "recipe", new DateTime(2015, 9, 3), new DateTime(2015, 9, 6), 4203, 74));
            articles.Add(new Article("Chocolate pudding", "Mencia", "recipe", new DateTime(2018, 10, 20), new DateTime(2019, 4, 25), 385, 19));
            articles.Add(new Article("Vanilla pudding", "Mencia", "recipe", new DateTime(2018, 10, 20), new DateTime(2019, 4, 25), 385, 19));
            articles.Add(new Article("Gingerbread", "Isadora", "recipe", new DateTime(2020, 12, 22), new DateTime(2020, 12, 24), 2035, 254));
            articles.Add(new Article("Chia pudding", "Ari", "recipe", new DateTime(2021, 8, 12), new DateTime(2021, 9, 24), 985, 12));
            articles.Add(new Article("Tiramisu", "Rebe", "recipe", new DateTime(2020, 2, 8), new DateTime(2020, 5, 19), 7985, 84));
            articles.Add(new Article("Tiramisu with strawberry", "Rebe", "recipe", new DateTime(2020, 2, 8), new DateTime(2020, 5, 19), 7985, 84));

            filters.GetArticleByAuthor(articles, "Samuel");
            Console.WriteLine();
            filters.GetArticleByTitle(articles, "Tiramisu");
            Console.WriteLine();
            filters.GetArticleBetweenDates(articles, new DateTime(2010, 8, 12), new DateTime(2020, 12, 25));
            Console.WriteLine();
            filters.GetArticleFromWeekend(articles);
            Console.WriteLine();
            filters.GetArticlesChronological(articles);
            Console.WriteLine();
            filters.GetArticlesOrderedAscByLikes(articles);
            Console.WriteLine();
            filters.GetArticlesOrderedAscByDislikes(articles);
            Console.WriteLine();
            filters.GetAuthorsOrderedAscByNrOfArticles(articles);
        }
    }
}
