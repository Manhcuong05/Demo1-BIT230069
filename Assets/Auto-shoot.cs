using UnityEngine;

public class AutoShoot : MonoBehaviour {
    public GameObject bulletPrefab;   // Prefab viên đạn
    public float shootingInterval = 0.1f; // Khoảng thời gian giữa các lần bắn
    private float lastBulletTime;     // Thời điểm bắn viên cuối cùng

    void Update() {
        // Kiểm tra nếu người chơi đang giữ chuột trái (nút 0)
        if (Input.GetMouseButton(0)) {
            // Kiểm tra xem đã đến lúc bắn viên tiếp theo chưa
            if (Time.time - lastBulletTime > shootingInterval) {
                ShootBullet();
                lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet() {
        // Tạo viên đạn tại vị trí của tàu
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}