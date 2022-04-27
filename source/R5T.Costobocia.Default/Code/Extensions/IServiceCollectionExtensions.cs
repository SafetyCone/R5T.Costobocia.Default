using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.T0063;


namespace R5T.Costobocia.Default
{
    public static partial class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationDirectoryNameProvider"/> implementation of <see cref="IOrganizationDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IOrganizationDirectoryNameProvider, OrganizationDirectoryNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationsStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationsStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationsStringlyTypedPathOperator(this IServiceCollection services,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<IOrganizationsStringlyTypedPathOperator, OrganizationsStringlyTypedPathOperator>()
                .RunServiceAction(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddOrganizationStringlyTypedPathOperator(this IServiceCollection services,
            IServiceAction<IOrganizationDirectoryNameProvider> organizationDirectoryNameProviderAction,
            IServiceAction<IOrganizationsStringlyTypedPathOperator> organizationsStringlyTypedPathOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .Run(organizationDirectoryNameProviderAction)
                .Run(organizationsStringlyTypedPathOperatorAction)
                .Run(stringlyTypedPathOperatorAction)
                .AddSingleton<IOrganizationStringlyTypedPathOperator, OrganizationStringlyTypedPathOperator>()
                ;

            return services;
        }
    }
}
