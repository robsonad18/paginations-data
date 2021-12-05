using System;
namespace paginations_data.Models
{
    public class Todo
    {
        public int Id {get;set;}
        public string Title {get;set;}
        public bool Done {get;set;}
        public DateTime CreateAt {get;set;}
    }
}