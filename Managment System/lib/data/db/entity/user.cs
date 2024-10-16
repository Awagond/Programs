using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class User{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}
    public string login {get;set;}
    public string password {get;set;}
    public bool isPriveleged{get;set;}
    public List<Task>? tasks {get; set;}

    public User(string login, string password, bool isPriveleged)
    {
        this.login = login;
        this.password = password;
        this.isPriveleged = isPriveleged;
    }
    public User(string login, string password, bool isPriveleged, List<Task> tasks)
    {
        this.login = login;
        this.password = password;
        this.isPriveleged = isPriveleged;
        this.tasks = tasks;
    }
    public User(){}
}