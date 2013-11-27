using GroupDocsViewerJava.Models;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupDocsViewerJava.Drivers
{
    public class GroupDocsViewerJavaDriver : ContentPartDriver<GroupDocsViewerJavaPart>
    {
        protected override DriverResult Display(
            GroupDocsViewerJavaPart part, string displayType, dynamic shapeHelper)
        {
            return ContentShape("Parts_GroupDocsViewerJava",
                () => shapeHelper.Parts_GroupDocsViewerJava(
                    Url: part.Url,
                    Width: part.Width == null || part.Width.Length == 0 ? "100%" : part.Width,
                    Height: part.Height == null || part.Height.Length == 0 ? "600px" : part.Height,
                    DefaultFileName: part.DefaultFileName,
                    UseHttpHandlers: part.UseHttpHandlers == null ? true : part.UseHttpHandlers
                    ));
        }

        //GET
        protected override DriverResult Editor(GroupDocsViewerJavaPart part, dynamic shapeHelper)
        {
            return ContentShape("Parts_GroupDocsViewerJava_Edit",
                () => shapeHelper.EditorTemplate(
                    TemplateName: "Parts/GroupDocsViewerJava",
                    Model: part,
                    Prefix: Prefix));
        }

        //POST
        protected override DriverResult Editor(
            GroupDocsViewerJavaPart part, IUpdateModel updater, dynamic shapeHelper)
        {
            updater.TryUpdateModel(part, Prefix, null, null);
            return Editor(part, shapeHelper);
        }
    }
}