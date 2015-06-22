namespace NativeCode.Mobile.Core.Droid.Platform
{
    using Android.Content;
    using Android.Net;
    using Android.OS;
    using Android.Provider;

    using NativeCode.Mobile.Core.Platform;

    public class DeviceInformant : IDeviceInformant
    {
        private readonly IContextProvider provider;

        public DeviceInformant(IContextProvider provider)
        {
            this.provider = provider;
        }

        public string DeviceIdentifier
        {
            get { return Settings.Secure.GetString(this.Context.ContentResolver, Settings.Secure.AndroidId); }
        }

        public bool IsConnected
        {
            get { return this.GetIsConnected(); }
        }

        protected Context Context
        {
            get { return this.provider.GetCurrentContext(); }
        }

        public string GetDisplayString()
        {
            return Build.Display;
        }

        public string GetDeviceString()
        {
            return Build.Device;
        }

        public string GetHardwareString()
        {
            return Build.Hardware;
        }

        public string GetPlatformString()
        {
            return Build.VERSION.Sdk;
        }

        public string GetProductString()
        {
            return Build.Product;
        }

        private bool GetIsConnected()
        {
            var manager = (ConnectivityManager)this.Context.GetSystemService(Context.ConnectivityService);
            var network = manager.ActiveNetworkInfo;

            return network != null && network.IsConnected;
        }
    }
}