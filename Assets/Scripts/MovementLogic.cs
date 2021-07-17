using UnityEngine;

[RequireComponent(typeof(SpriteController))]
public class MovementLogic : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private Rigidbody2D _rigidbody;
    private SpriteController _sprites;
    
    private void Awake()
    {
        _sprites = GetComponent<SpriteController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    
    public void Move(float directionX, float directionY)
    {
        Movement(directionX, directionY);
        _sprites.SpriteDirection();
    }

    private void Movement(float directionX, float directionY)
    {
        _rigidbody.velocity = new Vector2(directionY * speed, _rigidbody.velocity.y);
        _rigidbody.velocity = new Vector2(directionX * speed, _rigidbody.velocity.x);
    }

    public void ChangeSpeed(int newSpeed)
    {
        speed = newSpeed;
    }
}
