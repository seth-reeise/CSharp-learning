/*
 * A model is a set of classes that represent the data that the app manages.
 * Model classes can go anywhere in the project, but the Models folder is used by convention.
 */

namespace TodoApi.Models
{
    public class TodoItem
    { 
    /*
    * { get; set; } is an auto property in C#
    * Code generated by compiler looks like:
    * get {return this.name}
    * set {this.name = name}
    */
    
        // Unique key for database
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        
    }
}