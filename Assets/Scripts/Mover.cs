using System.Diagnostics;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstruction()
    {
        UnityEngine.Debug.Log("Welcome to the Fast And Cubious");
        UnityEngine.Debug.Log("Move using arrow Keys or W A S D");
        UnityEngine.Debug.Log("Don't bump into objects");
    }
    void MovePlayer()
    {
     float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
     float yValue = 0f;
     float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
     transform.Translate(xValue, yValue, zValue);
    }
}
