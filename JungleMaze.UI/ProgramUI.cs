
public class ProgramUI
{
    private CharacterRepository _cRepo = new CharacterRepository();
    private LevelRepository _lRepo = new LevelRepository();
    private Character player;
    private Character monkey;
    private Character wildBoar;
    private Character croc;
    private Level lv1;
    private Level lv2;
    private bool hasCompletedLv1 = false;
    private bool hasCompletedLv2 = false;
    private bool hasCompletedGame = false;
     bool isRunning = true;
    public ProgramUI()
    {
        player = _cRepo.GetCharacter(1);
        monkey = _cRepo.GetCharacter(2);
        wildBoar = _cRepo.GetCharacter(3);
        croc = _cRepo.GetCharacter(4);

        lv1 = _lRepo.GetLevel(1);
        lv2 = _lRepo.GetLevel(2);
    }

    public void Run()
    {
        RunApplication();
    }

    private void RunApplication()
    {
       
        while (isRunning)
        {
            Console.Clear();

            System.Console.WriteLine("Welcome to the Jungle Maze!\n" +
            "1. Start Adventure\n" +
            "2. Quit Game\n");

            string userInput = Console.ReadLine()!;

            switch (userInput)
            {
                case "1":
                    StartAdventure(); // ctrl + . -> gen
                    break;
                case "2":
                    isRunning = QuitGame();
                    break;
                default:
                    System.Console.WriteLine("Invalid Selection.");
                    break;
            }
        }
    }
    private bool QuitGame()
    {
        System.Console.WriteLine("Thanks for playing!");

        PressAnyKey();
        Console.Clear();
        return false;

    }
    private void PressAnyKey()
    {
        System.Console.WriteLine("PressAnyKey any key to continue.");
        Console.ReadKey();
    }

    private void StartAdventure()
    {
        Console.Clear(); //clears the screen
        GameManager.TellTheStory($"Welcome to the junlge, you are {player.Name}, and you need to find a way out!");
        while (hasCompletedLv1 == false)
        {
            GameManager.TellTheStory($"{lv1.Title}\n" +
        "You have 4 options\n" +
        "1.Up\n" +
        "2.Down\n" +
        "3.Left\n" +
        "4.Right\n");

            int userInput = int.Parse(Console.ReadLine()!);
            Direction conversion = (Direction)userInput;

            switch (conversion)
            {
                case Direction.Up:
                Console.Clear();
                    System.Console.WriteLine(_lRepo.GetLevel(1).Scenario[0].ScenarioText);
                    break;
                case Direction.Down:
                Console.Clear();
                    System.Console.WriteLine(_lRepo.GetLevel(1).Scenario[1].ScenarioText);
                    break;
                case Direction.Left:
                Console.Clear();
                    System.Console.WriteLine(_lRepo.GetLevel(1).Scenario[2].ScenarioText);
                    hasCompletedLv1 = true;
                    break; 
                case Direction.Right:
                Console.Clear();
                    System.Console.WriteLine(_lRepo.GetLevel(1).Scenario[3].ScenarioText);
                    break;
                default:
                    System.Console.WriteLine("Invalid Selection.");
                    break;
            }
        }
        GameManager.TellTheStory("Welcome to lvl2\n" +
        $"{lv2.Title}\n");

        while (hasCompletedLv1 == true && hasCompletedLv2 == false)
        {
            GameManager.TellTheStory($"{lv2.Title}\n" +
        "You have 4 options\n" +
        "1.Up\n" +
        "2.Down\n" +
        "3.Left\n" +
        "4.Right\n");

            int userInput = int.Parse(Console.ReadLine()!);
            Direction conversion = (Direction)userInput;

            switch (conversion)
            {
                case Direction.Up:
                Console.Clear();
                    System.Console.WriteLine(_lRepo.GetLevel(2).Scenario[0].ScenarioText);
                    break;
                case Direction.Down:
                Console.Clear();
                    System.Console.WriteLine(_lRepo.GetLevel(2).Scenario[1].ScenarioText);
                    hasCompletedLv2 = true;
                    hasCompletedGame = true;
                    break;
                case Direction.Left:
                Console.Clear();
                    System.Console.WriteLine(_lRepo.GetLevel(2).Scenario[2].ScenarioText);
                    break;
                case Direction.Right:
                Console.Clear();
                    System.Console.WriteLine(_lRepo.GetLevel(2).Scenario[3].ScenarioText);
                    break;
                default:
                    System.Console.WriteLine("Invalid Selection.");
                    break;
            }

            //PressAnyKey(); // stops the proccess
        }

        if(hasCompletedGame == true)
        {
            isRunning = QuitGame();

        }
    }
}
