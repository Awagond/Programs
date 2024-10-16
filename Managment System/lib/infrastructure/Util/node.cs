using System;
using System.Collections.Generic;
using System.Linq;

class Node
{
    public string Name;
    public ViewModel screenView;
    public List<Node> Children = new List<Node>();
 
    public Node(string name, ViewModel view)
    {
        Name = name;
        screenView = view;
    }
 
    public override string ToString()
    {
        return Name;
    }
}