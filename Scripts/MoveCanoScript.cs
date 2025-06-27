using UnityEngine;

public class moveCano : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;


    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

}
