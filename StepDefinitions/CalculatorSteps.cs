using NUnit.Framework;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace BritTest
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private ScenarioContext _scenarioContext;

        public SpecFlowFeature1Steps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        [Given(@"I have an instruction input file '(.*)'")]
        public void GivenIHaveAInstructionInputFile(string fileName)
        {
            var instructions = FileReader.Readfile(fileName);
            _scenarioContext["instructions"] = instructions;
        }

        [When(@"I calculate as per instructions in the file")]
        public void WhenICalculateAsPerInstructions()
        {
            var result =Calculator.calculate((Dictionary<string, double>)_scenarioContext["instructions"]);
            _scenarioContext["actualResult"] = result;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(double expectedResult)
        {
            Assert.AreEqual(expectedResult, (double)_scenarioContext["actualResult"]);
        }

    }
}
