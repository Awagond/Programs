class Tree {
    List<Node> Roots = new List<Node>();

    public void AddRoot(Node node)
    {
        Roots.Add(node);
    }
    
    public Node SearchByLevel(string level)
    {
        int[] arr = level.Split('.').Select(x => int.Parse(x)).ToArray();
        return Search(Roots, 1);
 
        Node Search(List<Node> nodes, int lvl)
        {
            if (lvl == arr.Length)
                return nodes[arr[lvl - 1] - 1];
            return Search(nodes[arr[lvl - 1] - 1].Children, lvl + 1);
        }
    }

    public void runRoot(string level){
        SearchByLevel(level).screenView.printView();
    }
 
    public override string ToString()
    {
        string result = "";
 
        for (int i = 0; i < Roots.Count; i++)
            result += (i + 1).ToString() + ")" + Roots[i] + "\n" + Foo(Roots[i], i + 1);
 
        string Foo(Node node, params int[] arr)
        {
            string str = "";
            int level = 1;
            foreach (var currentNode in node.Children)
            {
                str += string.Join(".", arr) + "." + level + ")" + currentNode + "\n";
                if (currentNode.Children.Count > 0)
                {
                    int[] newArr = new int[arr.Length + 1];
                    arr.CopyTo(newArr, 0);
                    newArr[newArr.Length - 1] = level;
                    str += Foo(currentNode, newArr);
                }
                level++;
            }
            return str;
        }
        return result;
    }
}