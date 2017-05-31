using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;

namespace Assets.MicroGames.Peter_Runham3
{
    public class Goal : MonoBehaviour
    {
        private AudioSource audi;
        public AudioClip winSound;
        public AudioClip loseSound;
        public GameManager gm;
        // Use this for initialization
        void Start()
        {
            // Set random start position
            transform.position = new Vector3(Random.Range(-6, 6), Random.Range(-4, 4), 11);
            // Grab audio source
            audi = GetComponent<AudioSource>();
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                // Set as won
                gm.hasWon = true;
                // Play win sound
                audi.clip = winSound;
                audi.Play();
                // Set as won with global GM
                GlobalGameManager.gameWon = true;
            }
        }
    }
}