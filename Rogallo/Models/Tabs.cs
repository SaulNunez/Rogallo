using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Rogallo.Models
{
    class Tabs
    {
        public Page Page { get; set; }
        public bool CanGoBack { get; set; } = false;
        public bool CanGoForward {get; set;} = false;
        public bool HasFinishedLoading {get; set; } = false;
    }
}
