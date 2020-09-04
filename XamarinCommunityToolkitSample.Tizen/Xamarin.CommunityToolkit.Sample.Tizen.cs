namespace Xamarin.CommunityToolkit.Sample
{
	class Program : Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();

            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var app = new Program();
			Forms.Forms.SetFlags("CollectionView_Experimental");
			Forms.Forms.Init(app);
            app.Run(args);
        }
    }
}