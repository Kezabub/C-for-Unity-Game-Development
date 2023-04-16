using System.Collections;
using System.Collections.Generic;
using MyGame;
using UnityEngine;

//testing basic C# code for Unity will be commenting stuff out once im done test it.
public class HelloWorld : MonoBehaviour
{
    public string text = "Hello World";
    public bool turnOn = true;
    public float posX = 5.0f;
    public int intTest = 5;
    //string[] names = new string[5]
    string[] names = new string[]{"Kez", "Fish"};
    List<string> animals = new List<string>(){"dog", "cat"};
    Dictionary<string, string> weapons = new Dictionary<string, string>();

    // Start is called before the first frame update
    void Start()
    {
        IHealth cc = new Player();

        print(cc.health +"/"+ cc.maxHealth);

        print("Health "+ cc.CurrentHealthPercent()+ "%");
        //text = "Updated during Start()";
        //Test();

        //text = Test("Calling Test() "); 

        //print("Hello World " + posX);
        //names[0] = "Kez";

        //print("First Name " + names[0]);
        // print(names[0]+" "+names[1]);
        // print("Total Names "+names.Length);

        animals.Add("fish");
        animals.Add("bird");
        animals.Remove("bird");

        // print("Total Animals "+ animals.Count);
        // print("Animal 1 "+ animals[0]);
        // print("Last Animal "+ animals[animals.Count-1]);

        // print("List to Array length "+ animals.ToArray().Length);

        weapons.Add("slot1", "sword");
        weapons.Add("slot2", "dagger");
        
        // print("Weapon in slot 1 "+ weapons["slot1"]);
        // print("Slot 2 equipped "+ weapons.ContainsKey("slot2"));

        //ConditionTest();

        LoopTest();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //void Test()
    //{
        //text = "Updated during Test()";
    //}
    
    string Test(string value)
    {
        return value + "Updated during Test()";
    }

    void ConditionTest()
    {
        //string name = "Kez";
        string name = "Fish";

        if(name == "Kez")
        {
            print("Name is Kez");
        }
        else if(name == "Fish")
        {
            print("Name is Fish");
        }
        else
        {
            print("Name is not Kez or Fish");
        }

        //int health = 5;
        int health = 0;

        bool isDead = health <= 0;

        print("isDead " + isDead);

        if (isDead)
            print("Player is dead");

        //print ("Did this work");
        string mode = isDead == true ? "GameOver" : "IsPlaying";
        print(mode);
    }

    void LoopTest()
    {
        for(int i = 0; i < 10; i ++)
        {
            print("Loop "+ i);
        }

        for(int i = 9; i > -1; i --)
        {
            print("Loop "+ i);
        }

        for(int i = 0; i < names.Length; i++)
        {
            print("Name "+ i+ " "+ names[i]);
        }

        foreach(string name in animals)
        {
            print(name);
        }

        foreach(var item in weapons)
        {
            print(item.Key +" "+ item.Value);
        }
    }
}
