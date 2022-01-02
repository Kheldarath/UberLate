using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage = false;
    [SerializeField] float destructTime = 1f;
    [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);
    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = noPackageColor;
    }


    void OnCollisionEnter2D(Collision2D other)
    {

        Debug.Log("FUCK YOU TOO BUDDY!");

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "package" && !hasPackage)
        {
            Debug.Log("You picked up the package");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(other.gameObject, destructTime);
            
        }

        if (other.tag == "customer" && hasPackage)
        {
            Debug.Log("You delivered a package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
