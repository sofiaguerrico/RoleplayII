namespace RoleplayGame
{
    public class Staff : IInteractions
    {
        public int AttackValue 
        {
            get
            {
                return 100;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 10;
            }
        }
    }
}