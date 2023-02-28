using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace ProgrammingLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {

        private readonly VideoContext _context;

        public VideoController(VideoContext context)
        {
            _context = context;
        }


        //获得所有视频信息
         [HttpGet]
        public List<Video>Get()
        {
            return _context.Videos.ToList();
        }

        //[HttpGet("GetVideoByName")]
        [HttpGet("GetVideoByKeyword")]
        public List<Video> Get(string keyword)
        {


            // return _context.Videos.FirstOrDefault(x => x.Name == name);
            return _context.Videos.Where(v => v.Name.Contains(keyword) || v.Description.Contains(keyword)).ToList();

        }

        [HttpGet("GetVideoById")]
        public Video Get(int id)
        {
            return _context.Videos.FirstOrDefault(x => x.ID == id);
        }

        //上传视频
        [HttpPost]
        public bool Add(Video video)
        {
           
            if(video!=null)
            {  video.PublishTime=DateTime.Now;
                video.Likes = 0;
                video.Views = 0;
               // video.Description = " ";
               _context.Videos.Add(video);
            if (_context.SaveChanges() != 0)
            {
                return true;
            }

            return false;

            }
            return false;

        }

        //删除视频
        [HttpDelete]
        public bool Delete(int Id)
        {

            Video? video = _context.Videos.FirstOrDefault(x => x.ID == Id);
            if (video != null)
            {
                _context.Videos.Remove(video);
                if (_context.SaveChanges() != 0)
                {
                    return true;
                }
            }
            return false;

        }
    }
}
