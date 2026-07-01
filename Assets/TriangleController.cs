using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TriangleController : MonoBehaviour
{
    SpriteRenderer sr;
    Transform tr;
    Color[] colors;
    int colorIndex = 0;
    int x = 0;
    bool isRotating = false;
    int speed = 1;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        tr = GetComponent<Transform>();
        colors = new Color[] { Color.red, Color.green, Color.blue, Color.yellow, Color.cyan, Color.magenta };
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
         {

            sr.color = Random.ColorHSV();
            tr.localScale *= 1.2f;

        }
        if (Input.GetMouseButtonDown(1))
        {
            sr.color = colors[colorIndex];
            colorIndex++;
            if (colorIndex >= colors.Length) colorIndex = 0;

        }
        if (Input.GetMouseButtonDown(2))
        {

            sr.color = Random.ColorHSV();
            tr.localScale *= 0.8f;

        }
        /*
        if (Input.GetMouseButtonDown(3))
        {
            tr.localScale *= 0.8f;
            print("blackward");
        }
        if (Input.GetMouseButtonDown(4))
        {
            print("forward");
            tr.localScale *= 1.2f;
        }*/

        // Reset the triangle to its original state when the R key is pressed
        if (Input.GetKeyDown(KeyCode.R))
        {
            colorIndex = 0;
            sr.color = Color.white;
            tr.localScale = new Vector3(5, 5, 5);
            tr.rotation = Quaternion.identity;
        }
        // Start rotating the triangle when the S key is pressed, and stop rotating when the X key is pressed
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            isRotating = true;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            isRotating = false;
        }

        if (isRotating)
        {
            tr.Rotate(0, 0, -45 * Time.deltaTime * speed);
            sr.color = Random.ColorHSV();
        }

        // Mouse scroll wheel scaling
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");
        if (scrollInput > 0)
        {
            speed += 10;
            print(speed);
        }
        else if (scrollInput < 0)
        {
            speed -= 10;
            print(speed);
        }
    }
}
