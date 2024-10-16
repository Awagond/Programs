class Navigator
{
    private Tree rootTree;
    private string currentNode = "1";

    public void buildRoot()
    {
        rootTree.AddRoot(new Node("Start", new Start()));
        rootTree.SearchByLevel("1").Children.Add(new Node("Login", new Login()));
        rootTree.SearchByLevel("1").Children.Add(new Node("Password", new Password()));

        rootTree.AddRoot(new Node("Admin", new AdminMenu()));
        rootTree.SearchByLevel("2").Children.Add(new Node("Create task",new AdminCreateTask()));
        rootTree.SearchByLevel("2").Children.Add(new Node("Create user",new AdminCreateUser()));

        // rootTree.AddRoot(new Node("User", new UserMenu()));

        // rootTree.SearchByLevel("3").Children.Add(new Node("Check list task's"));
        // rootTree.SearchByLevel("3.1").Children.Add(new Node("Filter"));

        // rootTree.SearchByLevel("3").Children.Add(new Node("Select task"));
        // rootTree.SearchByLevel("3.2").Children.Add(new Node("Enter id"));
        // rootTree.SearchByLevel("3.2.2").Children.Add(new Node("Change status"));

        Console.WriteLine("СТРОИМ");

        rootTree.runRoot(currentNode);
    }

    public string CurrentNode(){
        return currentNode;
    }

    public void UpdateCurrentNode(string newNode){
        currentNode = newNode;
        rootTree.runRoot(currentNode);
    }

    public void printTree(){
        Console.WriteLine(rootTree);
    }
 
    private Navigator()
    {
        this.rootTree = new Tree();
    }

    private static Navigator? instance;
 
    public static Navigator getInstance()
    {
        if (instance == null){
        instance = new Navigator();
        }
        return instance;
    }
}