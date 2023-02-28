using System.Collections;

namespace ProgrammingLearning.Models
{
    public class User
    {
        //用户ID
        public int userID { get; set; }

        //用户名
        public string? userName { get; set; }

        //用户密码

        public string? userPassword { get; set; }

        //用户头像

        public string ?userAvatar { get; set; }

       


        // 关联属性，用于访问与该用户相关的评论
       // public List<Comment>? comments { get; set; }

    }
}
