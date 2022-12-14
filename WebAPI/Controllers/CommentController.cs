using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        ICommentService _commentService;
        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _commentService.GetById(id);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult GetById(Comment comment)
        {
            var result = _commentService.Add(comment);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
