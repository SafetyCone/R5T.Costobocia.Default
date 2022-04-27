using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Lombardy;

using R5T.T0062;
using R5T.T0063;


namespace R5T.Costobocia.Default
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="OrganizationDirectoryNameProvider"/> implementation of <see cref="IOrganizationDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationDirectoryNameProvider> AddOrganizationDirectoryNameProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IOrganizationDirectoryNameProvider>(services => services.AddOrganizationDirectoryNameProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationsStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationsStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationsStringlyTypedPathOperator> AddOrganizationsStringlyTypedPathOperatorAction(this IServiceAction _,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IOrganizationsStringlyTypedPathOperator>(services => services.AddOrganizationsStringlyTypedPathOperator(
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="OrganizationStringlyTypedPathOperator"/> implementation of <see cref="IOrganizationStringlyTypedPathOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IOrganizationStringlyTypedPathOperator> AddOrganizationStringlyTypedPathOperatorAction(this IServiceAction _,
            IServiceAction<IOrganizationDirectoryNameProvider> organizationDirectoryNameProviderAction,
            IServiceAction<IOrganizationsStringlyTypedPathOperator> organizationsStringlyTypedPathOperatorAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = _.New<IOrganizationStringlyTypedPathOperator>(services => services.AddOrganizationStringlyTypedPathOperator(
                organizationDirectoryNameProviderAction,
                organizationsStringlyTypedPathOperatorAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }
    }
}
