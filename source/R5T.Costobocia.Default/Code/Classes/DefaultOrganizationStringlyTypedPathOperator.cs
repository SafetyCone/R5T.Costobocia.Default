using System;

using R5T.Lombardy;
using R5T.Ostrogothia;


namespace R5T.Costobocia.Default
{
    public class DefaultOrganizationStringlyTypedPathOperator : IOrganizationStringlyTypedPathOperator
    {
        public IOrganizationDirectoryNameProvider OrganizationDirectoryNameProvider { get; }
        public IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public DefaultOrganizationStringlyTypedPathOperator(IOrganizationDirectoryNameProvider organizationDirectoryNameProvider, IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.OrganizationDirectoryNameProvider = organizationDirectoryNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetOrganizationDirectoryPath(string organizationsDirectoryPath, IOrganization organization)
        {
            var organizationDirectoryName = this.OrganizationDirectoryNameProvider.GetOrganizationDirectoryName(organization);

            var organizationDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPath(organizationsDirectoryPath, organizationDirectoryName);
            return organizationDirectoryName;
        }
    }
}
