using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Rogallo.Presenters
{
    public class PageNavigationEventArgs: EventArgs
    {
        public string NewUrl { get; set; }
        public bool BackButtonEnabled { get; set; }
        public bool ForwardButtonEnabled { get; set; }
    }
}
