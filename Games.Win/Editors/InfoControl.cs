using Games.Module.BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games.Win.Editors
{
    public partial class InfoControl : DevExpress.XtraEditors.XtraUserControl
    {
        public InfoControl()
        {
            InitializeComponent();
        }

        private CommentInfo _value;
        public virtual CommentInfo Value { get { return _value; } set { _value = value; 
            
            memoEdit1.Text = _value.InfoComment;
            } }


        public bool ReadOnly { get; internal set; }
        public Action<object, EventArgs> ValueChanged { get; internal set; }

       

        private void memoEdit1_TextChanged(object sender, EventArgs e)
        {
           
            _value.InfoComment = memoEdit1.Text;
            ValueChanged?.Invoke(sender, e);
        }

        private void InfoControl_Load(object sender, EventArgs e)
        {

        }
    }
}
