using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    public float velocidad = 5f;

    void FixedUpdate()
    {
        float inputX = 0f;

        if (Input.GetKey(KeyCode.LeftArrow))
            inputX = -1f;

        if (Input.GetKey(KeyCode.RightArrow))
            inputX = 1f;

        Vector3 movimiento = new Vector3(inputX, 0, 0) * velocidad * Time.deltaTime;
        transform.Translate(movimiento, Space.World);
    }
}
