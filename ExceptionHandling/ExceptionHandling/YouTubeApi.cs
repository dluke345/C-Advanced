using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access YouTube web service
                // Read the data
                // Create a list of Video objects
                throw new Exception("Oops some low level YouTube error.");
            }
            catch (Exception e)
            {
                // Log

                //This exception gets passed to the catch block exception in the main method
                throw new YouTubeException("Could not fetch the videos from youtube.\n", e);
            }

            return new List<Video>();
        }
    }
}