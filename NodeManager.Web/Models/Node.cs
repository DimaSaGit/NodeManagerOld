namespace NodeManager.Web.Models
{
    using System;
    public class Node
    {
        public Node()
        { }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public Nullable<System.DateTime> LastChange { get; set; }
        public string Author { get; set; }
        
    }
}