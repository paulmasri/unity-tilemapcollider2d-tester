using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
	public float speed;

	Rigidbody2D rb;

	void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
    }
}
