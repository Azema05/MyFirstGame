using UnityEngine;

public class ObstacleCars : MonoBehaviour
{
        private float speed = 5.0f;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
