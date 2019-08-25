using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;

    public float speed = 20f;
    public Rigidbody2D rb;
    public float speedModifier = 5f;

    void Update()
    {
        if(!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            //col.GetComponent<Rotator>().speed += speedModifier;         //rotation speeds up for every pin that hits
            //col.GetComponent<Rotator>().speed *= -1;                    //rotation reverses for every pin that hits
            Score.pinCount++;
            isPinned = true;
        }
        else if(col.tag == "Pin")
        {
            FindObjectOfType<GameController>().EndGame();
        }
    }
}
