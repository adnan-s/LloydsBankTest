using System;
using TechTalk.SpecFlow;

namespace LloydsBankGroup.Test.Steps
{
    [Binding]
    public class CurrentAccountProductsFeatureSteps
    {
        [Given(@"I launch the application")]
        public void GivenILaunchTheApplication(string url)
        {
            Console.WriteLine(url);
        }

        [Then(@"the page is displayed")]
        public void ThenThePageIsDisplayed(string pageUrl)
        {
            if (pageUrl == "https://www.lloydsbank.com/")
            {
                Console.WriteLine("The Test is Passed");
            }
            else
            {
                Console.WriteLine("The Test is Failed");
            }
        }

    }
}
