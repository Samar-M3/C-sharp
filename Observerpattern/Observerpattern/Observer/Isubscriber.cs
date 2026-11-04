using System;
using System.Collections.Generic;
using System.Text;

namespace Observerpattern.Observer
{
    internal interface Isubscriber
    {
        void Update(string channelName, string videoTitle);


    }
}
