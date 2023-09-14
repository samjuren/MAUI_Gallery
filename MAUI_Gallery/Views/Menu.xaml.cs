using MAUI_Gallery.Repositories;

namespace MAUI_Gallery.Views;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();

		var categories = new CategoryRepository().GetCategories();

		
		foreach (var category in categories)
		{
            var lblcategory = new Label();
            lblcategory.Text = "Layout";
			lblcategory.FontFamily = "OpenSansSemibold";
            MenuContainer.Children.Add(lblcategory);

            foreach (var component in category.Components) 
			{
				var tap = new TapGestureRecognizer();
				tap.CommandParameter = component.Page;
				tap.Tapped += OnTapComponent;

				var lblComponenteTitle = new Label();
				lblComponenteTitle.Text = component.Title;
				lblComponenteTitle.FontFamily = "OpenSansSemibold";
				lblComponenteTitle.Margin = new Thickness(20,10,0,0);
				lblComponenteTitle.GestureRecognizers.Add(tap);


                var lblComponenteDescription = new Label();
				lblComponenteDescription.Text = component.Description;
                lblComponenteDescription.Margin = new Thickness(20, 10, 0, 0);
                lblComponenteDescription.GestureRecognizers.Add(tap);

                MenuContainer.Children.Add(lblComponenteTitle);
				MenuContainer.Children.Add(lblComponenteDescription);
            }
        }
    }

	private void OnTapComponent(object sender, EventArgs e)
	{
		var label = (Label)sender;
		var tap = (TapGestureRecognizer)label.GestureRecognizers[0];
		var page = (Type)tap.CommandParameter;

		((FlyoutPage)App.Current.MainPage).Detail =  new NavigationPage((Page)Activator.CreateInstance(page));
		((FlyoutPage)App.Current.MainPage).IsPresented = false;
	}

    private void OnTapInicio(object sender, TappedEventArgs e)
    {

        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new MAUI_Gallery.Views.MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}