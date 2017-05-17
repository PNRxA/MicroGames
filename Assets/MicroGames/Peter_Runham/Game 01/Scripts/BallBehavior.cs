using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.MicroGames.Peter_Runham
{
    public class BallBehavior : MonoBehaviour
    {
        public PlayerMove playerMove;
        public ParticleSystem explosion;
        // Use this for initialization
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider col)
        {
            if (col.tag == "Player")
            {
                Rigidbody rigid = GetComponent<Rigidbody>();
                rigid.isKinematic = true;
                ParticleSystem explosionPrefab = Instantiate(explosion, transform.position, Quaternion.Euler(-180, 0, 0));
                Destroy(col.gameObject);
                YouWin();
            }
            if (col.tag == "Finish")
            {
                YouLose();
            }
        }

        void YouWin()
        {
            playerMove.won = true;
        }

        void YouLose()
        {
           
        }
    }
}