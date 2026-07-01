using UnityEngine;

public class Hello : MonoBehaviour
{
    [Header("Player Stats")]
    public int health = 100;
    [SerializeField] 
    int currentHealth = 100;

    /* Public property สำหรับการเข้าถึงจากภายนอก
    public int CurrentHealth
    {
        get { return currentHealth; }
        private set { currentHealth = value; }
    }*/
    void Start()
    {
        Debug.Log("Start");
        //print("Start");
    }

    // Update is called once per frame
    void Update()
    {
       Debug.Log("Update");
       //print("Update");
    }
}
