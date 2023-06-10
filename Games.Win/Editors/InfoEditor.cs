using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using Games.Module.BusinessObjects;
using System.Diagnostics;

namespace Games.Win.Editors
{
    [PropertyEditor(typeof(CommentInfo), true)]
    public class InfoEditor : PropertyEditor
    {
        private InfoControl control = null;

        protected override void ReadValueCore()
        {
            if(control != null)
            {
                if(CurrentObject != null)
                {
                    control.ReadOnly = false;
                    control.Value = (CommentInfo)PropertyValue;
                } else
                {
                    control.ReadOnly = true;
                    control.Value = null;
                }
            }
        }

        private void control_ValueChanged(object sender, EventArgs e)
        {
            if(!IsValueReading)
            {
                OnControlValueChanged();
                WriteValueCore();
            }
        }

        protected override object CreateControlCore()
        {
           
            control = new InfoControl();
            control.ValueChanged += control_ValueChanged;
            return control;
        }

        protected override void OnControlCreated()
        {
            base.OnControlCreated();
            ReadValue();
        }

        public InfoEditor(Type objectType, IModelMemberViewItem info) : base(objectType, info)
        {
          
        }

        protected override void Dispose(bool disposing)
        {
            if(control != null)
            {
                control.ValueChanged -= control_ValueChanged;
                control = null;
            }
            base.Dispose(disposing);
        }

        //RepositoryItem IInplaceEditSupport.CreateRepositoryItem()
        //{
        //    RepositoryItemSpinEdit item = new RepositoryItemSpinEdit();
        //    item.MinValue = 0;
        //    item.MaxValue = 5;
        //    item.Mask.EditMask = "0";
        //    return item;
        //}
        protected override object GetControlValueCore()
        {
            if(control != null)
            {
                return  control.Value;
            }
            return null;
        }
    }
}
 