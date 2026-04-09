using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHp = 3;
    public int currenHp;

    public GameObject xpPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currenHp = maxHp;
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        currenHp -= damage;
        Debug.Log("맞았음!");

        if(currenHp < 0 )
        {
            Die();
        }
    }
    
    void Die()
    {
        if (xpPrefab != null)
        {
            Instantiate(xpPrefab, transform.position, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
