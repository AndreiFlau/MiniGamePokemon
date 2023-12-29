
public class Pokemon
{
    private string? _name { get; set; }
    private string? _type { get; set; }
    private int _hp { get; set; }
    private int _attack { get; set; }
    private int _defense { get; set; }

    private List<string> _moves = new List<string>();

    public string? name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string? type
    {
        get { return _type; }
        set { _type = value; }
    }

    public int hp
    {
        get { return _hp; }
        set { _hp = value; }
    }

    public int attack
    {
        get { return _attack; }
        set { _attack = value; }
    }

    public int defense
    {
        get { return _defense; }
        set { _defense = value; }
    }


    public Pokemon()
    {
        _name = string.Empty;
        _type = string.Empty;
        _hp = 0;
        _attack = 0;
        _defense = 0;
        _moves = new List<string>();
    }


    public void aiPokemon(Pokemon pokemon)
    {
        Random random = new Random();
        int? aiPokemon = random.Next(1, 4);
        switch (aiPokemon)
        {
            case 1:
                CreateCharmander(pokemon);
                break;
            case 2:
                CreateSquirtle(pokemon);
                break;
            case 3:
                CreateBulbasaur(pokemon);
                break;
            default:
                break;
        }
    }

    public void CreateCharmander(Pokemon pokemon)
    {
        pokemon._name = "Charmander";
        pokemon._type = "Fire";
        pokemon._hp = 190;
        pokemon._attack = 52;
        pokemon._defense = 36;
        pokemon._moves = new List<string> { "Ember", "Scratch", "Growl", "Leer" };
    }

    public void CreateSquirtle(Pokemon pokemon)
    {
        pokemon._name = "Squirtle";
        pokemon._type = "Water";
        pokemon._hp = 240;
        pokemon._attack = 48;
        pokemon._defense = 35;
        pokemon._moves = new List<string> { "Water Gun", "Tackle", "Tail Whip", "Growl" };
    }

    public void CreateBulbasaur(Pokemon pokemon)
    {
        pokemon._name = "Bulbasaur";
        pokemon._type = "Grass";
        pokemon._hp = 250;
        pokemon._attack = 49;
        pokemon._defense = 29;
        pokemon._moves = new List<string> { "Vine Whip", "Tackle", "Growl", "Leech Seed" };
    }

    public static void Attack(Pokemon player, Pokemon enemy, string move)
    {
        Console.WriteLine($"{player._name} used {move}!");
        int damage = 0;

        if (player._type == "Fire")
        {
            if (enemy._type == "Grass")
            {
                Console.WriteLine("It's super effective!");
                damage = (player._attack * 2 - enemy._defense);
            }
            else if (enemy._type == "Water")
            {
                Console.WriteLine("It's not very effective...");
                damage = (player._attack / 2 - enemy._defense + 10);
            }
            else
            {
                damage = (player._attack - enemy._defense);
            }
        }
        else if (player._type == "Water")
        {
            if (enemy._type == "Fire")
            {
                Console.WriteLine("It's super effective!");
                damage = (player._attack * 2 - enemy._defense);
            }
            else if (enemy._type == "Grass")
            {
                Console.WriteLine("It's not very effective...");
                damage = (player._attack / 2 - enemy._defense + 10);
            }
            else
            {
                damage = (player._attack - enemy._defense);
            }
        }
        else if (player._type == "Grass")
        {
            if (enemy._type == "Water")
            {
                Console.WriteLine("It's super effective!");
                damage = (player._attack * 2 - enemy._defense);
            }
            else if (enemy._type == "Fire")
            {
                Console.WriteLine("It's not very effective...");
                damage = (player._attack - enemy._defense + 10);
            }
            else
            {
                damage = (player._attack - enemy._defense);
            }
        }

        damage = Math.Max(0, damage);

        enemy._hp -= damage;
    }
    public static void EnemyAttack(Pokemon player, Pokemon enemy)
    {
        Random random = new Random();
        int? aiMove = random.Next(1, 5);

        if (enemy._name == "Charmander")
        {
            switch (aiMove)
            {
                case 1:
                    Attack(enemy, player, "Ember");
                    break;
                case 2:
                    Attack(enemy, player, "Scratch");
                    break;
                case 3:
                    Attack(enemy, player, "Growl");
                    break;
                case 4:
                    Attack(enemy, player, "Leer");
                    break;
                default:
                    break;
            }
        }
        else if (enemy._name == "Squirtle")
        {
            switch (aiMove)
            {
                case 1:
                    Attack(enemy, player, "Water Gun");
                    break;
                case 2:
                    Attack(enemy, player, "Tackle");
                    break;
                case 3:
                    Attack(enemy, player, "Tail Whip");
                    break;
                case 4:
                    Attack(enemy, player, "Bubble");
                    break;
                default:
                    break;
            }
        }
        else if (enemy._name == "Bulbasaur")
        {
            switch (aiMove)
            {
                case 1:
                    Attack(enemy, player, "Vine Whip");
                    break;
                case 2:
                    Attack(enemy, player, "Tackle");
                    break;
                case 3:
                    Attack(enemy, player, "Growl");
                    break;
                case 4:
                    Attack(enemy, player, "Leech Seed");
                    break;
                default:
                    break;
            }
        }
    }

    public static void PlayerAttack(Pokemon player, Pokemon enemy)
    {
        Console.WriteLine("Choose your move:");
        foreach (var _move in player._moves)
        {
            Console.WriteLine(_move);
        }
        Console.WriteLine();
        string? playerMove = Console.ReadLine();

        while (player._moves.Contains(playerMove) == false)
        {
            Console.WriteLine("This move doesn't exist");
            Console.WriteLine("Try again using one of these moves:");
            foreach (var move1 in player._moves)
            {
                Console.WriteLine(move1);
            }
            playerMove = Console.ReadLine();
        }
        Attack(player, enemy, playerMove);
    }
}
