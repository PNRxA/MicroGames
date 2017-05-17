using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.MicroGames.Peter_Runham
{
    public class PlayerMove : MonoBehaviour
    {
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
            int stirlingsPatience = 50;
            Vector3 move = new Vector3(Input.GetAxis("Horizontal") / stirlingsPatience, Input.GetAxis("Vertical") / stirlingsPatience, 0);
            transform.Translate(move);
        }
    }
}