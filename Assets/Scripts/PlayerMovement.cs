using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rigidBody;
    public float forwardForse = 2000f;
    public float sidewayForse = 500f;

    void FixedUpdate() {
        rigidBody.AddForce(0, 0, forwardForse * Time.deltaTime);

        if (Input.GetKey("d")) {
            rigidBody.AddForce(sidewayForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")) {
            rigidBody.AddForce(-sidewayForse * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rigidBody.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
