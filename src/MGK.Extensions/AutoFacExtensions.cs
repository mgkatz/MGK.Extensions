using Autofac;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MGK.Extensions
{
	public static class AutoFacExtensions
	{
		public static void RegisterImplementedInterfaces(this ContainerBuilder builder)
		{
			var assembly = Assembly.GetCallingAssembly();

			builder.RegisterAssemblyTypes(assembly)
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();
		}

		public static void RegisterImplementedInterfaces(this ContainerBuilder builder, Func<Type, bool> filter)
		{
			var assembly = Assembly.GetCallingAssembly();

			builder.RegisterAssemblyTypes(assembly)
				.Where(filter)
				.AsImplementedInterfaces()
				.InstancePerLifetimeScope();
		}

		public static void RegisterAutoMapper(this ContainerBuilder builder)
		{
			var assembly = Assembly.GetCallingAssembly();

			// Register profiles
			builder.RegisterAssemblyTypes(assembly)
				.AssignableTo(typeof(Profile))
				.As<Profile>();

			// Add profiles
			builder.Register(c =>
				new MapperConfiguration(cfg =>
				{
					foreach (Profile profile in c.Resolve<IEnumerable<Profile>>())
						cfg.AddProfile(profile);

					cfg.AllowNullCollections = true;
					cfg.AllowNullDestinationValues = true;
				}))
				.AsSelf()
				.SingleInstance();

			// Register AutoMapper
			builder.Register(c =>
				c.Resolve<MapperConfiguration>()
					.CreateMapper(c.Resolve))
					.As<IMapper>()
					.InstancePerLifetimeScope();
		}
	}
}
