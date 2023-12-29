Console.WriteLine("Welcome to pokémon, C# edition");
Console.WriteLine("What's your name?");
string? name = Console.ReadLine();

string? play = "Y";


while (play == "Y" || play == "")
{

    Console.WriteLine($"Great! Nice to meet you {name}!\n");
    Console.WriteLine($"Choose a pokémon {name}!");

    Console.WriteLine("1 - Charmander, 2 - Squirtle, 3 - Bulbasaur");

    int? userPokemonNum = Convert.ToInt32(Console.ReadLine());
    Pokemon userPokemon = new();

    while (userPokemonNum < 1 || userPokemonNum > 3)
    {
        Console.WriteLine("This pokémon doesn't exist");
        Console.WriteLine("Try again");
        userPokemonNum = Convert.ToInt32(Console.ReadLine());
    }
    if (userPokemonNum == 1)
    {
        userPokemon.CreateCharmander(userPokemon);
        Console.WriteLine($"Congratulations! {userPokemon.name} is now your pokémon!");
    }
    else if (userPokemonNum == 2)
    {
        userPokemon.CreateSquirtle(userPokemon);
        Console.WriteLine($"Congratulations! {userPokemon.name} is now your pokémon!");
    }
    else if (userPokemonNum == 3)
    {
        userPokemon.CreateBulbasaur(userPokemon);
        Console.WriteLine($"Congratulations! {userPokemon.name} is now your pokémon!");
    }
    else
    {
        Console.WriteLine("This pokémon doesn't exist");
    }
    Console.WriteLine();


    Console.WriteLine("\n ⚔️ It's time for a pokémon battle!");
    Pokemon aiPokemon = new Pokemon();
    aiPokemon.aiPokemon(aiPokemon);
    Console.WriteLine($"Your opponent threw out a {aiPokemon.name}");

    Random random = new Random();

    int randomNum = random.Next(1, 3);


    if (randomNum == 1)
    {
        Console.WriteLine($"\nYour pokémon's hp: {userPokemon.hp} vs Your opponent's pokémon's hp: {aiPokemon.hp}\n");
        while ((aiPokemon.hp > 0 || userPokemon.hp > 0))
        {
            if (aiPokemon.hp <= 0)
            {
                Console.WriteLine("Congratulations! You won!");
                break;
            }
            else if (userPokemon.hp <= 0)
            {
                Console.WriteLine("Your opponent won this time...");
                break;
            }
            Pokemon.PlayerAttack(userPokemon, aiPokemon);
            Console.WriteLine($"\nYour pokémon's hp: {userPokemon.hp} vs Your opponent's pokémon's hp: {aiPokemon.hp}\n");
            if (aiPokemon.hp <= 0)
            {
                Console.WriteLine("Congratulations! You won!");
                break;
            }
            else if (userPokemon.hp <= 0)
            {
                Console.WriteLine("Your opponent won this time...");
                break;
            }
            Pokemon.EnemyAttack(userPokemon, aiPokemon);
            Console.WriteLine($"\nYour pokémon's hp: {userPokemon.hp} vs Your opponent's pokémon's hp: {aiPokemon.hp}\n");
        }
    }

    else if (randomNum == 2)
    {
        Console.WriteLine($"\nYour pokémon's hp: {userPokemon.hp} vs Your opponent's pokémon's hp: {aiPokemon.hp}\n");
        while ((aiPokemon.hp > 0 || userPokemon.hp > 0))
        {
            if (aiPokemon.hp <= 0)
            {
                Console.WriteLine("Congratulations! You won!");
                break;
            }
            else if (userPokemon.hp <= 0)
            {
                Console.WriteLine("Your opponent won this time...");
                break;
            }
            Pokemon.EnemyAttack(userPokemon, aiPokemon);
            Console.WriteLine($"\nYour pokémon's hp: {userPokemon.hp} vs Your opponent's pokémon's hp: {aiPokemon.hp}\n");
            if (aiPokemon.hp <= 0)
            {
                Console.WriteLine("Congratulations! You won!");
                break;
            }
            else if (userPokemon.hp <= 0)
            {
                Console.WriteLine("Your opponent won this time...");
                break;
            }
            Pokemon.PlayerAttack(userPokemon, aiPokemon);
            Console.WriteLine($"\nYour pokémon's hp: {userPokemon.hp} vs Your opponent's pokémon's hp: {aiPokemon.hp}\n");
        }
    }


    Console.WriteLine("Play again?");
    play = Console.ReadLine();
}
