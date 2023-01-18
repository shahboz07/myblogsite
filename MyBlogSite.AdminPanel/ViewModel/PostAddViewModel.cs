namespace MyBlogSite.AdminPanel.ViewModel
{
    public class PostAddViewModel
    {
        public string? Title { get; set; }
        public DateTime Time { get; set; }
        public string? Comment { get; set; }
        public IFormFile? Image { get; set; }
    }
}