using Autofac;

namespace Calc
{
    public class Program
    {
        private static readonly IContainer Container;

        static Program()
        {
            var builder = new ContainerBuilder();

            builder
                .RegisterAssemblyTypes(typeof(Program).Assembly)
                .AsImplementedInterfaces();

            builder
                .RegisterType<Application>();

            Container = builder.Build();
        }

        public static int Main(string[] args)
        {
            return Container
                .Resolve<Application>()
                .Run(args);
        }
    }
}