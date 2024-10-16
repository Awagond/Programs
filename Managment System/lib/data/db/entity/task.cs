using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Task{
    private string v1;
    private string v2;
    private string v3;
    private int v4;

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id {get;set;}
    public int IdProject {get;set;}
    public string name {get;set;}
    public string description {get;set;}
    public int Status {get;set;}

    

    public Task(string name, string description, int idProject, int Status)
    {
        this.name = name;
        this.description = description;
        this.IdProject = idProject;
        this.Status = Status;
    }
}

enum Status : int {
    todo = 0,
    inProgress = 1,
    done = 2
}