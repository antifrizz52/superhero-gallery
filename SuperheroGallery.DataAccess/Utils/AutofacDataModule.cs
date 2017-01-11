using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SuperheroGallery.DataAccess.Contracts;
using SuperheroGallery.DataAccess.Infrastructure;

namespace SuperheroGallery.DataAccess.Utils
{
    public class AutofacDataModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HeroStorage>().As<IHeroStorage>().SingleInstance();

            base.Load(builder);
        }
    }
}
