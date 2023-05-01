
    public class Level
    {
        public Level()
        {
            
        }

        public Level(Player player)
        {
            Player = player;
        }
        public int Id { get; set; }
        public Player Player { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<Scenario> Scenario { get; set; } = new List<Scenario>();
    }
