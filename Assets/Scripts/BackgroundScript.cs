using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    public float speed;
 
    void Update()
    {
        MoveBackground();
    }

    private void MoveBackground()
    {
        Vector2 Offset = new Vector2(Time.time * speed, 0);
        GetComponent<Renderer>().material.mainTextureOffset = Offset;
    }
}
