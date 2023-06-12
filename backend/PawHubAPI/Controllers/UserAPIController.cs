using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PawHubAPI.Data;
using PawHubAPI.Models;
using PawHubAPI.Models.Dto;

namespace PawHubAPI.Controllers;

[Route("api/VillaAPI")]
[ApiController]
public class UserAPIController : ControllerBase
{
    private readonly ApplicationDbContext _db;

    public UserAPIController(ApplicationDbContext db)
    {
        _db = db;
    }
    
    
}