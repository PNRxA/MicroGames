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
            transform.position = new Vector3(Random.Range(-6, 6), Random.Range(-4, 4), 11);
        }

        // Update is called once per frame
        void Update()
        {
            if (!gm.hasWon)
            {
                Movement();
            }
        }

        void Movement()
        {
            Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
            transform.position += move;
        }
    }
}