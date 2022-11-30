// // // CW: Think of a real world class which contains 
// // // => 3 fields
// // // => a parameter constructor
// // // => a constructor with 2 parameters
// // // => a method

// // class Car
// // {
// //     public Car()
// //     {

// //     }

// //     public Car(string carName, string carColor)
// //     {
// //         name = carName;
// //         color = carColor;
// //     }
// //     public string name;
// //     public string color;
// //     public int model;

// //     public string getDetails(string name, string color, int model)
// //     {
// //         string detail = name + color + model;
// //         return detail;
// //     }
// // }

// class Animal
// {
//     // Parameterless constructor - default
//     public Animal()
//     {
//     }

//     // Parameterized constructor
//     public Animal(string animalCategory, byte legs)
//     {
//         category = animalCategory;
//         numberOfLegs = legs;
//     }

//     public Animal(string animalCategory)
//     {
//         category = animalCategory;
        
//     }

//     public string category;
//     public byte numberOfLegs;
// }

/* CW: Think of a real world classs which contains;
- 3 fields
- a parameterless constructor
- a constrictor with 2 parameters
- a method
- a property with full defination
- a read only property
*/

class House
{
    //bool haveGarage;
    short numberOfFloors;
    short numberOfRooms;

    public float Length{get;set;}
    public float Width{get;set;}
    

    public House()
    {
        
    }

    public House(short nof, short nor)
    {
        numberOfFloors = nof;
        numberOfRooms = nor;

    }
    
    public House(short nof, short nor, float l, float w)
    {
        numberOfFloors = nof;
        numberOfRooms = nor;
        Length = l;
        Width = w;

    }

    public float GetAreaOfChat() => Length * Width;
}