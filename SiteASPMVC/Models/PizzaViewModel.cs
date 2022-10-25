namespace SiteASPMVC.Models
{
    public class PizzaViewModel
    {
        public string ImageTitle { get; set; }
        public string Title { get; set; }
        public float BasePrice { get; set; } = 2f;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Tuna { get; set; }
        public bool Beef { get; set; }
        public bool Ham { get; set; }
        public PizzaViewModel(string image, string title, float price)
        {
            ImageTitle = image;
            Title = title;
            BasePrice = price;
        }
        public PizzaViewModel()
        {

        }
    }
}
