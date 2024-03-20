/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Loqui;

namespace Mutagen.Bethesda.Skyrim;

internal class SkyrimInheritingInterfaceMapping : IInterfaceMapping
{
    public IReadOnlyDictionary<Type, InterfaceMappingResult> InterfaceToObjectTypes { get; }

    public GameCategory GameCategory => GameCategory.Skyrim;

    public SkyrimInheritingInterfaceMapping()
    {
        var dict = new Dictionary<Type, InterfaceMappingResult>();
        dict[typeof(IGameSettingBool)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                GameSetting_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IGameSettingBool),
                Getter: typeof(IGameSettingBoolGetter)));
        dict[typeof(IGameSettingBoolGetter)] = dict[typeof(IGameSettingBool)] with { Setter = false };
        dict[typeof(IGameSettingFloat)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                GameSetting_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IGameSettingFloat),
                Getter: typeof(IGameSettingFloatGetter)));
        dict[typeof(IGameSettingFloatGetter)] = dict[typeof(IGameSettingFloat)] with { Setter = false };
        dict[typeof(IGameSettingInt)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                GameSetting_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IGameSettingInt),
                Getter: typeof(IGameSettingIntGetter)));
        dict[typeof(IGameSettingIntGetter)] = dict[typeof(IGameSettingInt)] with { Setter = false };
        dict[typeof(IGameSettingString)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                GameSetting_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IGameSettingString),
                Getter: typeof(IGameSettingStringGetter)));
        dict[typeof(IGameSettingStringGetter)] = dict[typeof(IGameSettingString)] with { Setter = false };
        dict[typeof(IGlobalFloat)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                Global_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IGlobalFloat),
                Getter: typeof(IGlobalFloatGetter)));
        dict[typeof(IGlobalFloatGetter)] = dict[typeof(IGlobalFloat)] with { Setter = false };
        dict[typeof(IGlobalInt)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                Global_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IGlobalInt),
                Getter: typeof(IGlobalIntGetter)));
        dict[typeof(IGlobalIntGetter)] = dict[typeof(IGlobalInt)] with { Setter = false };
        dict[typeof(IGlobalShort)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                Global_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IGlobalShort),
                Getter: typeof(IGlobalShortGetter)));
        dict[typeof(IGlobalShortGetter)] = dict[typeof(IGlobalShort)] with { Setter = false };
        dict[typeof(IGlobalUnknown)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                Global_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IGlobalUnknown),
                Getter: typeof(IGlobalUnknownGetter)));
        dict[typeof(IGlobalUnknownGetter)] = dict[typeof(IGlobalUnknown)] with { Setter = false };
        dict[typeof(IPlacedArrow)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                APlacedTrap_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IPlacedArrow),
                Getter: typeof(IPlacedArrowGetter)));
        dict[typeof(IPlacedArrowGetter)] = dict[typeof(IPlacedArrow)] with { Setter = false };
        dict[typeof(IPlacedBarrier)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                APlacedTrap_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IPlacedBarrier),
                Getter: typeof(IPlacedBarrierGetter)));
        dict[typeof(IPlacedBarrierGetter)] = dict[typeof(IPlacedBarrier)] with { Setter = false };
        dict[typeof(IPlacedBeam)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                APlacedTrap_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IPlacedBeam),
                Getter: typeof(IPlacedBeamGetter)));
        dict[typeof(IPlacedBeamGetter)] = dict[typeof(IPlacedBeam)] with { Setter = false };
        dict[typeof(IPlacedCone)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                APlacedTrap_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IPlacedCone),
                Getter: typeof(IPlacedConeGetter)));
        dict[typeof(IPlacedConeGetter)] = dict[typeof(IPlacedCone)] with { Setter = false };
        dict[typeof(IPlacedFlame)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                APlacedTrap_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IPlacedFlame),
                Getter: typeof(IPlacedFlameGetter)));
        dict[typeof(IPlacedFlameGetter)] = dict[typeof(IPlacedFlame)] with { Setter = false };
        dict[typeof(IPlacedHazard)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                APlacedTrap_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IPlacedHazard),
                Getter: typeof(IPlacedHazardGetter)));
        dict[typeof(IPlacedHazardGetter)] = dict[typeof(IPlacedHazard)] with { Setter = false };
        dict[typeof(IPlacedMissile)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                APlacedTrap_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IPlacedMissile),
                Getter: typeof(IPlacedMissileGetter)));
        dict[typeof(IPlacedMissileGetter)] = dict[typeof(IPlacedMissile)] with { Setter = false };
        dict[typeof(IPlacedTrap)] = new InterfaceMappingResult(
            true,
            new ILoquiRegistration[]
            {
                APlacedTrap_Registration.Instance,
            },
            new InterfaceMappingTypes(
                Setter: typeof(IPlacedTrap),
                Getter: typeof(IPlacedTrapGetter)));
        dict[typeof(IPlacedTrapGetter)] = dict[typeof(IPlacedTrap)] with { Setter = false };
        InterfaceToObjectTypes = dict;
    }
}

