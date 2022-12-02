using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PauseTela;

public class Player : MonoBehaviour
{
        public Animator Anim;
        public float speed;
        public static float fixedDeltaTime;
        private bool EstaPausado;

        // Update is called once per frame
        void FixedUpdate()
        {
                if (!EstaPausado)
                {
                        movePlayer();
                }
        }


        void movePlayer(){
                Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
                Anim.SetFloat("Horizontal", movement.x);
                Anim.SetFloat("Vertical", movement.y);
                Anim.SetFloat("Speed", movement.magnitude);

                transform.position = transform.position + movement * speed * Time.fixedDeltaTime;
        }

}


