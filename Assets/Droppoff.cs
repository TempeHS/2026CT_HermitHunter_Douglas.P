using UnityEngine;

public class Droppoff : MonoBehaviour
{
    public Item_Collector BPScript;
    private Item_Collector BP;
    public bool BoneCheck;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BP = GetComponent<Item_Collector>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
    {
        BoneCheck = BPScript.Bone;
        Debug.Log(BoneCheck);
    }
        //on collide with player check what things it has
        //mark those objects here
        //check if all objects have been marked
        // if so DEBUG YOU WIN
    }
}
