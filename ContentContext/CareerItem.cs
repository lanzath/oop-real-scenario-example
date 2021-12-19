using Lanza.SharedContext;
using Lanza.NotificationContext;

namespace Lanza.ContentContext
{
    public class CareerItem : Base
    {
        public CareerItem(
            int order,
            string title,
            string description,
            Course course)
        {
            if (course == null)
                AddNotification(new Notification("Course", "Curso inválido"));

            this.Order = order;
            this.Title = title;
            this.Description = description;
            this.Course = course;

        }
        public int Order { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }

    }
}
