public class RapidFireDecorator : IFireRate
{
    private IFireRate wrappedFireRate;

    public RapidFireDecorator(IFireRate fireRate)
    {
        wrappedFireRate = fireRate;
    }

    public float GetFireRate()
    {
        return 0.1f;
    }
}