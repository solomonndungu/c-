using Interfaces;

Dog turtle = new Dog();
turtle.DogBarking();

IDogWalker turtle2 = new Dog();
turtle2.WalkToThePark();
turtle2.WalkToTheCity();
turtle2.WalkToTheFoodBowl();