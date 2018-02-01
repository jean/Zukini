﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Zukini.UI.Examples.Features.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SmokeTest")]
    [NUnit.Framework.CategoryAttribute("ui")]
    public partial class SmokeTestFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "SmokeTest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "SmokeTest", "\tIn order to provide an example of Zukini\r\n\tAs a user\r\n\tI want to try it out agai" +
                    "nst Google", ProgrammingLanguage.CSharp, new string[] {
                        "ui"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Perform a google search for SpecFlow returns specflow.org site")]
        [NUnit.Framework.CategoryAttribute("google_search")]
        public virtual void PerformAGoogleSearchForSpecFlowReturnsSpecflow_OrgSite()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Perform a google search for SpecFlow returns specflow.org site", new string[] {
                        "google_search"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I navigate to Google", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
 testRunner.And("I enter a search value of \"SpecFlow\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("I press Google Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("I should see \"specflow.org\" in the results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to show how to use row and cell helpers")]
        [NUnit.Framework.CategoryAttribute("table_example")]
        public virtual void IWantToShowHowToUseRowAndCellHelpers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to show how to use row and cell helpers", new string[] {
                        "table_example"});
#line 15
this.ScenarioSetup(scenarioInfo);
#line 16
 testRunner.Given("I navigate to W3Schools table reference page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.Then("I should see that the table tag is supported in \"Chrome\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.And("I should see that the table tag is supported in \"IE\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I should see that the table tag is supported in \"FireFox\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("I should see that the table tag is supported in \"Safari\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to demonstrate how to use the property bucket")]
        [NUnit.Framework.CategoryAttribute("property_bucket")]
        public virtual void IWantToDemonstrateHowToUseThePropertyBucket()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to demonstrate how to use the property bucket", new string[] {
                        "property_bucket"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
 testRunner.Given("I navigate to W3Schools table reference page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.And("I remember the sub-header text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.Then("the sub-header text should have been \"THE WORLD\'S LARGEST WEB DEVELOPER SITE\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Performing a search for SpecFlow and expecting random text should fail and give m" +
            "e a screenshot")]
        [NUnit.Framework.IgnoreAttribute("Ignored scenario")]
        public virtual void PerformingASearchForSpecFlowAndExpectingRandomTextShouldFailAndGiveMeAScreenshot()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Performing a search for SpecFlow and expecting random text should fail and give m" +
                    "e a screenshot", new string[] {
                        "ignore"});
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given("I navigate to Google", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.And("I enter a search value of \"SpecFlow\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.When("I press Google Search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then("I should see \"ZZZXXXYYYGGGJJJPPPP\" in the results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to demonstrate how to use SpecFlow data tables")]
        [NUnit.Framework.CategoryAttribute("table_example")]
        [NUnit.Framework.TestCaseAttribute("Chrome", null)]
        [NUnit.Framework.TestCaseAttribute("IE", null)]
        [NUnit.Framework.TestCaseAttribute("FireFox", null)]
        [NUnit.Framework.TestCaseAttribute("Safari", null)]
        public virtual void IWantToDemonstrateHowToUseSpecFlowDataTables(string browser, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "table_example"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to demonstrate how to use SpecFlow data tables", @__tags);
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
 testRunner.Given("I navigate to W3Schools table reference page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Browser"});
            table1.AddRow(new string[] {
                        string.Format("{0}", browser)});
#line 38
 testRunner.Then("I should see that the table tag is supported for the following", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to demonstrate how to wait for a button to appear")]
        [NUnit.Framework.CategoryAttribute("browser_session_extension")]
        public virtual void IWantToDemonstrateHowToWaitForAButtonToAppear()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to demonstrate how to wait for a button to appear", new string[] {
                        "browser_session_extension"});
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given("I create a delayed button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.Then("the delayed button should eventually exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
  testRunner.And("the delayed button has a size and location", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to demonstrate how to try until a button appears")]
        [NUnit.Framework.CategoryAttribute("browser_session_extension")]
        public virtual void IWantToDemonstrateHowToTryUntilAButtonAppears()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to demonstrate how to try until a button appears", new string[] {
                        "browser_session_extension"});
#line 55
this.ScenarioSetup(scenarioInfo);
#line 56
 testRunner.Given("I create a button that creates a delayed button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
 testRunner.When("I use TryUntil on the button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 58
 testRunner.Then("the second button should exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("WaitForNavigation does timeout")]
        [NUnit.Framework.CategoryAttribute("browser_session_extension")]
        public virtual void WaitForNavigationDoesTimeout()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WaitForNavigation does timeout", new string[] {
                        "browser_session_extension"});
#line 61
this.ScenarioSetup(scenarioInfo);
#line 62
 testRunner.Given("I try to navigate to a url that changes the browser location", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
 testRunner.Then("navigation does timeout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("WaitForNavigation does not timeout")]
        [NUnit.Framework.CategoryAttribute("browser_session_extension")]
        public virtual void WaitForNavigationDoesNotTimeout()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WaitForNavigation does not timeout", new string[] {
                        "browser_session_extension"});
#line 66
this.ScenarioSetup(scenarioInfo);
#line 67
 testRunner.Given("I try to navigate to Google", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.Then("navigation does not timeout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to demonstrate view factory can wait for pages")]
        [NUnit.Framework.CategoryAttribute("viewfactory")]
        public virtual void IWantToDemonstrateViewFactoryCanWaitForPages()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to demonstrate view factory can wait for pages", new string[] {
                        "viewfactory"});
#line 71
this.ScenarioSetup(scenarioInfo);
#line 72
 testRunner.Given("I navigate to some page with delayed element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
 testRunner.Then("view factory can wait for delayed page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 74
 testRunner.And("view factory throws an exception on attempt to load different page object", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.But("view factory can get different page object without waiting for it", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to demonstrate view factory can work with components")]
        [NUnit.Framework.CategoryAttribute("viewfactory")]
        [NUnit.Framework.CategoryAttribute("page_component")]
        public virtual void IWantToDemonstrateViewFactoryCanWorkWithComponents()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to demonstrate view factory can work with components", new string[] {
                        "viewfactory",
                        "page_component"});
#line 78
this.ScenarioSetup(scenarioInfo);
#line 79
 testRunner.Given("I navigate to some page with components", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 80
 testRunner.Then("I can see a video object with title \'Rhapsody\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.When("I click play for \'Star Wars\' video", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 82
 testRunner.Then("player controls appear in \'Star Wars\' video player", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to demostrate view factory can create many components")]
        [NUnit.Framework.CategoryAttribute("viewfactory")]
        [NUnit.Framework.CategoryAttribute("page_component")]
        public virtual void IWantToDemostrateViewFactoryCanCreateManyComponents()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to demostrate view factory can create many components", new string[] {
                        "viewfactory",
                        "page_component"});
#line 85
this.ScenarioSetup(scenarioInfo);
#line 86
 testRunner.Given("I navigate to some page with components", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 87
 testRunner.Then("I can load \'2\' gallery components with view factory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 88
 testRunner.And("I can find gallery component using view factory with title \'Image 2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I want to demostrate view factory fails when no expected component present")]
        [NUnit.Framework.CategoryAttribute("viewfactory")]
        [NUnit.Framework.CategoryAttribute("page_component")]
        public virtual void IWantToDemostrateViewFactoryFailsWhenNoExpectedComponentPresent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("I want to demostrate view factory fails when no expected component present", new string[] {
                        "viewfactory",
                        "page_component"});
#line 91
this.ScenarioSetup(scenarioInfo);
#line 92
 testRunner.Then("exception appear if I load component with view factory that does not exist", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
