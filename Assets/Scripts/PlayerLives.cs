using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    void Start()
    {
        Character hero = new Character("Agatha");
        hero.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        huntingBow.PrintWeaponStats();

        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;
        warBow.PrintWeaponStats();

        Paladin knight = new Paladin("Sir Arthur", huntingBow);
        knight.PrintStatsInfo();

        int playerLives = 3;

        while (playerLives > 0)
        {
            Debug.Log("Still alive!");
            playerLives--;
        }
        Debug.Log("Player KO'd...");
    }

    void Update()
    {
        
    }
}
