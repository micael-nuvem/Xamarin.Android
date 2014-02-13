using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Exercicio4
{
	[Activity (Label = "Exercicio4", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Define layout
			SetContentView(Resource.Layout.Main);

			var gridView = FindViewById<GridView> (Resource.Id.gridview);
			gridView.Adapter = new ImageAdapter(this);

			gridView.ItemClick += delegate(object sender, AdapterView.ItemClickEventArgs e) {
				Toast.MakeText(this, e.Position.ToString(), ToastLength.Short).Show();
			};

		}
	}
}


