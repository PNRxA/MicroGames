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
            GlobalGameManager.gameWon = true;
            GlobalGameManager.ActivateSelectedScene();
            audi = GetComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider col)
        {
            if (col.tag == "Player")
            {
                audi.clip = winSound;
                audi.Play();
                Rigidbody rigid = GetComponent<Rigidbody>();
                rigid.isKinematic = true;
                ParticleSystem explosionPrefab = Instantiate(explosion, transform.position, Quaternion.Euler(-180, 0, 0));
                Destroy(col.gameObject);
                GlobalGameManager.gameWon = true;
            }
            if (col.tag == "Finish")
            {
                audi.clip = loseSound;
                audi.Play();
                GlobalGameManager.gameWon = false;
            }
        }
    }
}