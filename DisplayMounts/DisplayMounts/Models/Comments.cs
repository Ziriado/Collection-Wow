namespace DisplayMounts.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int MountId { get; set; }
        public string Comment { get; set; }
        public DateTime CommentCreated { get; set; }

    }
}
