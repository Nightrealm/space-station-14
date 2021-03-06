﻿using System;
using SS14.Shared.Input;
using SS14.Shared.Map;
using SS14.Shared.Serialization;

namespace SS14.Shared.GameObjects
{
    [Serializable, NetSerializable]
    public class ClickEventMessage : EntitySystemMessage
    {
        public EntityUid Uid { get; }
        public ClickType Click { get; }
        public LocalCoordinates Coordinates { get; }

        public ClickEventMessage(EntityUid uid, ClickType click, LocalCoordinates coordinates)
        {
            Uid = uid;
            Click = click;
            Coordinates = coordinates;
        }
    }
}
