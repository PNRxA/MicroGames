using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;

namespace Assets.MicroGames.Peter_Runham2
{
    public class GameManager : MonoBehaviour
    {
        public bool hasPressed = false;
        // Use this for initialization
        void Start()
        {
            GlobalGameManager.verb = "Drop!";
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}