using BottomSheetIssueSample.Pages;

namespace BottomSheetIssueSample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        var page = new MySheetPage();

        page.IsModal = true; // workaroung to fix the Android top gap which were mentioned in https://github.com/the49code/The49.Maui.BottomSheet/issues/10
        page.ShowHandle = true;
        page.Cancelable = true;

        page.Show(Window);
    }
}

