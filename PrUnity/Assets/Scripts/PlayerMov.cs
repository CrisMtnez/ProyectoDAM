using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public Rigidbody kip;
    public bool saltando = false;
    public bool alive = true;
    public float yPos = 0.25f;
    public Animator anim;

    void Start()
    {       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameManager.PLAYING)
        {
            if (kip.position.y < -1)
            {
                alive = false;
                FindObjectOfType<GameManager>().GameOver();
            }
            if (alive)
            {
                //usamos ifs porque con case no funciona

                if (Input.GetKey(KeyCode.Space) && kip.position.y <= yPos)
                    saltando = true;
                if (saltando && kip.position.y <= yPos + 0.7f)
                {
                    FindObjectOfType<GameManager>().JumpSound();
                    GameManager.jumpSoundPlayed = true;
                    kip.AddForce(0, 20 * Time.deltaTime, 0, ForceMode.VelocityChange);
                }
                else
                {
                    saltando = false;
                    GameManager.jumpSoundPlayed = false;
                }                    

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    kip.transform.rotation = new Quaternion(0, 1.2f, kip.transform.rotation.z, kip.transform.rotation.w);
                    kip.AddForce(0, 0, -10 * Time.deltaTime, ForceMode.VelocityChange);
                    //Debug.Log("rot: " + kip.transform.localRotation.ToString());
                }

                if (Input.GetKey(KeyCode.UpArrow))
                {
                    kip.transform.rotation = new Quaternion(0, 0, kip.transform.rotation.z, kip.transform.rotation.w);
                    kip.AddForce(0, 0, 10 * Time.deltaTime, ForceMode.VelocityChange);
                    //Debug.Log("rot: " + kip.transform.localRotation.ToString());
                }

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    kip.transform.rotation = new Quaternion(0, -0.7f, kip.transform.rotation.z, transform.rotation.w);
                    kip.AddForce(-10 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                    //Debug.Log("rot: " + kip.transform.localRotation.ToString());
                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    kip.transform.rotation = new Quaternion(0, 0.7f, kip.transform.rotation.z, transform.rotation.w);
                    kip.AddForce(10 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                    //Debug.Log("rot: " + kip.transform.localRotation.ToString());
                }
            }
            else
            {
                anim.runtimeAnimatorController = null;
            }
        }
    }
}


/*
            if (Input.GetKey(KeyCode.DownArrow))
                kip.AddForce(0, 0, -20 * Time.deltaTime, ForceMode.VelocityChange);
            if (Input.GetKey(KeyCode.UpArrow))
                kip.AddForce(0, 0, 20 * Time.deltaTime, ForceMode.VelocityChange);
            if (Input.GetKey(KeyCode.LeftArrow))
                kip.AddForce(-20 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            if (Input.GetKey(KeyCode.RightArrow))
                kip.AddForce(20 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            if (Input.GetKey(KeyCode.Space) && kip.position.y <= y)
            {
                saltando = true;
            }
            if (saltando && kip.position.y <= 0.5)
                kip.AddForce(0, 20 * Time.deltaTime, 0, ForceMode.VelocityChange);
            else
                saltando = false;
                
             //private float flow = 0.02f;
            //float z = kip.transform.position.x % 2 == 0 ? 10:-10;
            //bamboleo = !bamboleo; en x: bamboleo?flow:-flow


    private bool bamboleo = true;
    public Animator animator;
    int flyHash = Animator.StringToHash("fly");
    int pokHash = Animator.StringToHash("pok");
    int cheerHash = Animator.StringToHash("cheer");
    int walkHash = Animator.StringToHash("walk");

     animator = GetComponent<Animator>();

     float move = Input.GetAxis("Vertical");
            animator.SetFloat("Speed", move);

            AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetTrigger(flyHash);
            }

*/
