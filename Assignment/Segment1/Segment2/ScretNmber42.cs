
namespace Assignmet.Segment2
{
    class SecretNmber42 : ISecretNumber
    {
        const int _SecrectNmber = 42; 
        public bool EvalateSecretNumber(int number)
        {
            return number == _SecrectNmber ? true : false;
        }
    }
}
