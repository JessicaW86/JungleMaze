
    public class LevelRepository
    {
        public LevelRepository()
        {
            Seed();
        }
       private CharacterRepository _cRepo = new CharacterRepository();
        private List<Level> _levelDb = new List<Level>();
        private int _count = 0;

        //C.R.U.D

        public bool AddLevel(Level level)
        {
            if(level is null)
            {
                return false;
                
            }
            else
            {
                _count++;
                level.Id = _count;
                _levelDb.Add(level);
                return true;
            }
        }

        public List<Level> GetLevels()
        {
            return _levelDb;
        }

        public Level GetLevel(int levelId)
        {
            //loop
            foreach (Level l in _levelDb)
            {
                if (l.Id == levelId)
                {
                    return l;
                }
            }
             return null;
        }

        private void Seed()
        {
            Level lv1 = new Level()
            {
                Title = "Welcome to lvl-1",
                Scenario = new List<Scenario>
                {
                    new Scenario
                    {
                        Id = 1,
                        ScenarioDirection = Direction.Up,
                        ScenarioText = $"Ouch! {_cRepo.GetCharacter(1).Name} Fell while climbing a vine!"
                    },
                        new Scenario
                    {
                        Id = 2,
                        ScenarioDirection = Direction.Down,
                        ScenarioText = $"Wow! {_cRepo.GetCharacter(1).Name} Noticed a bed of nails while climbing!"
                    },
                        new Scenario
                    {
                        Id = 3,
                        ScenarioDirection = Direction.Left,
                        ScenarioText = $"Ok, {_cRepo.GetCharacter(1).Name} has found something interesting, lets investigate."
                    },
                        new Scenario
                    {
                        Id = 4,
                        ScenarioDirection = Direction.Right,
                        ScenarioText = $"Umm {_cRepo.GetCharacter(1).Name} has ran into a dead end"
                    }
                }
            };

                Level lv2 = new Level()
            {
                Title = "Welcome to lvl-2",
                Scenario = new List<Scenario>
                {
                    new Scenario
                    {
                        Id = 5,
                        ScenarioDirection = Direction.Up,
                        ScenarioText = $"! {_cRepo.GetCharacter(1).Name} climbing a vine!" //_cRepo.GetCharacter(1).Name = player
                    },
                        new Scenario
                    {
                        Id = 6,
                        ScenarioDirection = Direction.Down,
                        ScenarioText = $"Wow! {_cRepo.GetCharacter(1).Name} climbing down notice treasure!"
                    },
                        new Scenario
                    {
                        Id = 7,
                        ScenarioDirection = Direction.Left,
                        ScenarioText = $"Ok, {_cRepo.GetCharacter(1).Name} nothing here but the scenary is nice."
                    },
                        new Scenario
                    {
                        Id = 8,
                        ScenarioDirection = Direction.Right,
                        ScenarioText = $"Umm.... {_cRepo.GetCharacter(1).Name} has ran into a dead end"
                    }
                }
            };

            AddLevel(lv1); // lv = level
            AddLevel(lv2);

        }

    }
