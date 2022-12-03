using System;
using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category
    {

        public int Id { get; private set; }
        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateDomain(name);
        }
    
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public ICollection<Product> products { get; private set; }

        private void ValidateDomain(string name) {

            DomainExceptionValidation
        }

    }
}

