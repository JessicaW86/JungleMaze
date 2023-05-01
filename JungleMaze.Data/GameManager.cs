
    public static class GameManager
    {
        //public static int MSomeProperty { get; set; }

        // dont use static all the time 
        public static void TellTheStory(string story)
        {
            System.Console.WriteLine(story);
        }
    }

    // GameManager gameManager = new GameManager();

    //b/c 'static' keyword is being used
    //GameManager.MethodWeNeedToUse
