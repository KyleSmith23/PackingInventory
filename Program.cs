




// Classes Update test

public class InventoryItem
{
    public double Weight { get; set; }
    public double Volume { get; set; }

    public InventoryItem(double weight, double volume)
    {
        Weight = weight;
        Volume = volume;
    }

}

public class Arrow : InventoryItem
{
    public Arrow(double weight, double volume) : base(weight, volume)
    {
    }
}
