using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text GameOverUI;
    public float kecepatan;
    Rigidbody rb;
    Animator anim;

    public Transform playerRotation;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Bergerak();
    }

    void Bergerak()
    {
        float gerak = Input.GetAxis("Horizontal");
        rb.velocity = Vector3.right * gerak * kecepatan;
        anim.SetFloat("Kecepatan",Mathf.Abs(gerak),0.1f, Time.deltaTime);
        playerRotation.localEulerAngles = new Vector3(0,gerak*90,0);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("batu"))
        {
            Time.timeScale = 0;
            GameOverUI.text = "Game Over \n Tekan R untuk mengulang permainan";
        }
    
    }

}
