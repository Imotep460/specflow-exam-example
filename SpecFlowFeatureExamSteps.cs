using System;
using TechTalk.SpecFlow;

namespace specflow
{
    /// <summary>
    /// to run the tests Comment out "ScenarioContext.StepIsPending();"
    /// </summary>
    [Binding]
    public class SpecFlowFeatureExamSteps
    {
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            ScenarioContext.StepIsPending();
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            ScenarioContext.StepIsPending();
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            ScenarioContext.StepIsPending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.StepIsPending();
        }

        [Then(@"I Am a Happy camper")]
        public void ThenIAmAHappyCamper()
        {
            ScenarioContext.StepIsPending();
        }
    }
}
