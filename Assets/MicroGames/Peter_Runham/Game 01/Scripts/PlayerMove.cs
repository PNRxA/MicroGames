using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.MicroGames.Peter_Runham
{
    public class PlayerMove : MonoBehaviour
    {
        public bool won = false;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Movement();
        }

        void Movement()
        {
            if (!won)
            {
                int stirlingsPatience = 2;
                Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal") * stirlingsPatience, 0, 0);
                transform.Translate(move);
            }
        }
    }
}