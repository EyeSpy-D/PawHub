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
    [HttpGet]
    public ActionResult<IEnumerable<UserDTO>> GetUsers()
    {
        return Ok(UserContext.userList);
    }

    [HttpGet("{id:int}")]
    public ActionResult GetUser(int id)
    {
        var user = UserContext.userList.FirstOrDefault(u => u.Id == id);
        if (user == null)
            return NotFound();
        return Ok(user);
    }

    [HttpPost]
    public ActionResult AddUser([FromBody] UserDTO userDto)
    {
        if (userDto == null)
            return BadRequest();

        if (UserContext.userList.FirstOrDefault(u => u.Id == userDto.Id) != null || userDto.Id == 0)
            return BadRequest();

        UserContext.userList.Add(userDto);

        return Ok();
    }

    [HttpDelete("{id:int}")]
    public ActionResult DeletedUser(int id)
    {
        var result = UserContext.userList.FirstOrDefault(u => u.Id == id);
        if (result == null)
            return NotFound();

        UserContext.userList.Remove(result);
        return Ok();
    }

    [HttpPut("{id:int}")]
    public ActionResult UpdateUser(int id, [FromBody] UserDTO userDto)
    {
        var result = UserContext.userList.FirstOrDefault(u => u.Id == id);
        if (result == null)
            return NotFound();

        result.Id = userDto.Id;
        result.Name = userDto.Name;

        return NoContent();
    }
}