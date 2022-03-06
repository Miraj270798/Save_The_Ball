using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
	Rigidbody2D rb;
	public float movespeed;

	private void Awake()
	{
		rb = GetComponent<Rigidbody2D>();
	}
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void FixedUpdate()
	{
		TouchMove();
	}

	void TouchMove()
	{
		if (Input.GetMouseButton(0))
		{
			Vector2 touchpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			if(touchpos.x < 0)
			{
				//Move Left
				rb.velocity = Vector2.left * movespeed;
			}
			else
			{
				//Move Right
				rb.velocity = Vector2.right * movespeed;
			}
		}
		else
		{
			rb.velocity = Vector2.zero;
		}
	}
}
