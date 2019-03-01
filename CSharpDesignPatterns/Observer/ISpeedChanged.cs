using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public interface ISpeedChanged
    {
        // method declaration that explains two parameter types
        void ValueHasChanged(object sender, EventArgs args);
    }
}
