
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
//No changes
using static Android.Gms.Maps.GoogleMap;

namespace Maps
{
	[Activity(Label = "Maps", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity, IOnMapReadyCallback
	{
		GoogleMap map;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

		}

		public void OnMapReady(GoogleMap googleMap)
		{this.map = googleMap;
			if (null != map)
			{
				LatLng locationLatLng1 = new LatLng(32.86536, -666.98920);
				LatLng locationLatLng2 = new LatLng(35.83133, -76.00773);
				LatLng locationLatLng3 = new LatLng(37.866416, -70.950285);
				LatLng locationLatLng4 = new LatLng(33.899925, -79.996591);
				LatLng locationLatLng5 = new LatLng(40.87146, 1.35500);

				CameraPosition.Builder builder = CameraPosition.InvokeBuilder();
				builder.Target(locationLatLng1);
				builder.Target(locationLatLng2);
				builder.Target(locationLatLng3);
				builder.Target(locationLatLng4);
				builder.Target(locationLatLng5);
				builder.Zoom(12);
				builder.Bearing(155);
				builder.Tilt(65);
				CameraPosition cameraPosition = builder.Build();
				CameraUpdate cameraUpdate = CameraUpdateFactory.NewCameraPosition(cameraPosition);
				map.MoveCamera(cameraUpdate);

				MarkerOptions options1 = new MarkerOptions();
				options1.SetPosition(locationLatLng1);
				options1.SetTitle("Shoe Island");
				options1.SetSnippet("455 Paris Road" + "Baton, Lousiana ");

				map.AddMarker(options1);

				MarkerOptions options2 = new MarkerOptions();
				options2.SetPosition(locationLatLng2);
				options2.SetTitle("Congress Center");
				options2.SetSnippet("MLK Street, SW");
				map.AddMarker(options2);


				MarkerOptions options3 = new MarkerOptions();
				options3.SetPosition(locationLatLng3);
				options3.SetTitle("Center for kids");
				options3.SetSnippet("NorthWest court, EW");
				map.AddMarker(options3);

				MarkerOptions options4 = new MarkerOptions();
				options4.SetPosition(locationLatLng4);
				options4.SetTitle(" Service Center");
				options4.SetSnippet("55, Rholde Island ");
				map.AddMarker(options4);

				MarkerOptions options5 = new MarkerOptions();
				options5.SetPosition(locationLatLng5);
				options5.SetTitle("Music Center");
				options5.SetSnippet("45 Moses Street, NW");
				map.AddMarker(options5);

			}
		}
		}

		
	}









		