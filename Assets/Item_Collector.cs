using UnityEngine;


public class Item_Collector : MonoBehaviour
{
    public GameObject bone;
    public GameObject hand;
    public GameObject heart;
    public GameObject brain;
    public GameObject eyeball;
    public GameObject foot;

    public bool Bone = false;
    public bool Hand = false;
    public bool Heart = false;
    public bool Brain = false;
    public bool Eyeball = false;
    public bool Foot = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    bone.SetActive(false);
    hand.SetActive(false);
    heart.SetActive(false);
    brain.SetActive(false);
    eyeball.SetActive(false);
    foot.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("bone"))
    {
        Destroy(collision.gameObject);
        bone.SetActive(true);
        Bone = !Bone;
    }
        if (collision.gameObject.CompareTag("hand"))
    {
        Destroy(collision.gameObject);
        hand.SetActive(true);
        Hand = !Hand;
    }
        if (collision.gameObject.CompareTag("heart"))
    {
        Destroy(collision.gameObject);
        heart.SetActive(true);
        Heart = !Heart;
    }
        if (collision.gameObject.CompareTag("brain"))
    {
        Destroy(collision.gameObject);
        brain.SetActive(true);
        Brain = !Brain;
    }
        if (collision.gameObject.CompareTag("eyeball"))
    {
        Destroy(collision.gameObject);
        eyeball.SetActive(true);
        Eyeball = !Eyeball;
    }
        if (collision.gameObject.CompareTag("foot"))
    {
        Destroy(collision.gameObject);
        foot.SetActive(true);
        Foot = !Foot;
    }

        if(collision.gameObject.CompareTag("Depot"))
        {
            Markoff();
        }
    
    }

    void Markoff()
    {
        // for each bool that is correct activate the corresponding cross
    }
    
}
