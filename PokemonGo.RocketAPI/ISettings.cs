﻿#region

using PokemonGo.RocketAPI.Enums;
using System.Collections.Generic;
using PokemonGo.RocketAPI.GeneratedCode;

#endregion


namespace PokemonGo.RocketAPI
{
    public interface ISettings
    {
        AuthType AuthType { get; }
        string PtcPassword { get; }
        string PtcUsername { get; }
        double DefaultLatitude { get; }
        double DefaultLongitude { get; }
        double DefaultAltitude { get; }
        bool UseGPXPathing { get; }
        string GPXFile { get; }
        double WalkingSpeedInKilometerPerHour { get; }
        int MaxTravelDistanceInMeters { get; }

        bool UsePokemonToNotCatchList { get; }
        bool EvolvePokemon { get; }
        bool EvolveOnlyPokemonAboveIV { get; }
        float EvolveOnlyPokemonAboveIVValue { get; }
        bool TransferPokemon { get; }
        int TransferPokemonKeepDuplicateAmount { get; }
        bool NotTransferPokemonsThatCanEvolve { get; }

        float KeepMinIVPercentage { get; }
        int KeepMinCP { get; }
        bool PrioritizeIVOverCP { get; }
        bool useLuckyEggsWhileEvolving { get; }

        ICollection<KeyValuePair<ItemId, int>> ItemRecycleFilter { get; }
        ICollection<PokemonId> PokemonsToEvolve { get; }
        ICollection<PokemonId> PokemonsNotToTransfer { get; }
        ICollection<PokemonId> PokemonsNotToCatch { get; }
    }
}