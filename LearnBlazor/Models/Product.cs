﻿
namespace LearnBlazor.Models
{
    public class Product
    {
       
        public int  Id { get; set; }
        public  string Name { get; set; }
        public bool IsActive { get; set; }
        public double Price { get; set; }
        public List<string> ProductPropertiesList_Direct { get ; set; }
        public IEnumerable<Product_Prop> ProductPropertiesList_InDirect { get; set; }
       
    }
}

