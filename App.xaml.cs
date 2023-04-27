namespace maui_flyout_test;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Grid g;
		var flyout = new FlyoutPage
		{
			Flyout = new ContentPage {
				Title = "Foo",
				Content = g = new Grid
				{
					VerticalOptions = LayoutOptions.Fill,
					HorizontalOptions = LayoutOptions.Fill,
					ColumnDefinitions = { new ColumnDefinition(GridLength.Star) },
					RowDefinitions =
					{
						new RowDefinition(GridLength.Auto),
						new RowDefinition(GridLength.Auto),
						new RowDefinition(GridLength.Star),
						new RowDefinition(GridLength.Auto),
						new RowDefinition(GridLength.Auto),
					},
					Children =
					{
						new Label { Text = "Top" },
						new BoxView { HeightRequest = 1 },
						new CollectionView {
							HorizontalOptions = LayoutOptions.FillAndExpand,
							VerticalOptions = LayoutOptions.FillAndExpand,
							ItemsSource = new string[] { "1", "2", "3" }
						},
						new BoxView { HeightRequest = 1 },
						new StackLayout {
							Padding = 0,
							Orientation = StackOrientation.Horizontal,
							HeightRequest = 46,
							Children = {
								new Label { Text = "Bottom" },
							}
						}
					}
				}
			},
			Detail = new ContentPage { Content = new Label { Text = "Foo"} }
		};

		g.SetRow(g.Children[0], 0);
		g.SetRow(g.Children[1], 1);
		g.SetRow(g.Children[2], 2);
		g.SetRow(g.Children[3], 3);
		g.SetRow(g.Children[4], 4);

		MainPage = flyout;
	}
}
