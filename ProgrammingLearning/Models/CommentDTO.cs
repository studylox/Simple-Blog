namespace ProgrammingLearning.Models
{
    public class CommentDTO
    {

        //用户的评论内容
        public string? userDialog { get; set; }

        //发布日期
        public DateTime? publishTime { get; set; }

        //点赞数
        public int? Likes { get; set; }

        //外键，与User表中的userID关联

        public int userID { get; set; }

      public int commentlistid { get; set; }
    }
}
