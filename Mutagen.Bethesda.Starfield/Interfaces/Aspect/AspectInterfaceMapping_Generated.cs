/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Plugins.Aspects;
using Loqui;

namespace Mutagen.Bethesda.Starfield
{
    internal class StarfieldAspectInterfaceMapping : IInterfaceMapping
    {
        public IReadOnlyDictionary<Type, InterfaceMappingResult> InterfaceToObjectTypes { get; }

        public GameCategory GameCategory => GameCategory.Starfield;

        public StarfieldAspectInterfaceMapping()
        {
            var dict = new Dictionary<Type, InterfaceMappingResult>();
            dict[typeof(IHaveVirtualMachineAdapterGetter)] = new InterfaceMappingResult(false, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                APlacedTrap_Registration.Instance,
                Armor_Registration.Instance,
                Book_Registration.Instance,
                Container_Registration.Instance,
                DialogResponses_Registration.Instance,
                GenericBaseForm_Registration.Instance,
                LeveledItem_Registration.Instance,
                MagicEffect_Registration.Instance,
                MiscItem_Registration.Instance,
                NavigationMesh_Registration.Instance,
                Npc_Registration.Instance,
                Package_Registration.Instance,
                Perk_Registration.Instance,
                PlacedArrow_Registration.Instance,
                PlacedBarrier_Registration.Instance,
                PlacedBeam_Registration.Instance,
                PlacedCone_Registration.Instance,
                PlacedFlame_Registration.Instance,
                PlacedHazard_Registration.Instance,
                PlacedMissile_Registration.Instance,
                PlacedNpc_Registration.Instance,
                PlacedObject_Registration.Instance,
                PlacedTrap_Registration.Instance,
                Quest_Registration.Instance,
                Scene_Registration.Instance,
                TerminalMenu_Registration.Instance,
                Weapon_Registration.Instance,
            });
            dict[typeof(IKeywordCommon)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Keyword_Registration.Instance,
            });
            dict[typeof(IKeywordCommonGetter)] = dict[typeof(IKeywordCommon)] with { Setter = false };
            dict[typeof(IKeyworded<IKeywordGetter>)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                Armor_Registration.Instance,
                Book_Registration.Instance,
                Container_Registration.Instance,
                Ingestible_Registration.Instance,
                KeywordFormComponent_Registration.Instance,
                Location_Registration.Instance,
                MagicEffect_Registration.Instance,
                MiscItem_Registration.Instance,
                Npc_Registration.Instance,
                ObjectTemplate_Registration.Instance,
                Quest_Registration.Instance,
                QuestReferenceAlias_Registration.Instance,
                Race_Registration.Instance,
                Resource_Registration.Instance,
                SoundMarker_Registration.Instance,
                Spell_Registration.Instance,
                Weapon_Registration.Instance,
                Weather_Registration.Instance,
            });
            dict[typeof(IKeywordedGetter<IKeywordGetter>)] = dict[typeof(IKeyworded<IKeywordGetter>)] with { Setter = false };
            dict[typeof(IModeled)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                AnimatedObject_Registration.Instance,
                AObjectModification_Registration.Instance,
                ArmorModification_Registration.Instance,
                BodyData_Registration.Instance,
                Book_Registration.Instance,
                Container_Registration.Instance,
                ContainerModification_Registration.Instance,
                DestructionStage_Registration.Instance,
                FloraModification_Registration.Instance,
                HeadPart_Registration.Instance,
                Ingestible_Registration.Instance,
                LegendaryItem_Registration.Instance,
                LeveledItem_Registration.Instance,
                MiscItem_Registration.Instance,
                ModelComponent_Registration.Instance,
                NpcModification_Registration.Instance,
                ObjectModification_Registration.Instance,
                PlanetModelComponent_Registration.Instance,
                SkeletalModel_Registration.Instance,
                StaticCollection_Registration.Instance,
                UnknownObjectModification_Registration.Instance,
                Weapon_Registration.Instance,
                WeaponModification_Registration.Instance,
            });
            dict[typeof(IModeledGetter)] = dict[typeof(IModeled)] with { Setter = false };
            dict[typeof(INamed)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                Activity_Registration.Instance,
                AObjectModification_Registration.Instance,
                APackageData_Registration.Instance,
                Armor_Registration.Instance,
                ArmorModification_Registration.Instance,
                Book_Registration.Instance,
                Cell_Registration.Instance,
                Class_Registration.Instance,
                Container_Registration.Instance,
                ContainerModification_Registration.Instance,
                DamageType_Registration.Instance,
                DialogTopic_Registration.Instance,
                FaceMorphPhenotype_Registration.Instance,
                FaceMorphPhenotypeItem_Registration.Instance,
                Faction_Registration.Instance,
                FloraModification_Registration.Instance,
                FormList_Registration.Instance,
                FullNameComponent_Registration.Instance,
                HeadPart_Registration.Instance,
                Ingestible_Registration.Instance,
                Keyword_Registration.Instance,
                Location_Registration.Instance,
                MagicEffect_Registration.Instance,
                MiscItem_Registration.Instance,
                MorphGroup_Registration.Instance,
                Npc_Registration.Instance,
                NpcModification_Registration.Instance,
                ObjectEffect_Registration.Instance,
                ObjectModification_Registration.Instance,
                ObjectTemplate_Registration.Instance,
                PackageDataBool_Registration.Instance,
                PackageDataFloat_Registration.Instance,
                PackageDataInt_Registration.Instance,
                PackageDataLocation_Registration.Instance,
                PackageDataObjectList_Registration.Instance,
                PackageDataScene_Registration.Instance,
                PackageDataTarget_Registration.Instance,
                PackageDataTopic_Registration.Instance,
                Perk_Registration.Instance,
                Planet_Registration.Instance,
                ProgressionEvaluatorArgument_Registration.Instance,
                Quest_Registration.Instance,
                Race_Registration.Instance,
                Resource_Registration.Instance,
                ScenePhase_Registration.Instance,
                Spell_Registration.Instance,
                StaticCollection_Registration.Instance,
                TerminalMenu_Registration.Instance,
                UnknownObjectModification_Registration.Instance,
                Weapon_Registration.Instance,
                WeaponModification_Registration.Instance,
                Worldspace_Registration.Instance,
            });
            dict[typeof(INamedGetter)] = dict[typeof(INamed)] with { Setter = false };
            dict[typeof(INamedRequired)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                Activity_Registration.Instance,
                ActorValueModulation_Registration.Instance,
                AnimationSceneAction_Registration.Instance,
                AObjectModification_Registration.Instance,
                APackageData_Registration.Instance,
                Armor_Registration.Instance,
                ArmorModification_Registration.Instance,
                ASceneAction_Registration.Instance,
                BipedObjectData_Registration.Instance,
                BlueprintComponentBODSItem_Registration.Instance,
                Book_Registration.Instance,
                CameraSceneAction_Registration.Instance,
                Cell_Registration.Instance,
                Class_Registration.Instance,
                Container_Registration.Instance,
                ContainerModification_Registration.Instance,
                DamageType_Registration.Instance,
                DialogTopic_Registration.Instance,
                DialogueSceneAction_Registration.Instance,
                ExternalDataSource_Registration.Instance,
                FaceMorphPhenotype_Registration.Instance,
                FaceMorphPhenotypeItem_Registration.Instance,
                Faction_Registration.Instance,
                FloraModification_Registration.Instance,
                FormList_Registration.Instance,
                FullNameComponent_Registration.Instance,
                FxSceneAction_Registration.Instance,
                HeadPart_Registration.Instance,
                Ingestible_Registration.Instance,
                Keyword_Registration.Instance,
                Location_Registration.Instance,
                MagicEffect_Registration.Instance,
                MiscItem_Registration.Instance,
                MorphGroup_Registration.Instance,
                MoveSceneAction_Registration.Instance,
                Npc_Registration.Instance,
                NpcModification_Registration.Instance,
                ObjectEffect_Registration.Instance,
                ObjectModification_Registration.Instance,
                ObjectTemplate_Registration.Instance,
                PackageDataBool_Registration.Instance,
                PackageDataFloat_Registration.Instance,
                PackageDataInt_Registration.Instance,
                PackageDataLocation_Registration.Instance,
                PackageDataObjectList_Registration.Instance,
                PackageDataScene_Registration.Instance,
                PackageDataTarget_Registration.Instance,
                PackageDataTopic_Registration.Instance,
                PackageSceneAction_Registration.Instance,
                Perk_Registration.Instance,
                PlacedObjectMapMarker_Registration.Instance,
                Planet_Registration.Instance,
                PlayerDialogueSceneAction_Registration.Instance,
                ProgressionEvaluatorArgument_Registration.Instance,
                Quest_Registration.Instance,
                QuestLocationAlias_Registration.Instance,
                QuestReferenceAlias_Registration.Instance,
                Race_Registration.Instance,
                RadioSceneAction_Registration.Instance,
                Resource_Registration.Instance,
                ScenePhase_Registration.Instance,
                ScriptBoolListProperty_Registration.Instance,
                ScriptBoolProperty_Registration.Instance,
                ScriptEntry_Registration.Instance,
                ScriptFloatListProperty_Registration.Instance,
                ScriptFloatProperty_Registration.Instance,
                ScriptIntListProperty_Registration.Instance,
                ScriptIntProperty_Registration.Instance,
                ScriptObjectListProperty_Registration.Instance,
                ScriptObjectProperty_Registration.Instance,
                ScriptProperty_Registration.Instance,
                ScriptStringListProperty_Registration.Instance,
                ScriptStringProperty_Registration.Instance,
                ScriptStructListProperty_Registration.Instance,
                ScriptStructProperty_Registration.Instance,
                ScriptVariableListProperty_Registration.Instance,
                ScriptVariableProperty_Registration.Instance,
                Spell_Registration.Instance,
                StartSceneAction_Registration.Instance,
                StaticCollection_Registration.Instance,
                TerminalMenu_Registration.Instance,
                TimelineSceneAction_Registration.Instance,
                TimerSceneAction_Registration.Instance,
                UnknownObjectModification_Registration.Instance,
                Weapon_Registration.Instance,
                WeaponModification_Registration.Instance,
                Worldspace_Registration.Instance,
            });
            dict[typeof(INamedRequiredGetter)] = dict[typeof(INamedRequired)] with { Setter = false };
            dict[typeof(ITranslatedNamed)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                Activity_Registration.Instance,
                AObjectModification_Registration.Instance,
                Armor_Registration.Instance,
                ArmorModification_Registration.Instance,
                Book_Registration.Instance,
                Cell_Registration.Instance,
                Class_Registration.Instance,
                Container_Registration.Instance,
                ContainerModification_Registration.Instance,
                DamageType_Registration.Instance,
                DialogTopic_Registration.Instance,
                FaceMorphPhenotype_Registration.Instance,
                FaceMorphPhenotypeItem_Registration.Instance,
                Faction_Registration.Instance,
                FloraModification_Registration.Instance,
                FormList_Registration.Instance,
                FullNameComponent_Registration.Instance,
                HeadPart_Registration.Instance,
                Ingestible_Registration.Instance,
                Keyword_Registration.Instance,
                Location_Registration.Instance,
                MagicEffect_Registration.Instance,
                MiscItem_Registration.Instance,
                Npc_Registration.Instance,
                NpcModification_Registration.Instance,
                ObjectEffect_Registration.Instance,
                ObjectModification_Registration.Instance,
                ObjectTemplate_Registration.Instance,
                Perk_Registration.Instance,
                Quest_Registration.Instance,
                Race_Registration.Instance,
                Resource_Registration.Instance,
                Spell_Registration.Instance,
                StaticCollection_Registration.Instance,
                TerminalMenu_Registration.Instance,
                UnknownObjectModification_Registration.Instance,
                Weapon_Registration.Instance,
                WeaponModification_Registration.Instance,
                Worldspace_Registration.Instance,
            });
            dict[typeof(ITranslatedNamedGetter)] = dict[typeof(ITranslatedNamed)] with { Setter = false };
            dict[typeof(ITranslatedNamedRequired)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                Activity_Registration.Instance,
                AObjectModification_Registration.Instance,
                Armor_Registration.Instance,
                ArmorModification_Registration.Instance,
                Book_Registration.Instance,
                Cell_Registration.Instance,
                Class_Registration.Instance,
                Container_Registration.Instance,
                ContainerModification_Registration.Instance,
                DamageType_Registration.Instance,
                DialogTopic_Registration.Instance,
                FaceMorphPhenotype_Registration.Instance,
                FaceMorphPhenotypeItem_Registration.Instance,
                Faction_Registration.Instance,
                FloraModification_Registration.Instance,
                FormList_Registration.Instance,
                FullNameComponent_Registration.Instance,
                HeadPart_Registration.Instance,
                Ingestible_Registration.Instance,
                Keyword_Registration.Instance,
                Location_Registration.Instance,
                MagicEffect_Registration.Instance,
                MiscItem_Registration.Instance,
                Npc_Registration.Instance,
                NpcModification_Registration.Instance,
                ObjectEffect_Registration.Instance,
                ObjectModification_Registration.Instance,
                ObjectTemplate_Registration.Instance,
                Perk_Registration.Instance,
                PlacedObjectMapMarker_Registration.Instance,
                Quest_Registration.Instance,
                Race_Registration.Instance,
                Resource_Registration.Instance,
                Spell_Registration.Instance,
                StaticCollection_Registration.Instance,
                TerminalMenu_Registration.Instance,
                UnknownObjectModification_Registration.Instance,
                Weapon_Registration.Instance,
                WeaponModification_Registration.Instance,
                Worldspace_Registration.Instance,
            });
            dict[typeof(ITranslatedNamedRequiredGetter)] = dict[typeof(ITranslatedNamedRequired)] with { Setter = false };
            dict[typeof(IObjectBounded)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                AcousticSpace_Registration.Instance,
                Activator_Registration.Instance,
                Armor_Registration.Instance,
                AudioOcclusionPrimitive_Registration.Instance,
                Book_Registration.Instance,
                Container_Registration.Instance,
                GenericBaseForm_Registration.Instance,
                Ingestible_Registration.Instance,
                LeveledItem_Registration.Instance,
                MiscItem_Registration.Instance,
                Npc_Registration.Instance,
                ObjectEffect_Registration.Instance,
                ProjectedDecal_Registration.Instance,
                SoundEchoMarker_Registration.Instance,
                SoundMarker_Registration.Instance,
                Spell_Registration.Instance,
                StaticCollection_Registration.Instance,
                TextureSet_Registration.Instance,
                Weapon_Registration.Instance,
            });
            dict[typeof(IObjectBoundedGetter)] = dict[typeof(IObjectBounded)] with { Setter = false };
            dict[typeof(IObjectBoundedOptional)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                BendableSpline_Registration.Instance,
                LegendaryItem_Registration.Instance,
            });
            dict[typeof(IObjectBoundedOptionalGetter)] = dict[typeof(IObjectBoundedOptional)] with { Setter = false };
            dict[typeof(IPositionRotation)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                APlacedTrap_Registration.Instance,
                BlueprintComponentItem_Registration.Instance,
                PlacedArrow_Registration.Instance,
                PlacedBarrier_Registration.Instance,
                PlacedBeam_Registration.Instance,
                PlacedCone_Registration.Instance,
                PlacedFlame_Registration.Instance,
                PlacedHazard_Registration.Instance,
                PlacedMissile_Registration.Instance,
                PlacedNpc_Registration.Instance,
                PlacedObject_Registration.Instance,
                PlacedTrap_Registration.Instance,
                RagdollData_Registration.Instance,
                StaticPlacement_Registration.Instance,
                TeleportDestination_Registration.Instance,
                Transform_Registration.Instance,
            });
            dict[typeof(IPositionRotationGetter)] = dict[typeof(IPositionRotation)] with { Setter = false };
            dict[typeof(IScripted)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Activator_Registration.Instance,
                APlacedTrap_Registration.Instance,
                Armor_Registration.Instance,
                Book_Registration.Instance,
                Container_Registration.Instance,
                GenericBaseForm_Registration.Instance,
                LeveledItem_Registration.Instance,
                MagicEffect_Registration.Instance,
                MiscItem_Registration.Instance,
                NavigationMesh_Registration.Instance,
                Npc_Registration.Instance,
                PlacedArrow_Registration.Instance,
                PlacedBarrier_Registration.Instance,
                PlacedBeam_Registration.Instance,
                PlacedCone_Registration.Instance,
                PlacedFlame_Registration.Instance,
                PlacedHazard_Registration.Instance,
                PlacedMissile_Registration.Instance,
                PlacedNpc_Registration.Instance,
                PlacedObject_Registration.Instance,
                PlacedTrap_Registration.Instance,
                Weapon_Registration.Instance,
            });
            dict[typeof(IScriptedGetter)] = dict[typeof(IScripted)] with { Setter = false };
            dict[typeof(IWeightValue)] = new InterfaceMappingResult(true, new ILoquiRegistration[]
            {
                Book_Registration.Instance,
                Ingestible_Registration.Instance,
            });
            dict[typeof(IWeightValueGetter)] = dict[typeof(IWeightValue)] with { Setter = false };
            InterfaceToObjectTypes = dict;
        }
    }
}

