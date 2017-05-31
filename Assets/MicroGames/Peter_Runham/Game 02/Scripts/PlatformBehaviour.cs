using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StirlingMulvey;

namespace Assets.MicroGames.Peter_Runham2
{
    public class PlatformBehaviour : MonoBehaviour
    {
        private float speed = .5f;
        private Vector3 pos1;
        private Vector3 pos2;

        public GameManager gm;
        // Use this for initialization
        void Start()
        {
            // Set positions to lerp between
            pos1 = new Vector3(-6, transform.position.y, transform.position.z);
            pos2 = new Vector3(6, transform.position.y, transform.position.z);
        }

        // Update is called once per frame
        void Update()
        {
            // If the button hasn't been pressed, allow movement
            if (!gm.hasPressed)
            {
                Movement();
            }
        }

        void Movement()
        {
            // Move between positions defined above
            transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
        }
    }
}