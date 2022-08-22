using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Rogallo
{
    class MainPresenter
    {
        private bool backPageAvailable = false;
        private bool forwardPageAvailable = false;
        private string pageUrl;

        private int currentTab = 0;

        private List<Tabs> tabs = new List<Tabs>();

        public event EventHandler<PageNavigationEventArgs> OnNewPageNavigation;
        public event EventHandler OnPageLoaded;
        public event EventHandler OnUrlRewrite;

        public void ReloadPage()
        {

        }

        public void UserWantsToNavigate(string newUrl)
        {

        }
    }
}
