using System.Globalization;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using SamplesApp.UITests.TestFramework;
using Uno.UITest.Helpers;
using Uno.UITest.Helpers.Queries;

namespace SamplesApp.UITests.Windows_UI_Xaml_Controls.ButtonTests
{
	public class UnoSamples_Test_NativeButtons : SampleControlUITestBase
	{
		[Test]
		[ActivePlatforms(Platform.iOS, Platform.Android)]
		[AutoRetry]
		public void NativeButtonTests()
		{
			Run("UITests.Shared.Windows_UI_Xaml_Controls.Buttons_Native");

			var result = _app.Marked("result");
			var resultCommand = _app.Marked("resultCommand");
			var resultTapped = _app.Marked("resultTapped");

			var button01 = _app.Marked("button01");
			var button02 = _app.Marked("button02");
			var enableButton02 = _app.Marked("enableButton02");
			var toggleSwitch01 = _app.Marked("toggleSwitch01");
			var toggleSwitch02 = _app.Marked("toggleSwitch02");
			var enableToggleSwitch02 = _app.Marked("enableToggleSwitch02");

			_app.WaitForElement(button01);

			_app.Tap(button01);
			_app.WaitForText(result, "Button button01 Clicked (1)");
			_app.WaitForText(resultTapped, "Button button01 Tapped (1)");
			_app.WaitForText(resultCommand, "Command Button 01 (1)");

			_app.Tap(button02);
			_app.WaitForText(result, "Button button01 Clicked (1)");
			_app.WaitForText(resultTapped, "Button button01 Tapped (1)");
			_app.WaitForText(resultCommand, "Command Button 01 (1)");

			_app.Tap(enableButton02);
			_app.Tap(button02);
			_app.WaitForText(result, "Button button02 Clicked (2)");
			_app.WaitForText(resultTapped, "Button button02 Tapped (2)");
			_app.WaitForText(resultCommand, "Command Button 02 (2)");

			_app.Tap(toggleSwitch01);
			_app.WaitForText(result, "ToggleSwitch toggleSwitch01 Toggled True (1)");

			_app.Tap(toggleSwitch01);
			_app.WaitForText(result, "ToggleSwitch toggleSwitch01 Toggled False (2)");

			_app.Tap(toggleSwitch02);
			_app.WaitForText(result, "ToggleSwitch toggleSwitch01 Toggled False (2)");

			_app.Tap(enableToggleSwitch02);
			_app.Tap(toggleSwitch02);
			_app.WaitForText(result, "ToggleSwitch toggleSwitch02 Toggled True (3)");

			_app.Tap(toggleSwitch02);
			_app.WaitForText(result, "ToggleSwitch toggleSwitch02 Toggled False (4)");
		}
	}
}
