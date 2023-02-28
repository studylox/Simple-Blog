using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgrammingLearning.Models
{
    public class Comment
    {
        //用户ID
        public int ID { get; set; }

        //评论区id

        public int commentlistid { get; set; }

        //用户名
        //public string userName { get; set; }

        //用户头像
       // public string userAvatar  { get; set; }

        //用户的评论内容
        public string? userDialog { get; set; }
        
        //发布日期
        public DateTime? publishTime { get; set; }

        //点赞数
        public int? Likes { get; set; }

        //外键，与User表中的userID关联

        public int userID { get; set; }

        // 关联属性，用于访问与该评论相关的用户
        public User user { get; set; }

        public string userName  { get; set; }
    }
}
