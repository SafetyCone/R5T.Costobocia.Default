using System;

using R5T.Lombardy;
using R5T.Ostrogothia;


namespace R5T.Costobocia.Default
{
    public class OrganizationStringlyTypedPathOperator : IOrganizationStringlyTypedPathOperator
    {
        public IOrganizationsStringlyTypedPathOperator OrganizationsStringlyTypedPathOperator { get; }
        public IOrganizationDirectoryNameProvider OrganizationDirectoryNameProvider { get; }
        public IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public OrganizationStringlyTypedPathOperator(
            IOrganizationsStringlyTypedPathOperator organizationsStringlyTypedPathOperator,
            IOrganizationDirectoryNameProvider organizationDirectoryNameProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.OrganizationsStringlyTypedPathOperator = organizationsStringlyTypedPathOperator;
            this.OrganizationDirectoryNameProvider = organizationDirectoryNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetOrganizationDirectoryPathFromBaseDirectoryPath(string baseDirectoryPath, IOrganization organization)
        {
            var organizationsDirectoryPath = this.OrganizationsStringlyTypedPathOperator.GetOrganizationsDirectoryPath(baseDirectoryPath);

            var output = this.GetOrganizationDirectoryPathFromOrganizationsDirectoryPath(organizationsDirectoryPath, organization);
            return output;
        }

        public string GetOrganizationDirectoryPathFromOrganizationsDirectoryPath(string organizationsDirectoryPath, IOrganization organization)
        {
            var organizationDirectoryName = this.OrganizationDirectoryNameProvider.GetOrganizationDirectoryName(organization);

            var organizationDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPath(organizationsDirectoryPath, organizationDirectoryName);
            return organizationDirectoryPath;
        }
    }
}
