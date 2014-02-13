using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Exercicio4
{
	class ImageAdapter:BaseAdapter
	{
		Context context;

		public ImageAdapter(Context c)
		{
			context = c;
		}

		public override int Count {
			get { return thumbIDs.Length; }
		}

		public override Java.Lang.Object GetItem (int posicao)
		{
			return null;
		}

		public override long GetItemId(int posicao)
		{
			return 0;
		}

		public override View GetView (int posicao, View convertView, ViewGroup parent)
		{
			ImageView imageView;

			if (convertView == null) {
				imageView = new ImageView (context);
				imageView.LayoutParameters = new GridView.LayoutParams (85, 85);
				imageView.SetScaleType (ImageView.ScaleType.CenterCrop);
				imageView.SetPadding (8, 8, 8, 8);
			}
			else
			{
				imageView = (ImageView) convertView;
			}

			imageView.SetImageResource(thumbIDs[posicao]);
			return imageView;
		}


		int[] thumbIDs = {
			Resource.Drawable.image0, Resource.Drawable.image1,
			Resource.Drawable.image2, Resource.Drawable.image3,
			Resource.Drawable.image4, Resource.Drawable.image5,
			Resource.Drawable.image6, Resource.Drawable.image7,
			Resource.Drawable.image7, Resource.Drawable.image6,
			Resource.Drawable.image5, Resource.Drawable.image4,
			Resource.Drawable.image3, Resource.Drawable.image2,
			Resource.Drawable.image1, Resource.Drawable.image0 ,
			Resource.Drawable.image2, Resource.Drawable.image4,
			Resource.Drawable.image0, Resource.Drawable.image6,
			Resource.Drawable.image5, Resource.Drawable.image4
		};


	}
}


