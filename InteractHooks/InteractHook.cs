using InteractIntranet.InteractHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace InteractIntranet.InteractHooks
{
    [Binding]
    public class InteractHook : BaseClass
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}
