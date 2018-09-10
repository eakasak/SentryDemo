using SharpRaven;
using SharpRaven.Data;
using System;

namespace Sentry.Demo.App
{
    class Sentry
    {
        static void Main(string[] args)
        {
            var ravenClient = new RavenClient("https://f1d4810614784612b8a94fefb2c86ca2@sentry.io/1277995");
            try
            {
                int i2 = 0;
                int i = 10 / i2;
            }
            catch (Exception exception)
            {
                ravenClient.Capture(new SentryEvent(exception));
            }           
        }
    }
}
