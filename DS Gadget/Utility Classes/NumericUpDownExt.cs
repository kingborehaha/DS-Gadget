using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_Gadget
{
    public partial class NumericUpDownExt : NumericUpDown
    {
        public NumericUpDownExt()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonClicked;
        
        public override void UpButton()
        {
            base.UpButton();
            OnButtonClicked(EventArgs.Empty);
        }

        public override void DownButton()
        {
            base.DownButton();
            OnButtonClicked(EventArgs.Empty);
        }

        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }
    }
}
