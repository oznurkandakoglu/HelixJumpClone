using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float jumpForce;
    public GameObject splashPrefab;
    private GameManager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(Vector3.up * jumpForce);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f, -0.2f, 0f), transform.rotation);
        splash.transform.SetParent(other.gameObject.transform);
        string materialName = other.gameObject.GetComponent<MeshRenderer>().material.name;


        if (materialName == "UnsafeColor (Instance)")
        {
            gm.RestartGame();
        }

        else if (materialName == "LastRing (Instance)")
        {
            Debug.Log("Next Level");
        }
    }
}
