using System;
using TechTalk.SpecFlow;

namespace SmallStore.German.Tests
{
    [Binding]
    public class RundenSteps
    {
        [Given(@"der Eintrag enthält (.*) Credit")]
        public void AngenommenDerEintragEnthaltCredit(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"das Protokoll angeschaut wird")]
        public void WennDasProtokollAngeschautWird()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"wird dem Benutzer (.*) Credit angezeigt")]
        public void DannWirdDemBenutzerCreditAngezeigt(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
