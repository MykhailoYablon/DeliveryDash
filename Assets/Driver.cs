using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public float x, y = 0.01f;
    public float z = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(x, y, z);
        transform.Rotate(0, 0, 0.05f);
        
    }
}
