using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game Data
    string[] Level1Passwords = {"swamp", "sewer", "gate", "lamp", "donkey"};
    string[] Level2Passwords = {"soldier", "monster", "turtle", "helmet", "ak47"};
    string[] Level3Passwords = {"hamburger", "french fries", "corruption", "rat meat", "restaurant" };

    string[] Level1Messages = {"So that shady ass motherfucker's name's Shrek. He must be lurking in the:",
                                "message1",
                                "message2",
                                "message3",
                                "message4"
                            };
    string[] Level2Messages = {"Kony? Dayum, dawg. That's some serious shit. We should ask that:",
                                "message1",
                                "message2",
                                "message3",
                                "message4"
                            };
    string[] Level3Messages = {"message0",
                                "message1",
                                "message2",
                                "message3",
                                "Ronald McDonald, the real OG. We should look for him in his:"
                            };

    string[] Level1Hints = {"(Hint: PSWMA)",
                                "hint1",
                                "hint2",
                                "hint3",
                                "hint4"
                            };
    string[] Level2Hints = {"(Hint: DREIOLS)",
                                "hint1",
                                "hint2",
                                "hint3",
                                "hint4"
                            };
    string[] Level3Hints = {"hint0",
                                "hint1",
                                "hint2",
                                "hint3",
                                "(Hint: TRATNSRUEA)"
                            };

                            
    //Game state
    string level;
    enum Screen{MainMenu, Password, Win};
    Screen currentScreen;
    string password;

    // Start is called before the first frame update
    void Start() {
        ShowMainMenu();
    }

    void ShowMainMenu() {

        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("Aw man, some motherfucker made himself with your beloved Shaniqwanda!");
        Terminal.WriteLine("We have to go get'im!");
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

        else if(currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
        
    }

    void CheckPassword(string input)
    {
        if (level == "shrek")
        {
            if (input == password)
            {
                ShowWinScreen("Yeah, dawg! He's in the swamp!");
            }

            else Terminal.WriteLine("Shit man, no! Try again.");
        }

        if (level == "kony")
        {
            if (input == password)
            {
                ShowWinScreen("Fo sho, let's ask that soldier o'er there!");
            }

            else Terminal.WriteLine("Shit man, no! Try again.");
        }

        if (level == "ronald")
        {
            if (input == password)
            {
                ShowWinScreen("Awww yeah! Imma get a big mac while we're there!");
            }

            else Terminal.WriteLine("Shit man, no! Try again.");
        }
    }

    void ShowWinScreen(string message)
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        Terminal.WriteLine(message);
    }

    void RunMainMenu(string input)
    {
        bool isValidLevel = (input == "shrek" || input == "kony" || input == "ronald");

        if (isValidLevel)
        {
            level = input;
            StartGame();
        }

        else if (input == "1337")
        {
            Terminal.WriteLine("vv311 /-/3110 +/-/3R3 Mr 5m4r+y /)4n+5!");
        }

        else
        {
            Terminal.WriteLine("That's not a valid level, homs!");
        }
    }

    void StartGame()
    {
        string hint = "Hint",
               message = "message";
        int index = 0;
        currentScreen = Screen.Password;
        Terminal.ClearScreen();

        switch (level)
        {
            case "shrek":
                index = Random.Range(0, Level1Passwords.Length);
                hint = Level1Hints[index];
                message = Level1Messages[index];
                password = Level1Passwords[index];
                break;

            case "kony":
                index = Random.Range(0, Level2Passwords.Length);
                hint = Level2Hints[index];
                message = Level2Messages[index];
                password = Level2Passwords[index];
                break;

            case "ronald":
                index = Random.Range(0, Level3Passwords.Length);
                hint = Level3Hints[index];
                message = Level3Messages[index];
                password = Level3Passwords[index];
                break;

            default:
                Debug.LogError("Not valid");
                break;
        }
        
            Terminal.WriteLine(message);
            Terminal.WriteLine(hint);
            Terminal.WriteLine("Enter your answer: ");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
