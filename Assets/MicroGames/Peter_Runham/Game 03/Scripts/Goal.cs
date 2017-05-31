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
            transform.position = new Vector3(Random.Range(-6, 6), Random.Range(-4, 4), 11);
            audi = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Player")
            {
                gm.hasWon = true;
                audi.clip = winSound;
                audi.Play();
                GlobalGameManager.gameWon = true;
            }
        }
    }
}