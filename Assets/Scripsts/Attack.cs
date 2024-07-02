using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float damage = 1f;
    public float knockbackForce = 500f;

    public Vector3 faceRight = new Vector3(1.3f, -0.25f, 0);
    public Vector3 faceLeft = new Vector3(-1.3f, -0.25f, 0);

    public Collider2D attackCollider;


    public void Start()
    {
        if (attackCollider == null)
        {
            Debug.LogWarning("Sword Collider not set");
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        IDamageable damageableObject = collider.GetComponent<IDamageable>();
        if (damageableObject != null)
        {
            Vector3 parentPosition = gameObject.GetComponentInParent<Transform>().position;
            Vector2 direction = (Vector2) (collider.gameObject.transform.position - parentPosition).normalized;
            Vector2 knockback = direction * knockbackForce;

            damageableObject.OnHit(damage, knockback);
        }
    }

    void IsFacingRight(bool isFacingRight)
    {
        if (isFacingRight)
        {
            gameObject.transform.localPosition = faceRight;
        }
        else
        {
            gameObject.transform.localPosition = faceLeft;
        }
    }
}
