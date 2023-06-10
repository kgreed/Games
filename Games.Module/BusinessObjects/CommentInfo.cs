using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using System;
using System.Linq;

namespace Games.Module.BusinessObjects
{
   // [DomainComponent]
    public class CommentInfo //:NonPersistentBaseObject
    {

        public virtual string InfoComment { get; set; }
    }
}