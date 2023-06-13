using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PawHubAPI.Data;
using PawHubAPI.Models;
using PawHubAPI.Models.Dto;
using PawHubAPI.Repository.IRepository;

namespace PawHubAPI.Controllers;

[Route("api/VillaAPI")]
[ApiController]
public class UserAPIController : ControllerBase
{
    protected APIResponse _response;
    private readonly IUserRepository _dbUser;
    private readonly IMapper _mapper;

    public UserAPIController(IUserRepository dbUser, IMapper mapper)
    {
        _dbUser = dbUser;
        _mapper = mapper;
        this._response = new();
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<APIResponse>> GetUsers()
    {
        try
        {
            IEnumerable<User> userList = await _dbUser.GetAllAsync();
            _response.Result = _mapper.Map<List<UserDTO>>(userList);
            _response.StatusCode = HttpStatusCode.OK;
            return Ok(_response);
        }
        catch (Exception ex)
        {
            _response.IsSuccess = false;
            _response.ErrorMessages = new List<string>() { ex.ToString() };
        }

        return _response;
    }
}