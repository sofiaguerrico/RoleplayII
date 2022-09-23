namespace RoleplayGame;
public interface ICharacters
{
    void ReceiveAttack(int power);
    void Cure();
    int Health {get;}
}


