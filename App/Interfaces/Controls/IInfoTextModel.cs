﻿using System;

namespace App.Interfaces
{
    public interface IInfoTextModel
    {
        void SetBeatmapCount(int beatmapCount);
        void SetCollectionCount(int collectionsCount, int beatmapsInCollectionsCount);
        void SetMissingBeatmapCount(int missingBeatmapsCount);
        int BeatmapCount { get; }
        int BeatmapsInCollectionsCount { get; }
        int MissingBeatmapsCount { get; }
        int CollectionsCount { get; }
        IUpdateModel GetUpdater();
        void EmitUpdateTextClicked();
        event EventHandler CountsUpdated;
        event EventHandler UpdateTextClicked;

    }
}