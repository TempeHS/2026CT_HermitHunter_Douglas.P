using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement; 

public class Death : MonoBehaviour
{
    public bool IsAlive = true;
    public GameObject death;
    [SerializeField] private ParticleSystem particleSystem;
    void Start()
    {
        death.SetActive(false);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public async void Dead()
    {
        //have code that stops player moving
        
        //have code that does YOU DIED
        death.SetActive(true);
        //have code that freezes moement
        IsAlive = !IsAlive;
        //have code that plays a bunch of bubbles
        particleSystem.Play();
        //have code that works
        Debug.Log("before the thing");
        await Task.Delay(3000);
        Debug.Log("after one second");
        // have code that ends everything
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        /*Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        */
    }

    void Update()
    {
        
    }
}
