using System;

namespace CompositePattern.Component
{
    public abstract class MenuComponent
    {
        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }

        public virtual MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }

        public virtual string GetName()
        {
            throw new NotSupportedException();
        }

        public virtual string GetDescription()
        {
            throw new NotSupportedException();
        }

        public virtual double GetPrice()
        {
            throw new NotSupportedException();
        }

        public virtual bool GetIsVegetarian()
        {
            throw new NotSupportedException();
        }

        public virtual void Print()
        {
            throw new NotSupportedException();
        }
    }
}
