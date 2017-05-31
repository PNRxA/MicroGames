using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;

namespace Assets.MicroGames.Peter_Runham3
{
    public class GameManager : MonoBehaviour
    {
        public bool hasWon;
        // Use this for initialization
        void Start()
        {
            GlobalGameManager.gameWon = false;
            GlobalGameManager.verb = "Seek!";
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}