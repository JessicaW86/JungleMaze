
    public class CharacterRepository
    {
        public CharacterRepository()
        {
            Seed();
        }
        //just a collection of characters
        //we want to preform actions/methods on collection
        //in real life they are called "database"
        private List<Character> _characterDb = new List<Character>();
        //simulate how db works
        //need unique Identifyer (dynamically)
        private int _count = 0;
        //C.R.U.D.
        //Create
        public bool AddCharacter(Character character)
        {
            //def coding
            if(character is null)
            {
                return false;
            }
            else
            {
                //increment the counter
                _count++;
                //assign the value of _count to character.Id
                character.Id = _count;
                _characterDb.Add(character);
                //return true, so the user can kknow it worked
                return true;
            }
        }
        //Read All
        public List<Character> GetCharacters()
        {
            return _characterDb;
        }

        //Read by ID
        public Character GetCharacter(int characterId)
        {
            //Lookup through the db
            foreach (Character character in _characterDb)
            {
                if(character.Id == characterId)
                {
                    //return the character data.
                    return character;
                }
            }
                //otherwise return "nothing"
                return null;
        }
       //Check
       public bool HasDied(Character character)
       {
        if(character.Health <= 0)
        {
            System.Console.WriteLine($"{character.Name} HasDied Died!"); //$"{}"
            return true;
        }
        return false;
       }
       public void Seed()
    {
        Player player1 = new Player("BillyBob", new List<InGameItem>
        {
            new InGameItem
            {
                Id = 1,
                Name = "Banana"
            },
            new InGameItem
            {
                Id =2,
                Name = "Vines"
            },
            new InGameItem
            {
                Id = 3,
                Name ="Knife"
            }
        });
 Character monkey = new Character();
   monkey.Name = "Monkey"; 
    Character wildBoar = new Character();
wildBoar.Name = "Wild Boar";

    Character croc = new Character();
    croc.Name = "Croc";

//add this to database
AddCharacter(player1);
AddCharacter(monkey);
AddCharacter(wildBoar);
AddCharacter(croc);

    }

       }
    
