using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace GroupDocsViewerJava {
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table GroupDocsViewerJavaRecord
			SchemaBuilder.CreateTable("GroupDocsViewerJavaRecord", table => table
				.ContentPartRecord()
				.Column("Url", DbType.String)
				.Column("Width", DbType.String)
				.Column("Height", DbType.String)
				.Column("DefaultFileName", DbType.String)
				.Column("UseHttpHandlers", DbType.Boolean)
			);



            return 1;
        }
    }
}