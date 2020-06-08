﻿using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.Costobocia.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationDirectoryNameProvider"/> implementation of <see cref="IOrganizationDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultOrganizationDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IOrganizationDirectoryNameProvider, OrganizationDirectoryNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationDirectoryNameProvider"/> implementation of <see cref="IOrganizationDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IOrganizationDirectoryNameProvider> AddDefaultOrganizationDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<IOrganizationDirectoryNameProvider>(() => services.AddDefaultOrganizationDirectoryNameProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationsStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationsStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultOrganizationsStringlyTypedPathOperator(this IServiceCollection services,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<IOrganizationsStringlyTypedPathOperator, OrganizationsStringlyTypedPathOperator>()
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationsStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationsStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IOrganizationsStringlyTypedPathOperator> AddDefaultOrganizationsStringlyTypedPathOperatorAction(this IServiceCollection services,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = new ServiceAction<IOrganizationsStringlyTypedPathOperator>(() => services.AddDefaultOrganizationsStringlyTypedPathOperator(
                addStringlyTypedPathOperator));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultOrganizationStringlyTypedPathOperator(this IServiceCollection services,
            ServiceAction<IOrganizationsStringlyTypedPathOperator> addOrganizationsStringlyTypedPathOperator,
            ServiceAction<IOrganizationDirectoryNameProvider> addOrganizationDirectoryNameProvider,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            services
                .AddSingleton<IOrganizationStringlyTypedPathOperator, OrganizationStringlyTypedPathOperator>()
                .RunServiceAction(addOrganizationsStringlyTypedPathOperator)
                .RunServiceAction(addOrganizationDirectoryNameProvider)
                .RunServiceAction(addStringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IOrganizationStringlyTypedPathOperator> AddDefaultOrganizationStringlyTypedPathOperatorAction(this IServiceCollection services,
            ServiceAction<IOrganizationsStringlyTypedPathOperator> addOrganizationsStringlyTypedPathOperator,
            ServiceAction<IOrganizationDirectoryNameProvider> addOrganizationDirectoryNameProvider,
            ServiceAction<IStringlyTypedPathOperator> addStringlyTypedPathOperator)
        {
            var serviceAction = new ServiceAction<IOrganizationStringlyTypedPathOperator>(() => services.AddDefaultOrganizationStringlyTypedPathOperator(
                addOrganizationsStringlyTypedPathOperator,
                addOrganizationDirectoryNameProvider,
                addStringlyTypedPathOperator));
            return serviceAction;
        }
    }
}