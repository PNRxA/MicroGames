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
            // Set verb
            GlobalGameManager.verb = "STOP!";
            GlobalGameManager.ActivateSelectedScene();
        }

        // Update is called once per frame
        void Update()
        {
            // If the game is active allow movement
            if (GlobalGameManager.gameActive)
            {
                Movement();
            }
            // If teh game is active and the ball hasn't spawned, spawn the ball
            if (GlobalGameManager.gameActive && !ballSpawned)
            {
                // Spawn ball
                ballSpawned = true;
                GameObject ballToDrop = Instantiate(ball, startPos);
                // Set explosion prefab
                ballToDrop.GetComponent<BallBehavior>().explosion = explosionPrefab;
            }
        }

        void Movement()
        {
            // Move based on stirlings patience and also horizontal/vertical axis
            int stirlingsPatience = 7;
            Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal") * stirlingsPatience, 0, 0);
            transform.Translate(move);
        }
    }
}