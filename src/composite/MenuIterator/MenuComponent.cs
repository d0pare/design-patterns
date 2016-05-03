using System;
using System.Collections.Generic;

namespace MenuIterator
{
    public abstract class MenuComponent
    {
        public virtual string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual string Description
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual decimal Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual bool IsVegetarian
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
        public virtual MenuComponent GetChild(int i)
        {
            throw new NotImplementedException();
        }

        public abstract IEnumerator<MenuComponent> CreateIterator();

        public virtual void Print()
        {
            throw new NotImplementedException();
        }
    }
}