
namespace Characters.Attack
{
    public interface IAttack
    {
        void lightAttack();
        void addCombo();
        void resetCombo();
        int getCurrentCombo();
    }
}
