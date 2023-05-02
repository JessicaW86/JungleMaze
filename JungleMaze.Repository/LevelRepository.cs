
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
                        ScenarioText = $"Ooh a rock, let's inspect {_cRepo.GetCharacter(1).Name} darn its nothing lets find another way!"
                    },
                        new Scenario
                    {
                        Id = 2,
                        ScenarioDirection = Direction.Down,
                        ScenarioText = $"There's a vine. You found another vine, cut it {_cRepo.GetCharacter(1).Name} tie them together around your waist it will come in handy later!"
                    },
                        new Scenario
                    {
                        Id = 3,
                        ScenarioDirection = Direction.Left,
                        ScenarioText = $"Dead end, {_cRepo.GetCharacter(1).Name} go back."
                    },
                        new Scenario
                    {
                        Id = 4,
                        ScenarioDirection = Direction.Right,
                        ScenarioText = $"Oh no a big hole {_cRepo.GetCharacter(1).Name} go back!"
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
                        ScenarioText = $"Grab monkey's hand to avoid quicksand, yay {_cRepo.GetCharacter(1).Name} he saved you, Thanks Mr, Monkey!" //_cRepo.GetCharacter(1).Name = player
                    },
                        new Scenario
                    {
                        Id = 6,
                        ScenarioDirection = Direction.Down,
                        ScenarioText = $"Oh no more quicksand {_cRepo.GetCharacter(1).Name} its too late, you are sinking!"
                    },
                        new Scenario
                    {
                        Id = 7,
                        ScenarioDirection = Direction.Left,
                        ScenarioText = $"You've hit a rockwall, {_cRepo.GetCharacter(1).Name} there's no way out."
                    },
                        new Scenario
                    {
                        Id = 8,
                        ScenarioDirection = Direction.Right,
                        ScenarioText = $"Quicksand, you'll sink if you keep going {_cRepo.GetCharacter(1).Name} turn around"
                    }
                }
            };
              Level lv3 = new Level()
            {
                Title = "Welcome to lvl-3",
                Scenario = new List<Scenario>
                {
                    new Scenario
                    {
                        Id = 9,
                        ScenarioDirection = Direction.Up,
                        ScenarioText = $"Monkey Pit, fight or run {_cRepo.GetCharacter(1).Name} oh no monkeys got you!" //_cRepo.GetCharacter(1).Name = player
                    },
                        new Scenario
                    {
                        Id = 10,
                        ScenarioDirection = Direction.Down,
                        ScenarioText = $"Two Monkeys! {_cRepo.GetCharacter(1).Name} grab bananas on the ground and throw, two more monkeys time to use your knife!"
                    },
                        new Scenario
                    {
                        Id = 11,
                        ScenarioDirection = Direction.Left,
                        ScenarioText = $"Wild boar, {_cRepo.GetCharacter(1).Name} use vine on waist as rope to swing across. Oh no the vines break."
                    },
                        new Scenario
                    {
                        Id = 12,
                        ScenarioDirection = Direction.Right,
                        ScenarioText = $"chomp {_cRepo.GetCharacter(1).Name} eaten by a croc"
                    }
                }
            };

            AddLevel(lv1); // lv = level
            AddLevel(lv2);
            AddLevel(lv3);

        }

    }
