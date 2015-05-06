﻿using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace ServerCenter
{
    class RainfallReceiveFilterFactory<TRequestInfo> : IReceiveFilterFactory<TRequestInfo>
        where TRequestInfo : IRequestInfo
    {
        public virtual IReceiveFilter<TRequestInfo> CreateFilter(IAppServer appServer, IAppSession appSession,
                                                         IPEndPoint remoteEndPoint)
        {
            var filter = new RainfallReceiveFilter(appSession);
            return (filter as IReceiveFilter<TRequestInfo>);
        }
    }

}