using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;

namespace Assets.MicroGames.Peter_Runham3
{
    public class Player : MonoBehaviour
    {
        public GameManager gm;
        // Use this for initialization
        void Start()
        {
            // Set random start position
            transform.position = new Vector3(Random.Range(-6, 6), Random.Range(-4, 4), 11);
        }

        // Update is called once per frame
        void Update()
        {
            // If you haven't won, allow movement
            if (!gm.hasWon)
            {
                Movement();
            }
        }

        void Movement()
        {
            // Move based on horizontal and vertical movement
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.position += move;
        }
    }
}