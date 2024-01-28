namespace Pet

{
    class Program
    {
        static void Main()
        {
            List<Pet> pets = new List<Pet>();

            // Adding pets
            pets.Add(new Dog("Max"));
            pets.Add(new Cat("Maxina"));
            pets.Add(new Fish("Dory"));
            pets.Add(new Dog("Max2"));
            pets.Add(new Cat("Maxina2"));
            pets.Add(new Fish("Dory2"));

            // printing the pets
            foreach (var pet in pets)
            {
                Console.WriteLine($"Name: {pet.GetName()}, Trick: {pet.GetTrick()}, Noise: {pet.GetNoise()}");
            }
        }
    }
}