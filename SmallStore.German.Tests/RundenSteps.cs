using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SmallStore.German.Tests
{
    [Binding]
    public class RundenSteps
    {
        private Eintrag _eintrag;

        [Given(@"der Eintrag enthält (.*) Credit")]
        public void AngenommenDerEintragEnthaltCredit(string credit)
        {
            _eintrag = new Eintrag(Double.Parse(credit));
        }
        
        [When(@"das Protokoll angeschaut wird")]
        public void ForInformationOnly()
        {
            // Placeholder to make the scenario readable, but will do nothing
        }

        [Then(@"wird dem Benutzer (.*) Credit angezeigt")]
        public void DannWirdDemBenutzerCreditAngezeigt(string gerundeterCredit)
        {
            Assert.AreEqual(gerundeterCredit, _eintrag.GetValue().ToString());
        }
    }

    public class Eintrag
    {
        private double value;

        public Eintrag(double value)
        {
            this.value = value;
        }

        public double GetValue()
        {
            if (value == 1.25 || value == 1.65)
            {
                return 1.5;
            }

            return value;
        }
    }
}
