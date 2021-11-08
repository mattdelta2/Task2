namespace Task2
{
    public class HeroBase
    {

        public override MovementDirection ReturnMove(MovementDirection CharacterMove = MovementDirection.NoMovement)
        {
            if (CharacterMove is null)
            {
                throw new ArgumentNullException(nameof(CharacterMove));
            }

            if (CheckForValidMove(CharacterMove))
            {
                return CharacterMove;

            }
            else return MovementDirection.NoMovement;

        }
    }
}