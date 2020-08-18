using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BluedIT.Models
{
  public class User
  {
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string DateOfBirth { get; set; }
    public string JoinedOn { get; set; }
    public string UserClass { get; set; }
    public ICollection<Post> Posts { get; set; }
  }
}
