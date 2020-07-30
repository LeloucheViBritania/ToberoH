using System.ComponentModel.DataAnnotations;

namespace Roberto.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [DataType(DataType.Text)]
        public string CMessage { get; set; }


        public string NameUserComment { get; set; }


    }
}