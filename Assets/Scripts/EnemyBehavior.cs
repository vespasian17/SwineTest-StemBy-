using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] protected int speedWhileDirty;
    [SerializeField] protected int speedWhileAngry;
    
    [Header("Settings")]
    [SerializeField] private Transform angryColliderTransform;
    [SerializeField] private LayerMask angryMask;
    [SerializeField] private float angryOffset;
    
    protected MovementLogic _movementLogic;
    private SpriteController _spriteController;
    private bool isAngry;
    private void Awake()
    {
        _movementLogic = GetComponent<MovementLogic>();
        _spriteController = GetComponent<SpriteController>();
    }
    
    private void FixedUpdate()
    {
        Vector2 overlapCirclePosition = angryColliderTransform.position;
        isAngry = Physics2D.OverlapCircle(overlapCirclePosition, angryOffset, angryMask);
    }

    private void Update()
    {
        if (isAngry)
        {
            AngryEffectOfCharacter();
            _spriteController.ChangeToAngrySprites();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Bomb"))
        {
            ExplodeEffectOfCharacter();
            StartCoroutine("BombEffectTimer");
            _spriteController.ChangeToDirtySprites();
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Avatar"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    virtual public void ExplodeEffectOfCharacter()
    {
        _movementLogic.ChangeSpeed(2);
    }
    
    virtual public void AngryEffectOfCharacter()
    {
        _movementLogic.ChangeSpeed(5);
    }
    
    private IEnumerator BombEffectTimer()
    {
        var tempOffset = angryOffset;
        angryOffset = 0;
        yield return new WaitForSeconds(5f);
        angryOffset = tempOffset;
        _spriteController.ChangeToDefaultSprites();
    }
}
