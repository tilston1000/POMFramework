These projects have a whole array of things within them to help with automation
1) AUTOMATIONRESOURCES
This contains a WebDriverFactory from where I can control which browsers to invoke for testing

2) CREATINGREPORTS
This is a test project which also has reporting functionality built in using AventStack

3) LOGGINGPRACTISE
This project contains a lot of information on how to use NLog for logging framework

4) SAMPLEAPPFRAMEWORK1/2
Pretty generic project really but there is stuff in here which will be useful

5) WEBDRIVERTIMEOUTS
Everything you need to know about Explicit and Implicit Waits....in short use Explicit Waits! Also refer to the below:
https://www.ultimateqa.com/selenium-3-11-released/

1) update Nuget packages to latest version
2) Install DotNetSeleniumExtras.WaitHelpers nuget packages
3) add 'using' statement for 'using ExpectedConditions =  SeleniumExtras.WaitHelpers.ExpectedConditions;'
