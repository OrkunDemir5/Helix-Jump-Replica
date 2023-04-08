using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject splashPrefab;
    public float jumpForce;
    private GameManager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rb.AddForce(Vector3.up * jumpForce);
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f,-0.2f,0f), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        if (collision.gameObject.tag == "Unsafe")
        {
            //bölüm yeniden baþlayacak
            gm.RestartGame();
            
        }
        else if (collision.gameObject.tag == "LastRing")
        {
            //bir sonraki levele geçecek
            
        }
        
    }
}
