namespace StoreAssignment.Models
{
    using System;
    public abstract class BaseModel
    {

        public string Id { get; set; } = Guid.NewGuid().ToString();


    }
}
