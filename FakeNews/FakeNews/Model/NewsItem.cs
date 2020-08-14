
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Store.Preview.InstallControl;

namespace FakeNews.Model
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string HeadLine { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }
    public class NewsManager
    {
        private static List<NewsItem> GetNewsItems()
        {
            var items = new List<NewsItem>();
            items.Add(new NewsItem()
            {
                Id = 1,
                Category = "Financial",
                HeadLine = "Lorem Ipsum",
                Subhead = "doro sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Image/Financial.png"
            });
            items.Add(new NewsItem()
            {
                Id = 2,
                Category = "Financial",
                HeadLine = "Etiam ac felis viverra",
                Subhead = "vulputate nisl ac, aliquet nisi",
                DateLine = "tortor porttitor, eu fermentum ante congue",
                Image = "Assets/Image/Financial2.png"
            });
            items.Add(new NewsItem()
            {
                Id = 3,
                Category = "Financial",
                HeadLine = "Integer sed turpit erat",
                Subhead = "Sed quis hendrerit lorem, quis interdum dolor",
                DateLine = "in viverra metus facilisis sed",
                Image = "Assets/Image/Financial3.png"
            });
            items.Add(new NewsItem()
            {
                Id = 4,
                Category = "Financial",
                HeadLine = "Proin sem neque",
                Subhead = "aliquet quis ipsum tincidunt",
                DateLine = "Integer eleifend",
                Image = "Assets/Image/Financial4.png"
            });
            items.Add(new NewsItem()
            {
                Id = 5,
                Category = "Financial",
                HeadLine = "Mauris bindendum non leo vitae tempor",
                Subhead = "In nisl tortor, eleifend sed ipsum eget",
                DateLine = "Currabitur dictum augue vitae elementum ultrices",
                Image = "Assets/Image/Financial5.png"
            });
            items.Add(new NewsItem()
            {
                Id = 6,
                Category = "Food",
                HeadLine = "Lorem Ipsum",
                Subhead = "dolor sit amet",
                DateLine = "Nunc tristique nec",
                Image = "Assets/Image/Food1.png"
            });
            items.Add(new NewsItem()
            {
                Id = 7,
                Category = "Food",
                HeadLine = "Etiam ac felis viverra",
                Subhead = "vulputate nisl ac, aliquet nisi",
                DateLine = "tortor porttitor, eu fermentum ante congue",
                Image = "Assets/Image/Food2.png"
            });
            items.Add(new NewsItem()
            {
                Id = 8,
                Category = "Food",
                HeadLine = "Integer sed turpis erat",
                Subhead = "Sed quis hendrerit lorem, quis interdum dolor",
                DateLine = "in viverra metus facilisis sed",
                Image = "Assets/Image/Food3.png"
            });
            items.Add(new NewsItem()
            {
                Id = 9,
                Category = "Food",
                HeadLine = "Proin sem neque",
                Subhead = "aliquet quis ipsum tincidunt",
                DateLine = "Integer eleifend",
                Image = "Assets/Image/Food4.png"
            });
            items.Add(new NewsItem()
            {
                Id = 10,
                Category = "Food",
                HeadLine = "Mauris bindendum non leo vitae tempor",
                Subhead = "In nisl tortor, eleifend sed ipsum eget",
                DateLine = "Currabitur dictum augue vitae elementum ultrices",
                Image = "Assets/Image/Food5.png"
            });
            return items;

        }
        public static void GetNews(string category, ObservableCollection<NewsItem> NewsItems)
        {
            var allItems = GetNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();
            NewsItems.Clear();
            filteredNewsItems.ForEach(p => NewsItems.Add(p));
        }

    }

}