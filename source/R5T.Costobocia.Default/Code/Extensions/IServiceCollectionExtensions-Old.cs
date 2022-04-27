using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Lombardy;


namespace R5T.Costobocia.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationDirectoryNameProvider"/> implementation of <see cref="IOrganizationDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationDirectoryNameProvider_Old(this IServiceCollection services)
        {
            services.AddSingleton<IOrganizationDirectoryNameProvider, OrganizationDirectoryNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationDirectoryNameProvider"/> implementation of <see cref="IOrganizationDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationDirectoryNameProvider> AddOrganizationDirectoryNameProviderAction_Old(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IOrganizationDirectoryNameProvider>.New(() => services.AddOrganizationDirectoryNameProvider_Old());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationsStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationsStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationsStringlyTypedPathOperator_Old(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<IOrganizationsStringlyTypedPathOperator, OrganizationsStringlyTypedPathOperator>()
                .RunServiceAction(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationsStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationsStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationsStringlyTypedPathOperator> AddOrganizationsStringlyTypedPathOperatorAction_Old(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction<IOrganizationsStringlyTypedPathOperator>.New(() => services.AddOrganizationsStringlyTypedPathOperator_Old(
                stringlyTypedPathOperatorAction));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationStringlyTypedPathOperator_Old(this IServiceCollection services,
            IServiceAction<IOrganizationDirectoryNameProvider> organizationDirectoryNameProviderAction,
            IServiceAction<IOrganizationsStringlyTypedPathOperator> organizationsStringlyTypedPathOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<IOrganizationStringlyTypedPathOperator, OrganizationStringlyTypedPathOperator>()
                .RunServiceAction(organizationDirectoryNameProviderAction)
                .RunServiceAction(organizationsStringlyTypedPathOperatorAction)
                .RunServiceAction(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationStringlyTypedPathOperator> AddOrganizationStringlyTypedPathOperatorAction_Old(this IServiceCollection services,
            IServiceAction<IOrganizationDirectoryNameProvider> organizationDirectoryNameProviderAction,
            IServiceAction<IOrganizationsStringlyTypedPathOperator> organizationsStringlyTypedPathOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction<IOrganizationStringlyTypedPathOperator>.New(() => services.AddOrganizationStringlyTypedPathOperator_Old(
                organizationDirectoryNameProviderAction,
                organizationsStringlyTypedPathOperatorAction,
                stringlyTypedPathOperatorAction));
            return serviceAction;
        }
    }
}
