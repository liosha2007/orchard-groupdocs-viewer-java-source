using Orchard.ContentManagement;
using Orchard.ContentManagement.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GroupDocsViewerJava.Models
{
    public class GroupDocsViewerJavaRecord : ContentPartRecord
    {
        public virtual string Url { get; set; }
        public virtual string Width { get; set; }
        public virtual string Height { get; set; }
        public virtual string DefaultFileName { get; set; }
        public virtual bool UseHttpHandlers { get; set; }
    }

    public class GroupDocsViewerJavaPart : ContentPart<GroupDocsViewerJavaRecord>
    {

        [Required]
        [DisplayName("Viewer Url")]
        public string Url
        {
            get { return Record.Url; }
            set { Record.Url = value; }
        }

        [Required]
        [DisplayName("Viewer Width")]
        public string Width
        {
            get { return Record.Width; }
            set { Record.Width = value; }
        }

        [Required]
        [DisplayName("Viewer Height")]
        public string Height
        {
            get { return Record.Height; }
            set { Record.Height = value; }
        }

        [DisplayName("Default file name")]
        public string DefaultFileName
        {
            get { return Record.DefaultFileName; }
            set { Record.DefaultFileName = value; }
        }

        [Required]
        [DisplayName("Use Http Handlers")]
        public bool UseHttpHandlers
        {
            get { return Record.UseHttpHandlers; }
            set { Record.UseHttpHandlers = value; }
        }
    }
}