using PawHubAPI.Models.Dto;

namespace PawHubAPI.Data;

public class UserContext
{
    public static List<UserDTO> userList = new List<UserDTO>
    {
        new UserDTO { Id = 1, Name = "Pool View" },
        new UserDTO { Id = 2, Name = "Beach View" },
    };
}