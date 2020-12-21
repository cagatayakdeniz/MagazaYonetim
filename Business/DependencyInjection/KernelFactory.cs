using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyInjection
{
    public class KernelFactory
    {
        public static T GetService<T>()
        {
            var kernel = new StandardKernel(new DependencyInjection());
            return kernel.Get<T>();
        }
    }
}
