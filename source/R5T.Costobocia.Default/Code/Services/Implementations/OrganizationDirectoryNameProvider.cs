using System;

using R5T.Ostrogothia;


namespace R5T.Costobocia.Default
{
    /// <summary>
    /// Provides the name of the organization as the organzation's directory name.
    /// </summary>
    public class OrganizationDirectoryNameProvider : IOrganizationDirectoryNameProvider
    {
        public string GetOrganizationDirectoryName(IOrganization organization)
        {
            var organizationDirectoryName = organization.Name;
            return organizationDirectoryName;
        }
    }
}
