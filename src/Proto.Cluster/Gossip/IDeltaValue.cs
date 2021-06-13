// -----------------------------------------------------------------------
// <copyright file="IDeltaValue.cs" company="Asynkron AB">
//      Copyright (C) 2015-2021 Asynkron AB All rights reserved
// </copyright>
// -----------------------------------------------------------------------
using System;

namespace Proto.Cluster.Gossip
{
    public interface IDeltaValue
    {
        GossipDeltaValue GetDelta(long fromSequenceNumber);
    }
}