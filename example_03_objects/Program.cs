// See https://aka.ms/new-console-template for more information


int x = 8;
Car bug = new Car(x);

Person john = new Person("john", "smith", 21);
Person jane = new Person("jane", "smith", 21);

Console.WriteLine("bug num seats: " + bug.Passengers.Length);

bug.Passengers[0] = jane;
bug.Passengers[1] = john;
Console.WriteLine("the passenger: " + bug.Passengers[3].FirstName);

bug.Passengers[1] = new Person("cody", "brown", 28);

//Print out the person at index 1 in the Passengers in the 
// following format:
// "Passenger 1: Name: <last_name>, <first_name>. Age: <age>."
Console.WriteLine("Passenger 1: + Name: " + bug.Passengers[1].LastName + ", " + bug.Passengers[1].FirstName + ". Age: " + bug.Passengers[1].Age);

// Make up a variable name for a variable of type Person.
// Set that person equal to the person that is at index 1
// in the passengers array. then print out the following:
// "<person_first_name> is in the car with <jane_first_name."
Person p_seat = bug.Passengers[1];
Console.WriteLine(p_seat.FirstName + " is in the car with " + jane.FirstName);

Console.WriteLine("name: " + bug.Passengers)