namespace Models;

public class ProductModel
{
    public int Id { get; set; }
    public string Model { get; set; }
    public int ReleaseYear { get; set; }
    public float MaxResolution { get; set; }
    public float LowResolution { get; set; }
    public float EffectivePixels { get; set; }
    public float ZoomWide { get; set; }
    public float ZoomTele { get; set; }
    public float NormalFocusRange { get; set; }
    public float MacroFocusRange { get; set; }
    public float StorageIncluded { get; set; }
    public float Weight { get; set; }
    public float Dimensions { get; set; }
    public decimal Price { get; set; }
}