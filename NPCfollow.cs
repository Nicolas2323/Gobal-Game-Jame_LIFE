using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCfollow : MonoBehaviour
{
    public float speed = 1f;
    public float stoppingDistance = 2f;
    public GameObject player;
    public GameObject npc;
    private Rigidbody2D target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").GetComponent<Rigidbody2D>();

    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log(target.position.x);
        //if (Vector2.Distance(transform.position, target.position) > stoppingDistance)
        // transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        float a = Mathf.Abs(transform.position.x - target.position.x);
        float b = Mathf.Abs(transform.position.y - target.position.y);
        float distance = Mathf.Sqrt(a * a + b * b);
        if (distance > 1)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, 0.05f);
        }
    }
}