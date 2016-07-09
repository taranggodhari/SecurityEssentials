﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SecurityEssentials.Acceptance.Tests.Web.Pages;
using TechTalk.SpecFlow;

namespace SecurityEssentials.Acceptance.Tests.Web.Extensions
{
	[Binding]
	public class ChangePasswordSteps
	{

		[Given(@"I enter the following change password data:")]
		public void GivenIEnterTheFollowingChangePasswordData(Table table)
		{
			var changePasswordPage = ScenarioContext.Current.GetPage<ChangePasswordPage>();
			changePasswordPage.EnterDetails(table);
		}

		[When(@"I submit the change password form")]
		public void WhenISubmitTheChangePassordForm()
		{
			var changePasswordPage = ScenarioContext.Current.GetPage<ChangePasswordPage>();
			changePasswordPage.ClickSubmit();
		}

		[Scope(Scenario="I can change my password")]
		[Then(@"A confirmation message '(.*)' is shown")]
		public void ThenAConfirmationMessageIsShown(string message)
		{
			var changePasswordPage = ScenarioContext.Current.GetPage<ChangePasswordPage>();
			Assert.IsTrue(changePasswordPage.GetStatusMessage().Contains(message));
		}


	}
}