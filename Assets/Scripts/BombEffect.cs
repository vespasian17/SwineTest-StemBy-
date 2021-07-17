using System.Collections;
using UnityEngine;

public class BombEffect : MonoBehaviour
{
    [SerializeField] private float timeBeforeExplode = 3f;
    [SerializeField] private ParticleSystem dirtParticle;
    private PolygonCollider2D _collider2D;

    private void Awake()
    {
        _collider2D = GetComponent<PolygonCollider2D>();
    }

    private void Start()
    {
        StartCoroutine("bombTimer");
    }

    private IEnumerator bombTimer()
    {
        yield return new WaitForSeconds(timeBeforeExplode);
        _collider2D.enabled = true;
        Instantiate(dirtParticle, this.transform.position, Quaternion.identity).Play();
        Destroy(this.gameObject, 0.2f);
    }
}
