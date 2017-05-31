using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;

namespace Assets.MicroGames.Peter_Runham
{
    public class BallBehavior : MonoBehaviour
    {
        //public PlayerMove playerMove;
        public ParticleSystem explosion;
        // Sounds
        public AudioSource audi;
        public AudioClip winSound;
        public AudioClip loseSound;
        // Use this for initialization
        void Start()
        {
            // Set initial win condition
            GlobalGameManager.gameWon = true;
            GlobalGameManager.ActivateSelectedScene();
            // Grab audiosource
            audi = GetComponent<AudioSource>();
        }

        void OnTriggerEnter(Collider col)
        {
            // Win
            if (col.tag == "Player")
            {
                // Play win sound
                audi.clip = winSound;
                audi.Play();
                // Grab rigidbody and stop movement
                Rigidbody rigid = GetComponent<Rigidbody>();
                rigid.isKinematic = true;
                // Instatiate explosion particles
                ParticleSystem explosionPrefab = Instantiate(explosion, transform.position, Quaternion.Euler(-180, 0, 0));
                Destroy(col.gameObject);
                // Set as won
                GlobalGameManager.gameWon = true;
            }
            // Lose
            if (col.tag == "Finish")
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