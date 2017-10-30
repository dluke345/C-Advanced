using System;
using System.Threading;

namespace EventsAndDelegates
{
    //Publisher - this never needs to change, we can just add classes for different services.
    public class VideoEncoder
    {

        //1 - Define a delegate, this is the long way. There is a built in EventHandler in C# we can use instead of creating our own delegate
        ///public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // EventHandler
        // EventHandler<TEventArgs>

        //2 - Define a event based on that delegate, this is how it would be if we created our own delegate
        ///public event VideoEncodedEventHandler VideoEncoded;
        
        //If you wanted to publish an event without sending any additional data
        ///public event EventHandler VideoEncoded;

        //This is how it is when we use the built in EventHandler delegate
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        //3 - Raise the event
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}