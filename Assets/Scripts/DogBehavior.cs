public class DogBehavior : EnemyBehavior, IExplodable
{
    public override void ExplodeEffectOfCharacter()
    {
        _movementLogic.ChangeSpeed(speedWhileDirty);
    }
    
    public override void AngryEffectOfCharacter()
    {
        _movementLogic.ChangeSpeed(speedWhileAngry);
    }
}
