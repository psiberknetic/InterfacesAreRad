using CMS.Common;
using CMS.Common.Extensions;
using FluentAssertions;
using System;
using TechTalk.SpecFlow;

namespace ContactProviderTests
{
    [Binding]
    public class NameParsingSteps
    {
        string _nameToParse = String.Empty;
        Name _parsedName = null;

        [Given(@"I have a (.*)")]
        public void GivenIHaveA(string p0)
        {
            _nameToParse = p0;
        }

        [When(@"I parse the name into first middle and last")]
        public void WhenIParseTheNameIntoFirstMiddleAndLast()
        {
            _parsedName = NameUtilities.ParseName(_nameToParse);
        }

        [Then(@"I should get the following (.*), (.*), and (.*)")]
        public void ThenIShouldGetTheFollowingAnd(string p0, string p1, string p2)
        {
            _parsedName.First.Should().Be(p0);
            _parsedName.Middle.Should().Be(p1);
            _parsedName.Last.Should().Be(p2);
        }
    }
}
