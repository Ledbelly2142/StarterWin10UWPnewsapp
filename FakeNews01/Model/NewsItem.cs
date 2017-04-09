using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeNews01.Model
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }

    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItem();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));

        }

        private static List<NewsItem> getNewsItem()
        {
            var items = new List<NewsItem>();
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "This Just In", Subhead = "Brilliant New Things!", DateLine = "4/5/17", Image = "Assets/Financial1.png" }); //should use an enum for category
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Greed Reigns", Subhead = "Bankers are Greedy", DateLine = "4/5/17", Image = "Assets/Financial2.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Invest In The War Machine", Subhead = "The Industrial Military Complex Positioned Well", DateLine = "4/5/17", Image = "Assets/Financial3.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "EPA Abolished", Subhead = "Oil Companies Now Have Free Pass To Pollute", DateLine = "4/5/17", Image = "Assets/Financial4.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Financial", Headline = "Trump Tweets Matter On Public Stock", Subhead = "give A Greedy 3 Year Old A Gun", DateLine = "4/5/17", Image = "Assets/Financial5.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Food", Headline = "Organic Cooking", Subhead = "Using the right ingredients", DateLine = "4/5/17", Image = "Assets/Food1.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Food", Headline = "How To Keep The Real Cost of Food Down", Subhead = "Shopping smart for real food", DateLine = "4/5/17", Image = "Assets/Food2.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Food", Headline = "The Dangers of Processed Food", Subhead = "Without the FDA, it will be impossible to tell what is in your food", DateLine = "4/5/17", Image = "Assets/Food3.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Food", Headline = "Cooking For One", Subhead = "The challenge of cooking for just one person", DateLine = "4/5/17", Image = "Assets/Food4.png" });
            items.Add(new NewsItem() { Id = 1, Category = "Food", Headline = "The Sweet Things In Life", Subhead = "Awesome deserts for all occasions", DateLine = "4/5/17", Image = "Assets/Food5.png" });


            return items;
        }
    }
}
