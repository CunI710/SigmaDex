using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models.Query.Requests.User {
    public class UserCreateRequest {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string[]? Roles { get; set; }
    }
}
