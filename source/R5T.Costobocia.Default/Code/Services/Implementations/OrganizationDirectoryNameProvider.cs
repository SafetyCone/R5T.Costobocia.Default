using System;

using R5T.Ostrogothia;

using R5T.T0064;


namespace R5T.Costobocia.Default
{
    /// <summary>
    /// Provides the name of the organization as the organzation's directory name.
    /// </summary>
    [ServiceImplementationMarker]
    public class OrganizationDirectoryNameProvider : IOrganizationDirectoryNameProvider, IServiceImplementation
    {
        public string GetOrganizationDirectoryName(IOrganization organization)
        {
            var organizationDirectoryName = organization.Name;
            return organizationDirectoryName;
        }
    }
}
