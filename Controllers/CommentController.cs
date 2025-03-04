using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using dotnet_api_test;
using dotnet_api_test.Dtos.Stock;
using dotnet_api_test.Mappers;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using dotnet_api_test.interfaces;
namespace dotnet_api_test;

[Route("api/[controller]")]
[ApiController]
public class CommentController : ControllerBase
{
    private readonly ICommentRepository _commentRepo;
    public CommentController(ICommentRepository commentRepo)
    {
        _commentRepo = commentRepo;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var comments = await _commentRepo.GetAllAsync();
        var commentDto = comments.Select(s => s.ToCommentDto());
        return Ok(commentDto);
    }
}
