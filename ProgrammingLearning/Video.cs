using System.Data;

namespace ProgrammingLearning
{
    public class Video
    {
        //视频ID
        public int ID { get; set; }

        //视频名称
        public string? Name { get; set; }

        //视频地址
        public string ?Url { get; set; }

        //public int ?price   { get; set; }

        //视频发布日期
        public DateTime PublishTime { get; set; } 
        

        //视频封面
        public string? PictureUrl { get; set; }

        //视频简介
        public string?Description { get; set; }

        //视频点赞数
        public int Likes { get; set; }

        //视频播放量
        public int Views { get; set; }

        //发布者
        public string ? Submitter { get; set; }

    }
}
