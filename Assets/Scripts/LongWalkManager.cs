using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class LongWalkManager : MonoBehaviour
{
    public GameObject Player;
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = Player.GetComponent<Rigidbody>();
        float horiInput = Input.GetAxis("Horizontal");
        float vertiInput = Input.GetAxis("Vertical");

        if (horiInput != 0 || vertiInput != 0)
        {
            rb.AddForce(new Vector3(horiInput, 0, vertiInput) * movementSpeed * Time.deltaTime, ForceMode.Force);
        }
    }
}
