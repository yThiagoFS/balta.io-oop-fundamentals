using OOPProject.NotificationContext;
using OOPProject.SharedContext;

namespace OOPProject.ContentContext 
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            URL = url;
        }


        public string Title { get; set; }

        public string URL { get; set; }
    }
}