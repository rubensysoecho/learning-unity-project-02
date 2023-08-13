using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 10f;
    public float width = 1f;

    public GameObject projectilePrefab;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.x < -width)
        {
            transform.position = new Vector3(-width, transform.position.y, transform.position.z);
        }
        if (transform.position.x > width)
        {
            transform.position = new Vector3(width, transform.position.y, transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
