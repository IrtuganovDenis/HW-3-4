using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3_4
{
    abstract class BaseClass<T> : IBaseInterface
    {
        protected IProvider<T> provider;
        protected bool B = false;

        protected BaseClass(IProvider<T> p, bool b) 
        {
            this.B = b;
            this.provider = p;
            if (B)
            {
                FillByUser();
            }
            else
            {
                RandFill();
            }
        }
        
        Random rnd = new Random();

        //public abstract void Fill(bool B);
        
        protected abstract void FillByUser();
        protected abstract void RandFill();
        public abstract void Print();
    }
}
