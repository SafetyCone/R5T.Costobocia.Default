using System;

using R5T.Lombardy;

using R5T.T0064;


namespace R5T.Costobocia.Default
{
    [ServiceImplementationMarker]
    public class OrganizationsStringlyTypedPathOperator : IOrganizationsStringlyTypedPathOperator, IServiceImplementation
    {
        public IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public OrganizationsStringlyTypedPathOperator(IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetOrganizationsDirectoryPath(string baseDirectoryPath)
        {
            var organizationsDirectoryPath = this.StringlyTypedPathOperator.GetDirectoryPath(baseDirectoryPath, OrganizationsDirectory.DirectoryName);
            return organizationsDirectoryPath;
        }
    }
}
