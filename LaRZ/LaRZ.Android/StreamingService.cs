using LaRZ.Interfaces;
using Android.Media;
using LaRZ.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(StreamingService))]
namespace LaRZ.Droid
{
    class StreamingService : IStreaming
    {
        MediaPlayer player;
        string dataSource = "rtsp://streamlky.alsolnet.com/larz/larz.stream";

        bool IsPrepared = false;

        public void Play()
        {
            if (!IsPrepared)
            {
                if (player == null)
                    player = new MediaPlayer();
                else
                    player.Reset();

                player.SetDataSource(dataSource);
                player.PrepareAsync();
            }

            player.Prepared += (sender, args) =>
            {
                player.Start();
                IsPrepared = true;
            };
        }

        public void Pause()
        {
            player.Pause();
        }

        public void Stop()
        {
            player.Stop();
            IsPrepared = false;
        }
    }
}