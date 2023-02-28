using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgrammingLearning.Models;

namespace ProgrammingLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly VideoContext _context;
        private readonly UserController _userController;
       // private readonly User user;
        public CommentController(VideoContext context)
        {
            _context = context;
            //this.user = user;
            _userController= new UserController(context);
        }

      


        // GET: api/Comment
        [HttpGet]
       public List<Comment>GetAllComment()
        {
            return _context.Comments.ToList();
        }
     
       
        // POST: api/Comment
        [HttpPost]
     
        public bool AddComment(CommentDTO comment)
        {
            var user = _context.Users.FirstOrDefault(x => x.userID == comment.userID);
            if (user == null)
            {
                // 如果未找到相应用户，则可以选择添加一些错误处理
                return false;
            }

            //var user = _context.Users.FirstOrDefault(x=> x.userID== comment.userID);
            var newComment = new Comment
            {
                userDialog = comment.userDialog,
                publishTime = DateTime.Now,
                Likes = 0,
                userID = comment.userID,
                commentlistid = comment.commentlistid,
                userName = _userController.GetUser(comment.userID).userName,


        };
           
            _context.Comments.Add(newComment);
            if (_context.SaveChanges() != 0) return true;
            return false;
        }

        [HttpGet("GetCommentById")]
        public Comment Get(int id)
        {
            if(CommentExists(id))
            { return _context.Comments.FirstOrDefault(x => x.ID == id);

            }
            return null;
        }

        [HttpGet("GetCommentsByUserId")]
        public List<Comment>GetCommentsByUserId(int id)
        {
            return _context.Comments.Where(x => x.userID == id).ToList();
        }
        private bool CommentExists(int id)
        {
            return _context.Comments.Any(e => e.ID == id);
        }

        [HttpDelete]
        public bool DeleteComment(int id)
        {

            Comment comment = _context.Comments.FirstOrDefault(x => x.ID == id);
            if (comment != null)
            {
                _context.Comments.Remove(comment);
                if (_context.SaveChanges() != 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
