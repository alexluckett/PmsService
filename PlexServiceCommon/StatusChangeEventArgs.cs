﻿using System;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace PlexServiceCommon
{
    /// <summary>
    /// Event arguments for a plex status change
    /// </summary>
    [Serializable]
    [DataContract]
    public class StatusChangeEventArgs: EventArgs
    {
        [DataMember]
        public EventLogEntryType EventType { get; private set; }
        [DataMember]
        public string Description { get; private set; }

        public StatusChangeEventArgs(string description, EventLogEntryType eventType = EventLogEntryType.Information)
        {
            EventType = eventType;
            Description = description;
        }
    }
}
