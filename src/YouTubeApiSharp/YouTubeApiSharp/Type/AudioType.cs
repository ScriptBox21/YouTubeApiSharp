﻿namespace YouTubeApiSharp
{
    public enum AudioType
    {
        Aac,
        Mp3,
        Vorbis,
        Opus,

        /// <summary>
        /// The audio type is unknown. This can occur if YoutubeExtractor is not up-to-date.
        /// </summary>
        Unknown
    }
}
