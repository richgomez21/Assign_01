public class Car{
    public int Wheels {get; set;}
    public int Speed {get; set;}
    public Person[] Passengers {get; set;}
    public int NumPassengers {get; set;}

    public Car(int wheels){
        this.Wheels = wheels;
    }

    public Car(int wheels, int numPassengers, Person[] passengers){
        this.Wheels = wheels;
        this.NumPassengers = numPassengers;
        this.Passengers = new Person[this.NumPassengers];
    }

    public void ChangeSpeed(int speed){
        this.Speed = speed;
    }

}