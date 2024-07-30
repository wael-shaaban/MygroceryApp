using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace groceryApp.Models
{
    public class CategoryModel
    {
        public CategoryModel(short id, string name, short parentId,string image ,string Credit)
        {
            Id = id;
            Name = name;
            Image = image;
            ParentId = parentId;
        }
        public CategoryModel()
        {
            
        }
        public string Credit { get; set; }
        public short Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public short ParentId { get; set; }
        public bool IsMainCategory => ParentId == 0;
    }
}