using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;


namespace Assets.MicroGames.Peter_Runham
{
    public class PlayerMove : MonoBehaviour
    {
        //public bool won = false;
        public GameObject ball;
        public Transform startPos;
        public ParticleSystem explosionPrefab;
        private bool ballSpawned = false;

        // Use this for initialization
        void Start()
        {
            GlobalGameManager.ActivateSelectedScene();
        }

        // Update is called once per frame
        void Update()
        {
            if (GlobalGameManager.gameActive)
            {
                Movement();
            }

            if (GlobalGameManager.gameActive && !ballSpawned)
            {
                ballSpawned = true;
                GameObject ballToDrop = Instantiate(ball, startPos);
                ballToDrop.GetComponent<BallBehavior>().explosion = explosionPrefab;
            }
        }

        void Movement()
        {
            //if (!won)
            //{
            int stirlingsPatience = 7;
            Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal") * stirlingsPatience, 0, 0);
            transform.Translate(move);
            //}
        }
    }
}