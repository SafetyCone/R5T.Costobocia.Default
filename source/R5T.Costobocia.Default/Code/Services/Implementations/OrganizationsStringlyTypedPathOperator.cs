using System;

using R5T.Lombardy;


namespace R5T.Costobocia.Default
{
    public class OrganizationsStringlyTypedPathOperator : IOrganizationsStringlyTypedPathOperator
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
