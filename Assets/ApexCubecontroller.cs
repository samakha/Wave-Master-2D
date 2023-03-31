using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 
public class ApexCubecontroller : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce; 
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 

    }
    public void jumpup()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }
    }
}
