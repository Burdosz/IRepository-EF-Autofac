using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDB;
using WebAppRepository.Interfaces;
using WebAppRepository.Repositories;

namespace WebAppRepository
{
    public class RepositoryModule : Module
    {
        public RepositoryModule()
        {

        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>().As<IStudentRepository>().InstancePerRequest();

            base.Load(builder);
        }
    }
}
