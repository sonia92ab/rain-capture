
using System.Linq.Expressions;
using System.Numerics;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    private Rigidbody2D rb;
    public float moveforce = 8f;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var HorizontalInput= Input.GetAxis("Horizontal");
        UnityEngine.Vector2 force = new UnityEngine.Vector2(HorizontalInput * moveforce, 0);
        rb.AddForce(force); 
        Debug.Log(rb.mass);
}

}