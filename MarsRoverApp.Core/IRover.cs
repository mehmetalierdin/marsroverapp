namespace MarsRoverApp.Core
{
    public interface IRover
    {
        void Process(string commands);
        void TurnLeft();
        void TurnRight();
        void Move();
        string ToString();
    }
}