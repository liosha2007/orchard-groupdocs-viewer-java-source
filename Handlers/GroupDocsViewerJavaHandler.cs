using GroupDocsViewerJava.Models;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupDocsViewerJava.Handlers
{
    public class GroupDocsViewerJavaHandler : ContentHandler {
        public GroupDocsViewerJavaHandler(IRepository<GroupDocsViewerJavaRecord> repository)
        {
      Filters.Add(StorageFilter.For(repository));
    }
  }
}