/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Loqui;

namespace Mutagen.Bethesda.Starfield;

internal class StarfieldLinkInterfaceMapping : IInterfaceMapping
{
    public IReadOnlyDictionary<Type, InterfaceMappingResult> InterfaceToObjectTypes { get; }

    public GameCategory GameCategory => GameCategory.Starfield;

    public StarfieldLinkInterfaceMapping()
    {
        var dict = new Dictionary<Type, InterfaceMappingResult>();
        dict[typeof(IIdleRelation)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            ActionRecord_Registration.Instance,
        });
        dict[typeof(IIdleRelationGetter)] = dict[typeof(IIdleRelation)] with { Setter = false };
        dict[typeof(IConstructible)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            ActionRecord_Registration.Instance,
            Activator_Registration.Instance,
            Ammunition_Registration.Instance,
            Armor_Registration.Instance,
            Book_Registration.Instance,
            Container_Registration.Instance,
            FormList_Registration.Instance,
            Furniture_Registration.Instance,
            GenericBaseForm_Registration.Instance,
            Ingestible_Registration.Instance,
            LeveledItem_Registration.Instance,
            MiscItem_Registration.Instance,
            MoveableStatic_Registration.Instance,
            Npc_Registration.Instance,
            PackIn_Registration.Instance,
            Static_Registration.Instance,
            Terminal_Registration.Instance,
            Weapon_Registration.Instance,
        });
        dict[typeof(IConstructibleGetter)] = dict[typeof(IConstructible)] with { Setter = false };
        dict[typeof(IStaticTarget)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Activator_Registration.Instance,
            Ammunition_Registration.Instance,
            Book_Registration.Instance,
            Container_Registration.Instance,
            Door_Registration.Instance,
            Flora_Registration.Instance,
            Furniture_Registration.Instance,
            Ingestible_Registration.Instance,
            MiscItem_Registration.Instance,
            MoveableStatic_Registration.Instance,
            Static_Registration.Instance,
            Terminal_Registration.Instance,
            Weapon_Registration.Instance,
        });
        dict[typeof(IStaticTargetGetter)] = dict[typeof(IStaticTarget)] with { Setter = false };
        dict[typeof(IItem)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Activator_Registration.Instance,
            Ammunition_Registration.Instance,
            Armor_Registration.Instance,
            Book_Registration.Instance,
            Container_Registration.Instance,
            Flora_Registration.Instance,
            Ingestible_Registration.Instance,
            Key_Registration.Instance,
            LegendaryItem_Registration.Instance,
            LeveledItem_Registration.Instance,
            MiscItem_Registration.Instance,
            MoveableStatic_Registration.Instance,
            ProjectedDecal_Registration.Instance,
            Static_Registration.Instance,
            Weapon_Registration.Instance,
        });
        dict[typeof(IItemGetter)] = dict[typeof(IItem)] with { Setter = false };
        dict[typeof(IOutfitTarget)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Armor_Registration.Instance,
            LeveledItem_Registration.Instance,
        });
        dict[typeof(IOutfitTargetGetter)] = dict[typeof(IOutfitTarget)] with { Setter = false };
        dict[typeof(IBindableEquipment)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Armor_Registration.Instance,
            Weapon_Registration.Instance,
        });
        dict[typeof(IBindableEquipmentGetter)] = dict[typeof(IBindableEquipment)] with { Setter = false };
        dict[typeof(INpcTemplateTarget)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            BiomeMarker_Registration.Instance,
            LeveledNpc_Registration.Instance,
            Npc_Registration.Instance,
        });
        dict[typeof(INpcTemplateTargetGetter)] = dict[typeof(INpcTemplateTarget)] with { Setter = false };
        dict[typeof(IComplexLocation)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Cell_Registration.Instance,
            Worldspace_Registration.Instance,
        });
        dict[typeof(IComplexLocationGetter)] = dict[typeof(IComplexLocation)] with { Setter = false };
        dict[typeof(IResourceTarget)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            ConstructibleObject_Registration.Instance,
            LeveledItem_Registration.Instance,
        });
        dict[typeof(IResourceTargetGetter)] = dict[typeof(IResourceTarget)] with { Setter = false };
        dict[typeof(IOwner)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Faction_Registration.Instance,
            Npc_Registration.Instance,
            PlacedNpc_Registration.Instance,
        });
        dict[typeof(IOwnerGetter)] = dict[typeof(IOwner)] with { Setter = false };
        dict[typeof(IObjectId)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Faction_Registration.Instance,
            TextureSet_Registration.Instance,
        });
        dict[typeof(IObjectIdGetter)] = dict[typeof(IObjectId)] with { Setter = false };
        dict[typeof(IRelatable)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Faction_Registration.Instance,
            Race_Registration.Instance,
        });
        dict[typeof(IRelatableGetter)] = dict[typeof(IRelatable)] with { Setter = false };
        dict[typeof(IAliasVoiceType)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Faction_Registration.Instance,
        });
        dict[typeof(IAliasVoiceTypeGetter)] = dict[typeof(IAliasVoiceType)] with { Setter = false };
        dict[typeof(IVoiceTypeOrList)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            FormList_Registration.Instance,
            VoiceType_Registration.Instance,
        });
        dict[typeof(IVoiceTypeOrListGetter)] = dict[typeof(IVoiceTypeOrList)] with { Setter = false };
        dict[typeof(IExternalBaseTemplate)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            GenericBaseForm_Registration.Instance,
            LeveledBaseForm_Registration.Instance,
        });
        dict[typeof(IExternalBaseTemplateGetter)] = dict[typeof(IExternalBaseTemplate)] with { Setter = false };
        dict[typeof(ILeveledBaseFormTarget)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            GenericBaseForm_Registration.Instance,
            LeveledBaseForm_Registration.Instance,
        });
        dict[typeof(ILeveledBaseFormTargetGetter)] = dict[typeof(ILeveledBaseFormTarget)] with { Setter = false };
        dict[typeof(IKeywordLinkedReference)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Keyword_Registration.Instance,
            PlacedNpc_Registration.Instance,
            PlacedObject_Registration.Instance,
            APlacedTrap_Registration.Instance,
        });
        dict[typeof(IKeywordLinkedReferenceGetter)] = dict[typeof(IKeywordLinkedReference)] with { Setter = false };
        dict[typeof(INpcSpawn)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            LeveledNpc_Registration.Instance,
            Npc_Registration.Instance,
        });
        dict[typeof(INpcSpawnGetter)] = dict[typeof(INpcSpawn)] with { Setter = false };
        dict[typeof(ILeveledPackInTarget)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            LeveledPackIn_Registration.Instance,
            PackIn_Registration.Instance,
        });
        dict[typeof(ILeveledPackInTargetGetter)] = dict[typeof(ILeveledPackInTarget)] with { Setter = false };
        dict[typeof(IEmittance)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Light_Registration.Instance,
            Region_Registration.Instance,
        });
        dict[typeof(IEmittanceGetter)] = dict[typeof(IEmittance)] with { Setter = false };
        dict[typeof(ILocationRecord)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            LocationReferenceType_Registration.Instance,
        });
        dict[typeof(ILocationRecordGetter)] = dict[typeof(ILocationRecord)] with { Setter = false };
        dict[typeof(IConstructibleObjectTarget)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            AObjectModification_Registration.Instance,
        });
        dict[typeof(IConstructibleObjectTargetGetter)] = dict[typeof(IConstructibleObjectTarget)] with { Setter = false };
        dict[typeof(IPlaced)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            PlacedNpc_Registration.Instance,
            PlacedObject_Registration.Instance,
            APlacedTrap_Registration.Instance,
        });
        dict[typeof(IPlacedGetter)] = dict[typeof(IPlaced)] with { Setter = false };
        dict[typeof(IPlacedSimple)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            PlacedNpc_Registration.Instance,
            PlacedObject_Registration.Instance,
        });
        dict[typeof(IPlacedSimpleGetter)] = dict[typeof(IPlacedSimple)] with { Setter = false };
        dict[typeof(ILinkedReference)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            PlacedNpc_Registration.Instance,
            PlacedObject_Registration.Instance,
            APlacedTrap_Registration.Instance,
        });
        dict[typeof(ILinkedReferenceGetter)] = dict[typeof(ILinkedReference)] with { Setter = false };
        dict[typeof(IPlacedThing)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            PlacedObject_Registration.Instance,
            APlacedTrap_Registration.Instance,
        });
        dict[typeof(IPlacedThingGetter)] = dict[typeof(IPlacedThing)] with { Setter = false };
        dict[typeof(ISpellRecord)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Spell_Registration.Instance,
        });
        dict[typeof(ISpellRecordGetter)] = dict[typeof(ISpellRecord)] with { Setter = false };
        dict[typeof(IEffectRecord)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            Spell_Registration.Instance,
        });
        dict[typeof(IEffectRecordGetter)] = dict[typeof(IEffectRecord)] with { Setter = false };
        dict[typeof(IPlaceableObject)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            TextureSet_Registration.Instance,
        });
        dict[typeof(IPlaceableObjectGetter)] = dict[typeof(IPlaceableObject)] with { Setter = false };
        dict[typeof(IReferenceableObject)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            TextureSet_Registration.Instance,
        });
        dict[typeof(IReferenceableObjectGetter)] = dict[typeof(IReferenceableObject)] with { Setter = false };
        dict[typeof(IExplodeSpawn)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
        {
            TextureSet_Registration.Instance,
        });
        dict[typeof(IExplodeSpawnGetter)] = dict[typeof(IExplodeSpawn)] with { Setter = false };
        InterfaceToObjectTypes = dict;
    }
}

