﻿using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Noggog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutagen.Bethesda
{
    public partial interface IMajorRecord : IFormKey, IDuplicatable
    {
        new FormKey FormKey { get; }
    }

    [DebuggerDisplay("{GetType().Name} {this.EditorID?.ToString()} {this.FormKey.ToString()}")]
    public partial class MajorRecord : ILinkSubContainer
    {
        [Flags]
        public enum MajorRecordFlag
        {
            ESM = 0x00000001,
            Deleted = 0x00000020,
            BorderRegion_ActorValue = 0x00000040,
            TurnOffFire_ActorValue = 0x00000080,
            CastsShadows = 0x00000200,
            QuestItemPersistentReference = 0x00000400,
            InitiallyDisabled = 0x00000800,
            Ignored = 0x00001000,
            VisibleWhenDistant = 0x00008000,
            Dangerous_OffLimits_InteriorCell = 0x00020000,
            Compressed = 0x00040000,
            CantWait = 0x00080000,
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public string TitleString => $"{this.EditorID} - {this.FormKey.ToString()}";

        public static void Fill_Binary(
            MutagenFrame frame,
            MajorRecord record,
            MasterReferences masterReferences,
            ErrorMaskBuilder errorMask)
        {
            Fill_Binary_Structs(
                record,
                frame,
                masterReferences,
                errorMask);
            for (int i = 0; i < MajorRecord_Registration.NumTypedFields; i++)
            {
                var nextRecordType = HeaderTranslation.GetNextSubRecordType(
                    frame.Reader,
                    contentLength: out var contentLength);
                var finalPos = frame.Position + contentLength;
                Fill_Binary_RecordTypes(
                    record,
                    frame,
                    nextRecordType,
                    contentLength,
                    masterReferences,
                    errorMask: errorMask);
                if (frame.Position < finalPos)
                {
                    frame.Position = finalPos;
                }
            }
        }

        internal void SetFormKey(FormKey formKey)
        {
            this.FormKey = formKey;
        }

        object IDuplicatable.Duplicate(Func<FormKey> getNextFormKey, IList<(MajorRecord Record, FormKey OriginalFormKey)> duplicatedRecordTracker)
        {
            return this.Duplicate(getNextFormKey, duplicatedRecordTracker);
        }
    }

    public static class MajorRecordExt
    {
        public static T Duplicate<T>(this T maj, FormKey formKey)
            where T : MajorRecord, new()
        {
            var ret = new T();
            ret.CopyFieldsFrom(maj);
            ret.SetFormKey(formKey);
            return ret;
        }
    }
}
