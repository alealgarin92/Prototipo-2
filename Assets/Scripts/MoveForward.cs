using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 40;
    private bool spaceInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spaceInput = Input.GetKeyDown(KeyCode.Space);

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
