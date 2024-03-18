using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float bulletVelocity = 30;
    public float bulletPrefabLifeTime = 3f;
    public Text bulletText; // Change to Text

    public GameObject gameOver;

    private int bullet = 25; // Assuming you start with 10 bullets

    // Start is called before the first frame update
    void Start()
    {
        UpdateBulletText();
    }

    // Update is called once per frame
    void Update()
    {
        // Left mouse click
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (bullet > 0) // Check if there are bullets available
            {
                bullet--; // Decrease bullet count
                FireWeapon();
                UpdateBulletText(); // Update UI text
            }
            else
            {
                Cursor.lockState = CursorLockMode.None;
                gameOver.SetActive(true);
                Debug.Log("Out of bullets!"); // Optionally handle out of bullets case
            }
        }
    }

    private void FireWeapon()
    {
          // Instantiate the bullet
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, Quaternion.identity);
        // Shoot the bullet
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward.normalized * bulletVelocity, ForceMode.Impulse);
        // Destroy the bullet after some time
        StartCoroutine(DestroyBulletAfterTime(bullet, bulletPrefabLifeTime));
    }

    private IEnumerator DestroyBulletAfterTime(GameObject bullet, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(bullet);
    }

    private void UpdateBulletText()
    {
        if (bulletText != null)
        {
            bulletText.text = "Bullets: " + bullet.ToString();
        }
    }
}