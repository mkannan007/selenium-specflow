# Please follow the below steps to run this in your local machine


1. Download and Install Visual Studio via https://visualstudio.microsoft.com/downloads/ (Community edition is fine)
2. Clone this GitHub repository in your local machine (ref: https://docs.github.com/en/repositories/creating-and-managing-repositories/cloning-a-repository)
3. Open the Project Solution in the Visual Studio via File menu (ref: https://learn.microsoft.com/en-us/visualstudio/get-started/tutorial-open-project-from-repo?view=vs-2022)
4. Update the dependencies using Manage NuGet Packages (ref: https://learn.microsoft.com/en-us/nuget/consume-packages/reinstalling-and-updating-packages)
5. Build the Solution (ref: https://learn.microsoft.com/en-us/visualstudio/ide/building-and-cleaning-projects-and-solutions-in-visual-studio?view=vs-2022#to-build-rebuild-or-clean-an-entire-solution)
6. Go to Test menu and select "Test Explorer"
7. Click Run button to run the test (ref: https://learn.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2022)

## Standard Test Output should be displayed in the Test Explorer

![Screenshot 2024-01-13 232401](https://github.com/mkannan007/web-tech-test/assets/37662555/9ac9d1cb-a95d-400b-8a32-5b7d85ff964b)

## To see the html report after the test execution

Open terminal via (View menu --> Terminal) and entering the cmd 
- `cd .\bin\debug\net6.0\`
- `livingdoc test-assembly WebTechTest.dll -t TestExecution.json`

![Screenshot 2024-01-13 232559](https://github.com/mkannan007/web-tech-test/assets/37662555/0e029bcf-6846-4411-9a4a-15b482bf7574)
