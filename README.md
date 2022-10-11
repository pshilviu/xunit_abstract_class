# xunit_abstract_class

Code that allows reproducing the "No source available" message in Test Explorer.

## How to reproduce:

- Create test(s) in an [abstract class](HelloWorld.Api/UnitTests.Common/BaseControllerTests.cs) in a different assembly than the current running tests.
- Create a new Test Project, with a test class, that derives from the above created shared class. See [HelloWorldControllerTests.cs](HelloWorld.Api/HelloWorld.Api.Tests/HelloWorldControllerTests.cs)
- Observe that:
  - Test [BaseDiffAssembly_ShouldBeDecoratedWithExcludeFromCodeCoverageAttribute]() test is not able to find Source, and thus one cannot navigate to the test from the Test Explorer  
  ![image](https://user-images.githubusercontent.com/67609302/195065762-90553b1b-23f5-4220-b07c-75a531b497ff.png)  
  
  - Test [BaseSameAssembly_ShouldBeDecoratedWithExcludeFromCodeCoverageAttribute]() coming from a [shared abstract class](HelloWorld.Api/HelloWorld.Api.Tests/Common/LocalBaseControllerTests.cs) but, found in the same assembly as the UnitTest project is able to resolve the Source and thus able to navigate to the test  
  ![image](https://user-images.githubusercontent.com/67609302/195066023-463fff71-a123-4e6b-a597-562a1b6a9fb8.png)  

  - How to navigate to test code  
  ![image](https://user-images.githubusercontent.com/67609302/195067117-086de9ef-3229-463a-8a2c-9bb0634b4fc9.png)  
  
## Other notes:
- The same behaviour is observed regardless of using xUnit or MsTest
- Using Resharpers Test Window one is able to navigate to the test codes in both scenarios
