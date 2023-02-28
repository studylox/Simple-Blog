using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using ProgrammingLearning.Models;
using System.Linq;

namespace ProgrammingLearning.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly VideoContext _context;

        public UserController(VideoContext context)
        {
            _context = context;
        }

        //用户注册
        [HttpPost]
        public bool Register(User user)
        {
           
            _context.Users.Add(user);
            if (_context.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }


        //根据姓名查找用户


        [HttpGet]
        public User GetUser(string name)
        {
            return _context.Users.FirstOrDefault(x => x.userName==name);
        }


        //根据ID查找用户信息
        [HttpGet("GetUserById")]
        public User GetUser(int id)
        {
            return _context.Users.FirstOrDefault(x => x.userID == id);
        }


        [HttpGet("GetisCorrect")]

        public bool isCorrect(string name,string password)
        {
            User user=GetUser(name);
            if(user==null)
            {
                return false;
            }
            else
            {
                return user.userPassword == password;
            }
        }

        [HttpGet("IsUserExist")]
        public bool isExist(string name)
        {
            if(_context.Users.FirstOrDefault(x=>x.userName==name)!=null)
            {
                return true;
            }
            return false;
        }

        [HttpGet("GetAllUsers")]
        public List<User> Get()
        {
            return _context.Users.ToList();
        }

    }

    
}
