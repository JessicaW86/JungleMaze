
    public class Player:Character
    {
        public Player(string name, List<InGameItem> inGameItems) 
        {
            Name = name;
            InGameItems = inGameItems;

        }
        public List<InGameItem> InGameItems {get; set; } = new List<InGameItem>();
        public void UseItem(InGameItem item, Character character = null!, int damage = 0)
        {
            if(item.Name == "Knife")
        {
            if(character.Health > 0)
            {
                character.Health -= damage; 
                System.Console.WriteLine($"You Stabbed: {character.Name}, it has {character.Health} left!!!");
            }  
        }
        else
        {
            System.Console.WriteLine($"{this.Name} is using {item}.");
        }

        }

    }
