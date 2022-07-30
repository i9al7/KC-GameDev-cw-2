using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2 : MonoBehaviour
{
    //hero
    string heroName = "9al7";
    int heroHeight = 170;
    int heroAge = 17;
    bool heroSuperPower = false;
    //villain
    string villainName = "n9our";
    int vililanHeight = 170;
    int villainAge = 19;
    bool villainSuperPower = false;


    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = villainAge - heroAge;
        print("The hero name " + heroName + " and its height " + heroHeight + " and age " + heroAge + " and Super Power " + heroSuperPower);
        print("The villain name " + villainName + " and its height " + vililanHeight + " and age " + villainAge + " and Super Power " + villainSuperPower);
        print("The age difference between the hero and villain " + ageDifference);
    }

    // Update is called once per frame
    void Update()
    {

    }
}