﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveDataReaderProto.BinaryMercurySteamSave.Enums
{
    public enum ChunkIDs : uint
    {
        #region Globally Used

        Unknown = 0xFFFFFFFF,
        BlockID = 0xC59C2CEE,

        #endregion Globally Used

        #region Common

        #region Inventory

        TotalMetroids = 0x09E50EEE,
        MaxMissiles          = 0x55F1D6B6,
        MetroidsKilled       = 0xFE981519,
        MaxEnergy            = 0x70833890,
        MaxPowerBombs        = 0xE9877735,
        MaxSuperMissiles     = 0xCBA0FFDF,
        IceBeam              = 0x77561E39,
        MaxAeionEnergy       = 0x9BD12C5A,
        CurrentEnergy        = 0x733C15CE,
        CurrentMissiles      = 0x42CED42A,
        CurrentSuperMissiles = 0x455A1D6A,
        CurrentPowerBombs    = 0xB074A1EE,
        HighJumpBoots        = 0x634DC541,
        ScrewAttack          = 0x20046296,
        SpaceJump            = 0x194F3BAA,
        MorphBall            = 0xEA9E382B,
        ScanPulse            = 0x576E4803,
        CurrentAeionEnergy   = 0xB9805F37,
        SpringBall           = 0xA9FB0778,
        CurrentMetroidDNA    = 0x462D2463,
        ChargeBeam           = 0xA34423D9,
        MorphBallBomb        = 0x03FDA58A,
        SpiderBall           = 0x06F58B9C,
        LightningArmor       = 0x7D145810,
        VariaSuit            = 0xF7E06C74,
        WaveBeam             = 0x8E7272BA,
        BeamBurst            = 0x5CBD3A2B,
        GrappleBeam          = 0xCBB372C9,
        SpazerBeam           = 0xCB790519,
        PhaseDrift           = 0x4871DBB7,
        PlasmaBeam           = 0xD55B9714,
        GravitySuit          = 0x999DACAD,
        BabyMetroid          = 0xE6E8ECB4,

        #endregion Inventory

        #region Items Collected (By Area)

        Surface              = 0x1F6E32DA,
        Area1                = 0x1DD4CC59,
        Area2                = 0x9A3461E1,
        Area3                = 0xE7940589,
        Area4                = 0xD5F34B4B,
        Area5                = 0x2FB3829B,
        Area6                = 0x5213E6F3,
        Area7                = 0x77DB0BAC,
        Area8                = 0xDED6C283,

        #endregion Items Collected (By Area)

        #region Metroids Killed (By Type)

        AlphaMetroids        = 0x91E9DEEE,
        GammaMetroids        = 0x8A007DFA,
        ZetaMetroids         = 0xD22BF145,
        OmegaMetroids        = 0xC14D2774,
        NormalMetroids       = 0x7B7D796F,
        MetroidQueen         = 0x4164D39C

        #endregion Metroids Killed (By Type)

        #endregion Common
    }
}