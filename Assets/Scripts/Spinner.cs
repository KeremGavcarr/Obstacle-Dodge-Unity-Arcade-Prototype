using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle, yAngle, zAngle;

    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(xAngle,yAngle,zAngle);
    }
}
