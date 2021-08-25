namespace Animal
{
    class Chicken: Animal, IEdible
    {
        public override string makeSound()
        {
            return "Chicken: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }
}