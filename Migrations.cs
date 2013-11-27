using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;
using GroupDocsViewerJava.Models;

namespace GroupDocsViewerJava {
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table GroupDocsViewerJavaRecord
			SchemaBuilder.CreateTable(typeof(GroupDocsViewerJavaRecord).Name, table => table
				.ContentPartRecord()
                .Column<string>("Url", column => column.WithLength(256))
                .Column<string>("Width", column => column.WithLength(10))
                .Column<string>("Height", column => column.WithLength(10))
                .Column<string>("DefaultFileName", column => column.WithLength(256))
                .Column<bool>("UseHttpHandlers", column => column.WithDefault(true))
			);

            ContentDefinitionManager.AlterPartDefinition(
                typeof(GroupDocsViewerJavaPart).Name, cfg => cfg.Attachable());

            return 1;
        }
    }
}