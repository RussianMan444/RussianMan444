using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed;
    public Transform capsule;
    public bool IsInCar;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(num());
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public IEnumerator num()
    {
       
        yield return new WaitForSeconds(0.25f);
        if (IsInCar == false)
        {
            if (Input.GetKey(KeyCode.W))
            {
                capsule.position += new Vector3(transform.forward.x * moveSpeed, 0, transform.forward.z * moveSpeed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                capsule.position -= new Vector3(transform.forward.x * moveSpeed, 0, transform.forward.z * moveSpeed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                capsule.position -= transform.right * moveSpeed;
            }
            if (Input.GetKey(KeyCode.D))
            {
                capsule.position += transform.right * moveSpeed;
            }
        }
        StartCoroutine(num());
        
    }
}
