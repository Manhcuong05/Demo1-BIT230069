using UnityEngine;

public class Bullet : MonoBehaviour {
    public float flySpeed = 5f; // Tốc độ đạn bay

    void Update() {
        // Đạn bay lên trên theo trục Y
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
    }
}