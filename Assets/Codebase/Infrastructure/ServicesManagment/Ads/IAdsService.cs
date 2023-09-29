namespace Assets.Codebase.Infrastructure.ServicesManagment.Ads
{
    /// <summary>
    /// Managing ads.
    /// </summary>
    public interface IAdsService : IService
    {
        public void ShowRewarded();
        public void ShowFullscreen();

        /// <summary>
        /// Enables or disables ads.
        /// </summary>
        /// <param name="adsEnabled"></param>
        public void SetAdsStatus(bool adsEnabled);
    }
}
