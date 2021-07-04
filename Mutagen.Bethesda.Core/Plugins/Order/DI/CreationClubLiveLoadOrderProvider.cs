﻿using System;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using DynamicData;
using Noggog;

namespace Mutagen.Bethesda.Plugins.Order.DI
{
    public interface ICreationClubLiveLoadOrderProvider : ISomeLiveLoadOrderProvider
    {
    }

    public class CreationClubLiveLoadOrderProvider : ICreationClubLiveLoadOrderProvider
    {
        private readonly ICreationClubLiveListingsFileReader _fileReader;
        private readonly ICreationClubLiveLoadOrderFolderWatcher _folderWatcher;

        public CreationClubLiveLoadOrderProvider(
            ICreationClubLiveListingsFileReader fileReader,
            ICreationClubLiveLoadOrderFolderWatcher folderWatcher)
        {
            _fileReader = fileReader;
            _folderWatcher = folderWatcher;
        }
    
        public IObservable<IChangeSet<IModListingGetter>> Get(
            out IObservable<ErrorResponse> state,
            IScheduler? scheduler = null)
        {
            return InternalGet(out state)
                .ObserveOnIfApplicable(scheduler);
        }

        public IObservable<Unit> Changed => InternalGet(out _).Unit();

        private IObservable<IChangeSet<IModListingGetter>> InternalGet(out IObservable<ErrorResponse> state)
        {
            return ObservableCacheEx.And(
                    _fileReader.Get(out state)
                        .AddKey(x => x.ModKey),
                    _folderWatcher.Get()
                        .Transform<IModListingGetter, ModKey, ModKey>(x => new ModListing(x, true)))
                .RemoveKey();
        }
    }
}