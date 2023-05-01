
    public class Character
    {
      public int Id { get; set; }  
      public string Name {get; set; } = string.Empty;
      public int Health { get; set; } = 100;
      bool IsAlive
      {
        get
        {
           // if health is greater than zero isAlive = true,
           //otherwise isAlive = false
           return Health > 0; 
        }
      }
    }
