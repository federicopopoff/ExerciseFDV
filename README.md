# FDV Exercise

Rental Bikes Classes

## The design

Link to the diagram: https://1drv.ms/i/s!Au4hKbtJmoEvh_UIIjxB90DQfok58w

## The development practices

### Interface:

		I have child classes and should implement a certain group of methods/functionalities 
 		but each of the child classes is free to provide its own implementation. For example: The "UnitCost".

		And I need to introduce polymorphic behavior without subclassing and to model multiple 
		inheritance—allowing a specific type to support numerous behaviors. For example: "The List<IRental>".

### Dessign pattern -> Template Method:
		
		The template method pattern is useful in such scenarios where there is an algorithm and some small part of that algorithm may vary. 
		For example, the abstract class "Rental" and the derived classes like RentalHours, RentalWeek and RentalDay.
		
		The definition of Template method pattern is "Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
		Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.".
		
		I divided the system into the following components for the implementation of this pattern:

			Abstract Class: This will be an abstract class, that will have the abstract properties of the "UnitCost" and "Quantity of the rents", that will be implemented in the sub-classes based on the rentals and the non-abstract methods of the total calculation of the rental cost.
	
 			Concrete Classes: These will be concrete implementations of our abstract rental type, depending on the types of the rental.

### How to run the tests

	1. Open the solution in Visual Studio 2013/2015.
	2. Click in menu Test and Run -> AllTests.

## Built With

* [Visual Studio 2015](https://www.visualstudio.com/) - The IDE for Microsoft applicattions. 

## Authors

* **Federico Popoff** - *Initial work* - [federicopopoff](https://gist.github.com/federicopopoff/)
