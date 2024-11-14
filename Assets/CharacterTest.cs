using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class CharacterTest : MonoBehaviour
    {
        void Start()
        {
            Officer officer = new Officer("Commander", 80, new Position(5, 10, 0));

            Soldier soldier = new Soldier();

            Character[] characters = { officer, soldier };

            foreach (Character character in characters)
            {
                character.DisplayInfo();
            }

            Debug.Log($"Soldier's Health before attack: {soldier.Health}");

            officer.Attack(20, soldier, "shooting");

            Debug.Log($"Soldier's Health after attack: {soldier.Health}");
        }
    }
}