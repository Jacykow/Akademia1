namespace AkademiaTest
{
    public class Bike
    {
        public float distance;
        public string type;

        public Bike(string type)
        {
            this.type = type;
            distance = 0;
        }

        public Bike()
        {
            distance = 0;
        }

        public override string ToString()
        {
            return $"Rower {type} jest w odległości {distance}m od domu.";
        }

        public void Move(float distanceDelta)
        {
            this.distance += distanceDelta;
        }
    }
}
