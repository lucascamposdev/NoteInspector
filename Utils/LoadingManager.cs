using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class LoadingManager
{
    public bool isLoading = false;

    public void Loading(Control control, bool enabled)
    {

        isLoading = true;
        foreach (Control c in control.Controls)
        {
            c.Enabled = enabled;

            if (c.HasChildren)
            {
                Loading(c, enabled);
            }
        }
    }

    public void Stop(Control control)
    {
        Loading(control, true);

        isLoading = false;
    }
}
