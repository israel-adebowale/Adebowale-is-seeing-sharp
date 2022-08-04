using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acm.BLNew
{   //an enumeration is created for the state of entities to show whether the customers, products or orders are active or deleted
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    // this class is abstract which means it can contain a non abstract and abstract method but in this class, a single abstract method is defined which is the validate method
    
    public abstract class EntityBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }
        public bool IsValid => Validate();

        public abstract bool Validate();

    }
}
