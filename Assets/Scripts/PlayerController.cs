using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public float speed;
    public Text countText;
    public Text winText;
    public GameObject world;

    private int count;

	// Use this for initialization
	void Start () {
        count = 0;
        SetCountText();
        winText.text = "";
	}
	
    // called per frame, before performing physics
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        movement = world.transform.TransformDirection(movement);
        print(movement);
        transform.Translate(movement * Time.deltaTime * speed);

        GetComponent<Rigidbody>().AddForce(world.transform.up * -9.8f);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}