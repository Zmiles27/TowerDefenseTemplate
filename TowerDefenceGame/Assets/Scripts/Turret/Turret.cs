using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Turret : MonoBehaviour
{
    public GameObject bulletPrefab;

    private bool canShoot;
    public float shootDelay;

    private void Start()
    {
        canShoot= true;
    }

    void Update()
    {
        //Aims Turret at mousePointer
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

        //Shoots Bullet In Direction of Enemy
        if (canShoot == true)
        {       
            if (Input.GetMouseButtonDown(1))
            {
                canShoot = false;
                Instantiate(bulletPrefab, this.transform.position, Quaternion.LookRotation(Vector3.forward, mousePos - transform.position));
                StartCoroutine(Delay());
            }
        }



        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("StartScreen");
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(shootDelay * 10 * Time.deltaTime);
        canShoot = true;
    }
}
