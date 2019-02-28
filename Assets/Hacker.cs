using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game state
    int level;
    enum Screen{MainMenu, Password, Win};
    Screen currentScreen;

    // Start is called before the first frame update
    void Start() {
        ShowMainMenu();
    }

    void ShowMainMenu() {

        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Aw man, it seems some motherfucker stole your joint and hid it somewhere.");
        Terminal.WriteLine("What's the MOFO's name?");
        Terminal.WriteLine("Shrek (Easy)");
        Terminal.WriteLine("Kony (Medium)");
        Terminal.WriteLine("Ronald (Hard)");
        Terminal.WriteLine("Type the name:");
    }

    void OnUserInput(string input){
        if (input == "menu"){
            currentScreen = Screen.MainMenu;
            ShowMainMenu();
        }

        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        
    }

    void RunMainMenu(string input)
    {
        if (input == "1337")
        {
            Terminal.WriteLine("vv311 /-/3110 +/-/3R3 Mr 5m4r+y /)4n+5!");
        }

        else if (input == "Shrek" || input == "shrek")
        {
            level = 1;
            StartGame();
        }

        else if (input == "kony" || input == "Kony")
        {
            level = 2;

            StartGame();
        }

        else if (input == "ronald" || input == "Ronald")
        {
            level = 3;
            StartGame();
        }

        else
        {
            Terminal.WriteLine("That's not a valid level, homs!");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        
        if(level == 1)
        {
            Terminal.WriteLine("So that shady ass motherfucker's name's Shrek, so he must be lurking in the:");
            Terminal.WriteLine("(Hint: PSWMA)");
            Terminal.WriteLine("Enter Password: ");
        }

        if (level == 2)
        {
            Terminal.WriteLine("Kony? Dayum, dawg. That's some serious shit. We should ask the:");
            Terminal.WriteLine("(Hint: YMNOEK)");
            Terminal.WriteLine("Enter Password: ");
        }

        if (level == 3)
        {
            Terminal.WriteLine("Ronald McDonald, the real OG. We should look for him in his:");
            Terminal.WriteLine("(Hint: TRATNSRUEA)");
            Terminal.WriteLine("Enter Password: ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
