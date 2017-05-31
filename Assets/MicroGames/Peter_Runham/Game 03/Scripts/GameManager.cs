using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;

namespace Assets.MicroGames.Peter_Runham3
{
    public class GameManager : MonoBehaviour
    {
        // Bool to determine whether to allow input
        public bool hasWon;
        // Use this for initialization
        void Start()
        {
            // Set initial win condition to false
            GlobalGameManager.gameWon = false;
            // Set the verb to seek
            GlobalGameManager.verb = "Seek!";
        }
    }
}