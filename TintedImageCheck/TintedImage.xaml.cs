namespace TintedImageCheck.Controls;

public partial class TintedImage : Image
{
    public static readonly BindableProperty TintColorProperty =
        BindableProperty.Create(
            nameof(TintColor),
            typeof(Color),
            typeof(TintedImage),
            Colors.Transparent);

    public Color TintColor
    {
        get => (Color)GetValue(TintColorProperty);
        set => SetValue(TintColorProperty, value);
    }

    public TintedImage()
    {
        InitializeComponent();
    }
}
