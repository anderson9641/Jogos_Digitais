using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 dir;
    private Rigidbody rb;

    [SerializeField] private float rY;
    [SerializeField] private float rX;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;        
    }

    // Update is called once per frame
    void Update()
    {
        dir = player.TransformVector(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized);

        rX = Mathf.Lerp(rX, Input.GetAxis("Mouse X") * 2, 100 * Time.deltaTime);
        rY = Mathf.Clamp(rY - Input.GetAxis("Mouse Y")* 2 * 100 * Time.deltaTime, -30, 30);

        player.Rotate(0, rX, 0, Space.World);

    }

    private void FixedUpdate()
    {
        //rb.MovePosition(rb.position + dir * 10 * Time.fixedDeltaTime);
        rb.velocity = dir * 10;
    }
}