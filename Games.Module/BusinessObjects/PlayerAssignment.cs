using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;

namespace Games.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Participant : BaseObject
    {

        public virtual Person Player { get; set; }

        public virtual Game Game { get; set; }

        public virtual AssignmentEnum Assignment { get; set; }

    }
}