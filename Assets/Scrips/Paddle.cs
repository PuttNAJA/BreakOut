using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;

    private float move;
    private Animator anim;
    private Rigidbody RB;
    private bool OnFloor = true;

    //private float ChangeRotate;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxisRaw("Horizontal");
        //Animation();
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = Vector2.right * move * speed;
    }

    void Animation()
    {
        if (Input.GetKeyDown(KeyCode.Space) && OnFloor)
        {
            anim.SetTrigger("Jump");
            RB.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            OnFloor= false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            OnFloor = true;
        }
    }
}
