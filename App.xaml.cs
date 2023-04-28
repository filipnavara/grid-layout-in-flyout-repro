namespace maui_flyout_test;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Grid g;

		MainPage = new ContentPage
		{
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
						ItemsSource = new string[] { "1", "2", "3" }
					},
					new BoxView { HeightRequest = 1 },
					new Label { Text = "Bottom" },
				}
			}
		};

		g.SetRow(g.Children[0], 0);
		g.SetRow(g.Children[1], 1);
		g.SetRow(g.Children[2], 2);
		g.SetRow(g.Children[3], 3);
		g.SetRow(g.Children[4], 4);
	}
}
