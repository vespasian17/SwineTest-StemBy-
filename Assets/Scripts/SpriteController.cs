using UnityEngine;

public class SpriteController : MonoBehaviour
{
    private Sprite spriteToRight;
    private Sprite spriteToLeft;
    private Sprite spriteToTop;
    private Sprite spriteToBottom;
    
    [SerializeField] private Sprite defaultSpriteToRight;
    [SerializeField] private Sprite defaultSpriteToLeft;
    [SerializeField] private Sprite defaultSpriteToTop;
    [SerializeField] private Sprite defaultSpriteToBottom;
    
    [SerializeField] private Sprite dirtySpriteToLeft;
    [SerializeField] private Sprite dirtySpriteToRight;
    [SerializeField] private Sprite dirtySpriteToBottom;
    [SerializeField] private Sprite dirtySpriteToTop;
    
    [SerializeField] private Sprite angrySpriteToLeft;
    [SerializeField] private Sprite angrySpriteToRight;
    [SerializeField] private Sprite angrySpriteToBottom;
    [SerializeField] private Sprite angrySpriteToTop;
    
    private SpriteRenderer _spriteRenderer;
    private IMovable movableObject;
    private void Awake()
    {
        movableObject = GetComponent<IMovable>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        spriteToRight = defaultSpriteToRight;
        spriteToLeft = defaultSpriteToLeft;
        spriteToTop = defaultSpriteToTop;
        spriteToBottom = defaultSpriteToBottom;
    }

    public void SpriteDirection()
    {
        SpriteDirectionLogic();
    }
    
    private void SpriteDirectionLogic()
    {
        if (movableObject.GetHorizontalAxis() < 0) _spriteRenderer.sprite = spriteToLeft;
        if (movableObject.GetHorizontalAxis() > 0) _spriteRenderer.sprite = spriteToRight;
        
        if (movableObject.GetVerticalAxis() < 0) _spriteRenderer.sprite = spriteToBottom;
        if (movableObject.GetVerticalAxis() > 0) _spriteRenderer.sprite = spriteToTop;
    }

    private void SetNewSprites(Sprite left, Sprite right, Sprite top, Sprite bottom)
    {
        if (left != null && right != null && top != null && bottom != null)
        {
            spriteToRight = right;
            spriteToLeft = left;
            spriteToTop = top;
            spriteToBottom = bottom;
        }
        else Debug.LogWarning("Sprites are not setting. Check sprites fields in inspector.");
    }
    
    public void ChangeToDirtySprites()
    {
        SetNewSprites(dirtySpriteToLeft, dirtySpriteToRight, dirtySpriteToTop, dirtySpriteToBottom);
    }
    
    public void ChangeToAngrySprites()
    {
        SetNewSprites(angrySpriteToLeft, angrySpriteToRight, angrySpriteToTop, angrySpriteToBottom);
    }
    
    public void ChangeToDefaultSprites()
    {
        SetNewSprites(defaultSpriteToLeft, defaultSpriteToRight, defaultSpriteToTop, defaultSpriteToBottom);
    }
}
