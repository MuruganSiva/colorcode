# colorcode
Ohm Calculator App for home depot coding assesment

Following projects are created as part of this coding assesment

	ColorCode.App -> MVC web interface to calculate the ohm value
	ColorCode.Provider -> An abstraction to the web layer which handles the business logic and model preparation logic
	ColorCode.Business -> Business layer for IOhmValueCalculator inteface and implementation
	ColorCode.Data -> Data layer which has the in-memory storage for color code data and the APIs to access the data

-> Used an in-memory data storage mechanism for mainitaining the color code data.
-> I have choosen MVC Core as the option to build the web interface.
-> Used .NET Core built in depedency injection to achieve loose coupling between objects and dependencies.
-> Used MSTest framework for unit test and Moq for creating MOCK objects. Unit test is created just for the business layer as a sample implementation.
-> Focused more on the implementation approach rather than CSS and accuracy of business logic
-> The UI interface could have been approached in multiple ways (Ex: Using a WEB API to calculate the ohm value and refresh only part of the page with some help from jQuery or JavaScript; Using a modern client side library like Angular JS). Since the expectation is to just use MVC, I have used the simple approach.


