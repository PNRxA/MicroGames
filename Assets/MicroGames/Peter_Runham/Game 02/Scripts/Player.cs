using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;

namespace Assets.MicroGames.Peter_Runham2
{
    public class Player : MonoBehaviour
    {
        public AudioClip winSound;
        public AudioClip loseSound;
        public GameManager gm;
        private AudioSource audi;
        private Rigidbody rigi;
        // Use this for initialization
        void Start()
        {
            // Set inital game win status
            GlobalGameManager.gameWon = false;
            // Grab rigidbody and audio source
            rigi = GetComponent<Rigidbody>();
            audi = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            // Controller for the game
            Drop();
        }

        void Drop()
        {
            // If pressing Fire1, drop the ball 
            if (Input.GetButton("Fire1"))
            {
                // Tell gm that Fire has been pressed
                gm.hasPressed = true;
                // Allow ball to fall
                rigi.isKinematic = false;
            }
        }

        void OnTriggerEnter(Collider other)
        {
            // Win
            if (other.tag == "Goal")
            {
                // Stop movement
                rigi.isKinematic = true;
                // Play winning sounds
                audi.clip = winSound;
                audi.Play();
                // Set as won
                GlobalGameManager.gameWon = true;
            }
            // Lost
            if (other.tag == "Finish")
            {
                // Play loss sound
                audi.clip = loseSound;
                audi.Play();
                // Set as loss
                GlobalGameManager.gameWon = false;
            }
        }
    }
}