using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SmallStore.German.Tests
{
    [Binding]
    public class KorrektesRundenSteps
    {
        private Eintrag _eintrag;

        [When(@"der Eintrag (.*) hat")]
        public void WennDerEintragHat(string credits)
        {
            _eintrag = new Eintrag(Double.Parse(credits));
        }
        
        [Then(@"wird (.*) angezeigt")]
        public void DannWirdAngezeigt(string gerundeteCredits)
        {
            Assert.AreEqual(gerundeteCredits, _eintrag.GetValue().ToString());
        }
    }
}
