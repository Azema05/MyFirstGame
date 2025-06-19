using UnityEngine;

public class PlayerCars : MonoBehaviour

{
    private float speed = 5.0f;
    [SerializeField]
    private float turnSpeed = 50.0f;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField]
    private int id;
    [SerializeField]
    private Transform camPos1;
    [SerializeField]
    private Transform camPos2;
    [SerializeField]
    private KeyCode switchPose = KeyCode.F;
    [SerializeField]
    private Camera playCam;
    private bool switchState = false;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(switchPose))
        {
            SwitchCam();
        }


        horizontalInput = Input.GetAxis("Horizontal " + id.ToString());
        verticalInput = Input.GetAxis("Vertical " + id.ToString());


        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

    private void SwitchCam()
    {
        if (switchState)
        {
            playCam.transform.parent = camPos1;
        }
        else
        {
            playCam.transform.parent = camPos2;
        }

        playCam.transform.localPosition = Vector3.zero;
        switchState = !switchState;
    }
}
