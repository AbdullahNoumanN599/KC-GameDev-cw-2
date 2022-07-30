using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIsKey : MonoBehaviour
{
    // Start is called before the first frame update
    string heroname = "jhonathon sins";
    int heroheight = 100;
    int heroage = 69;
    string herosuperpower = "he can say worcestershire sauce 10 times rapidly";
    string villianname = "ben shortpiro";
    int villianheight = 5;
    int villianage = 79;
    string villiansuperpower = "he can do simple addition with his toes";

    void Start()
    {
        int Agediffrence = villianage - heroage;
        print("the hero's name is" + heroname);
        print("he is" + heroage + "years old and his power is that" + herosuperpower);
        print("his archnemisis" + villianname + "he is a twisted individual born" + villianage + "ago. and he uses his twisted power the abillity to" + villiansuperpower + "to not tip the waiter");
        print("however our hero" + heroname + "has the advantage of age. the advantage of being" + Agediffrence + "years younger");

    }

    // Update is called once per frame
    void Update()
    {
   

    }
}
