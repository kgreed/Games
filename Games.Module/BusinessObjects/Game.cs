using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl.EF;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Games.Module.BusinessObjects
{
    // Register this entity in your DbContext (usually in the BusinessObjects folder of your project) with the "public DbSet<Game> Games { get; set; }" syntax.
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("Name")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    // You do not need to implement the INotifyPropertyChanged interface - EF Core implements it automatically.
    // (see https://learn.microsoft.com/en-us/ef/core/change-tracking/change-detection#change-tracking-proxies for details).
    public class Game : BaseObject
    {
        public Game()
        {
            // In the constructor, initialize collection properties, e.g.: 
            // this.AssociatedEntities = new ObservableCollection<AssociatedEntityObject>();
        }

        // You can use the regular Code First syntax.
        // Property change notifications will be created automatically.
        // (see https://learn.microsoft.com/en-us/ef/core/change-tracking/change-detection#change-tracking-proxies for details)
        public virtual string Name { get; set; }
        //  public virtual string Description { get; set; }
        public virtual DateTime GameDateTime { get; set; }
        // Alternatively, specify more UI options:
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), VisibleInListView(false)]
        //[RuleRequiredField(DefaultContexts.Save)]
        //public virtual string Name { get; set; }
        //Collection property:
        [Browsable(false)]
        public virtual ICollection<Participant> Participants { get; set; }
        public virtual Int32 Scorer { get; set; }
        [NotMapped]
        [DisplayName("Team1")]
        public virtual ICollection<Participant> Team1 => Participants.Where(p => p.Assignment == AssignmentEnum.Team1)
            .ToList();

        public virtual string Comment { get; set; }
        private CommentInfo _commentInfo;
        [NotMapped]
        public virtual CommentInfo CommentInfo
        {
            get
            {
                if(_commentInfo == null)
                {
                    _commentInfo = new CommentInfo();
                }
                _commentInfo.InfoComment = Comment;
                return _commentInfo;
            }
            set
            {
                _commentInfo = value;
                Comment = _commentInfo.InfoComment;
            }
        }

        [NotMapped]
        [DisplayName("Team2")]
        public virtual ICollection<Participant> Team2 => Participants.Where(p => p.Assignment == AssignmentEnum.Team2)
            .ToList();

        [NotMapped]
        [DisplayName("Spectators1")]
        public virtual ICollection<Participant> Spectators => Participants.Where(
            p => p.Assignment == AssignmentEnum.Spectator)
            .ToList();
        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}