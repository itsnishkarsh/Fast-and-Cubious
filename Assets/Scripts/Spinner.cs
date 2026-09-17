
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xValue;
    [SerializeField] float yValue;
    [SerializeField] float zValue;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
