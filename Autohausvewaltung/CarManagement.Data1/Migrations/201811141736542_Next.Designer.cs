using System;
using System.Collections.Generic;


namespace CarManagement.Data1.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;

    [GeneratedCode("EntityFramework.Migrations", "6.2.0-61023")]
    public sealed partial class Next : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(CarManagement.Data1.Migrations.Next));

        string IMigrationMetadata.Id
        {
            get { return "201811141736542_Next"; }
        }

        string IMigrationMetadata.Source
        {
            get { return null; }
        }

        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
