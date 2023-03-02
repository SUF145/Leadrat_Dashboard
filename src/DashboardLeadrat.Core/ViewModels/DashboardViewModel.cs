using System;
namespace DashboardLeadrat.Core.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        
        private string _imageUrl;
        public string ImageUrl { get => _imageUrl; set => SetProperty(ref _imageUrl, value); }

        public string WishMessage { get; set; }
        
        public DashboardViewModel()
        {
            ChangeBackground();
        }

        public void ChangeBackground()
        {
                TimeSpan time = DateTime.Now.TimeOfDay;
                if ((time.Hours >= 6) && (time.Hours <= 12))
                {
                    ImageUrl = "image_morning.jpg";
                    WishMessage = "Good morning";
                }
                else if ((time.Hours >= 13) && (time.Hours <= 16))
                {
                    ImageUrl = "image_afternoon.png";
                    WishMessage = "Good afternoon";
                }
                else
                {
                    ImageUrl = "image_night.png";
                    WishMessage = "Good evening";
                }
        }         
    }
}

