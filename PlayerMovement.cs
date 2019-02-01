using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private Animator anim;
    private bool ismoving;
    private Vector2 lastmove;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float Axisx = Input.GetAxisRaw("Horizontal");


        float Axisy = Input.GetAxisRaw("Vertical");

        ismoving = false;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            moveSpeed = 1f;

            transform.Translate(new Vector3(Axisx * moveSpeed * Time.deltaTime, 0f));
            ismoving = true;
            lastmove = new Vector2(Axisx, 0f);
        }
        else
        if (Axisx > 0.5f || Axisx < -0.5f)

            moveSpeed = 0.5f;
        transform.Translate(new Vector3(Axisx * moveSpeed * Time.deltaTime, 0f));
        ismoving = true;
        lastmove = new Vector2(Axisx, 0f);



        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            moveSpeed = 1f;

            transform.Translate(new Vector3(0f, Axisy * moveSpeed * Time.deltaTime));
            ismoving = true;
            lastmove = new Vector2(0f, Axisy);
        }
        else
        if (Axisy > 0.5f || Axisy < -0.5f)
        {
            moveSpeed = 0.5f;
            transform.Translate(new Vector3(0f, Axisy * moveSpeed * Time.deltaTime));
            ismoving = true;
            lastmove = new Vector2(0f, Axisy);
        }

        anim.SetFloat("MoveX", Axisx);
        anim.SetFloat("MoveY", Axisy);
        anim.SetFloat("LastMoveX", lastmove.x);
        anim.SetFloat("LastMoveY", lastmove.y);
        anim.SetBool("IsMoving", ismoving);

    }
}
