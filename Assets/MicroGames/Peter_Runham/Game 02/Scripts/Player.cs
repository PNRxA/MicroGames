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
            GlobalGameManager.gameWon = false;
            rigi = GetComponent<Rigidbody>();
            audi = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            Drop();
        }

        void Drop()
        {
            if (Input.GetButton("Fire1"))
            {
                gm.hasPressed = true;
                rigi.isKinematic = false;
            }
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.tag == "Goal")
            {
                rigi.isKinematic = true;
                audi.clip = winSound;
                audi.Play();
                GlobalGameManager.gameWon = true;
            }
            if (other.tag == "Finish")
            {
                audi.clip = loseSound;
                audi.Play();
                GlobalGameManager.gameWon = false;
            }
        }
    }
}