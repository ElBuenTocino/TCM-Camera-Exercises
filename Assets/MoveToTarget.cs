using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public float t;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector2.Lerp(gameObject.transform.position, target.position, t * Time.deltaTime);
    }
}
