/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Loqui;
using Noggog;
using Noggog.Notifying;
using Mutagen.Bethesda.Oblivion.Internals;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Internals;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using Noggog.Xml;
using Loqui.Xml;
using Loqui.Internal;
using System.Diagnostics;
using System.Collections.Specialized;
using Mutagen.Bethesda.Binary;

namespace Mutagen.Bethesda.Oblivion
{
    #region Class
    public abstract partial class Place : 
        MajorRecord,
        IPlace,
        ILoquiObject<Place>,
        ILoquiObjectSetter,
        IEquatable<Place>
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => Place_Registration.Instance;
        public new static Place_Registration Registration => Place_Registration.Instance;

        #region Ctor
        public Place()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region Loqui Getter Interface

        protected override object GetNthObject(ushort index) => PlaceCommon.GetNthObject(index, this);

        protected override bool GetNthObjectHasBeenSet(ushort index) => PlaceCommon.GetNthObjectHasBeenSet(index, this);

        protected override void UnsetNthObject(ushort index, NotifyingUnsetParameters cmds) => PlaceCommon.UnsetNthObject(index, this, cmds);

        #endregion

        #region Loqui Interface
        protected override void SetNthObjectHasBeenSet(ushort index, bool on)
        {
            PlaceCommon.SetNthObjectHasBeenSet(index, on, this);
        }

        #endregion

        IMask<bool> IEqualsMask<Place>.GetEqualsMask(Place rhs) => PlaceCommon.GetEqualsMask(this, rhs);
        IMask<bool> IEqualsMask<IPlaceGetter>.GetEqualsMask(IPlaceGetter rhs) => PlaceCommon.GetEqualsMask(this, rhs);
        #region To String
        public override string ToString()
        {
            return PlaceCommon.ToString(this, printMask: null);
        }

        public string ToString(
            string name = null,
            Place_Mask<bool> printMask = null)
        {
            return PlaceCommon.ToString(this, name: name, printMask: printMask);
        }

        public override void ToString(
            FileGeneration fg,
            string name = null)
        {
            PlaceCommon.ToString(this, fg, name: name, printMask: null);
        }

        #endregion

        IMask<bool> ILoquiObjectGetter.GetHasBeenSetMask() => this.GetHasBeenSetMask();
        public new Place_Mask<bool> GetHasBeenSetMask()
        {
            return PlaceCommon.GetHasBeenSetMask(this);
        }
        #region Equals and Hash
        public override bool Equals(object obj)
        {
            if (!(obj is Place rhs)) return false;
            return Equals(rhs);
        }

        public bool Equals(Place rhs)
        {
            if (rhs == null) return false;
            if (!base.Equals(rhs)) return false;
            return true;
        }

        public override int GetHashCode()
        {
            int ret = 0;
            ret = ret.CombineHashCode(base.GetHashCode());
            return ret;
        }

        #endregion


        #region Xml Translation
        #region Xml Copy In
        public override void CopyIn_Xml(
            XElement root,
            NotifyingFireParameters cmds = null)
        {
            CopyIn_Xml_Internal(
                root: root,
                errorMask: null,
                translationMask: null,
                cmds: cmds);
        }

        public virtual void CopyIn_Xml(
            XElement root,
            out Place_ErrorMask errorMask,
            Place_TranslationMask translationMask = null,
            bool doMasks = true,
            NotifyingFireParameters cmds = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            CopyIn_Xml_Internal(
                root: root,
                errorMask: errorMaskBuilder,
                translationMask: translationMask?.GetCrystal(),
                cmds: cmds);
            errorMask = Place_ErrorMask.Factory(errorMaskBuilder);
        }

        protected override void CopyIn_Xml_Internal(
            XElement root,
            ErrorMaskBuilder errorMask,
            TranslationCrystal translationMask,
            NotifyingFireParameters cmds = null)
        {
            LoquiXmlTranslation<Place>.Instance.CopyIn(
                root: root,
                item: this,
                skipProtected: true,
                errorMask: errorMask,
                translationMask: translationMask,
                cmds: cmds);
        }

        public void CopyIn_Xml(
            string path,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(path).Root;
            this.CopyIn_Xml(
                root: root,
                cmds: cmds);
        }

        public void CopyIn_Xml(
            string path,
            out Place_ErrorMask errorMask,
            Place_TranslationMask translationMask,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            var root = XDocument.Load(path).Root;
            this.CopyIn_Xml(
                root: root,
                errorMask: out errorMask,
                translationMask: translationMask,
                cmds: cmds,
                doMasks: doMasks);
        }

        public void CopyIn_Xml(
            Stream stream,
            NotifyingFireParameters cmds = null)
        {
            var root = XDocument.Load(stream).Root;
            this.CopyIn_Xml(
                root: root,
                cmds: cmds);
        }

        public void CopyIn_Xml(
            Stream stream,
            out Place_ErrorMask errorMask,
            Place_TranslationMask translationMask,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            var root = XDocument.Load(stream).Root;
            this.CopyIn_Xml(
                root: root,
                errorMask: out errorMask,
                translationMask: translationMask,
                cmds: cmds,
                doMasks: doMasks);
        }

        public override void CopyIn_Xml(
            XElement root,
            out MajorRecord_ErrorMask errorMask,
            MajorRecord_TranslationMask translationMask = null,
            bool doMasks = true,
            NotifyingFireParameters cmds = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            CopyIn_Xml_Internal(
                root: root,
                errorMask: errorMaskBuilder,
                translationMask: translationMask?.GetCrystal(),
                cmds: cmds);
            errorMask = Place_ErrorMask.Factory(errorMaskBuilder);
        }

        #endregion

        #region Xml Write
        public virtual void Write_Xml(
            XElement node,
            out Place_ErrorMask errorMask,
            bool doMasks = true,
            Place_TranslationMask translationMask = null,
            string name = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            this.Write_Xml_Internal(
                node: node,
                name: name,
                errorMask: errorMaskBuilder,
                translationMask: translationMask?.GetCrystal());
            errorMask = Place_ErrorMask.Factory(errorMaskBuilder);
        }

        public virtual void Write_Xml(
            string path,
            out Place_ErrorMask errorMask,
            Place_TranslationMask translationMask = null,
            bool doMasks = true,
            string name = null)
        {
            XElement topNode = new XElement("topnode");
            Write_Xml(
                node: topNode,
                name: name,
                errorMask: out errorMask,
                doMasks: doMasks,
                translationMask: translationMask);
            topNode.Elements().First().Save(path);
        }

        public virtual void Write_Xml(
            Stream stream,
            out Place_ErrorMask errorMask,
            Place_TranslationMask translationMask = null,
            bool doMasks = true,
            string name = null)
        {
            XElement topNode = new XElement("topnode");
            Write_Xml(
                node: topNode,
                name: name,
                errorMask: out errorMask,
                doMasks: doMasks,
                translationMask: translationMask);
            topNode.Elements().First().Save(stream);
        }

        #region Base Class Trickdown Overrides
        public override void Write_Xml(
            XElement node,
            out MajorRecord_ErrorMask errorMask,
            bool doMasks = true,
            MajorRecord_TranslationMask translationMask = null,
            string name = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            this.Write_Xml_Internal(
                node: node,
                name: name,
                errorMask: errorMaskBuilder,
                translationMask: translationMask?.GetCrystal());
            errorMask = Place_ErrorMask.Factory(errorMaskBuilder);
        }

        #endregion

        protected override void Write_Xml_Internal(
            XElement node,
            ErrorMaskBuilder errorMask,
            TranslationCrystal translationMask,
            string name = null)
        {
            PlaceCommon.Write_Xml(
                item: this,
                node: node,
                name: name,
                errorMask: errorMask,
                translationMask: translationMask);
        }
        #endregion

        protected static void Fill_Xml_Internal(
            Place item,
            XElement root,
            string name,
            ErrorMaskBuilder errorMask,
            TranslationCrystal translationMask)
        {
            switch (name)
            {
                default:
                    MajorRecord.Fill_Xml_Internal(
                        item: item,
                        root: root,
                        name: name,
                        errorMask: errorMask,
                        translationMask: translationMask);
                    break;
            }
        }

        #endregion

        #region Binary Translation
        #region Binary Write
        public virtual void Write_Binary(
            MutagenWriter writer,
            out Place_ErrorMask errorMask,
            bool doMasks = true)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            this.Write_Binary_Internal(
                writer: writer,
                recordTypeConverter: null,
                errorMask: errorMaskBuilder);
            errorMask = Place_ErrorMask.Factory(errorMaskBuilder);
        }

        public virtual void Write_Binary(
            string path,
            out Place_ErrorMask errorMask,
            bool doMasks = true)
        {
            using (var memStream = new MemoryTributary())
            {
                using (var writer = new MutagenWriter(memStream, dispose: false))
                {
                    Write_Binary(
                        writer: writer,
                        errorMask: out errorMask,
                        doMasks: doMasks);
                }
                using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    memStream.Position = 0;
                    memStream.CopyTo(fs);
                }
            }
        }

        public virtual void Write_Binary(
            Stream stream,
            out Place_ErrorMask errorMask,
            bool doMasks = true)
        {
            using (var writer = new MutagenWriter(stream))
            {
                Write_Binary(
                    writer: writer,
                    errorMask: out errorMask,
                    doMasks: doMasks);
            }
        }

        #region Base Class Trickdown Overrides
        public override void Write_Binary(
            MutagenWriter writer,
            out MajorRecord_ErrorMask errorMask,
            bool doMasks = true)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            this.Write_Binary_Internal(
                writer: writer,
                errorMask: errorMaskBuilder,
                recordTypeConverter: null);
            errorMask = Place_ErrorMask.Factory(errorMaskBuilder);
        }

        #endregion

        protected override void Write_Binary_Internal(
            MutagenWriter writer,
            RecordTypeConverter recordTypeConverter,
            ErrorMaskBuilder errorMask)
        {
            PlaceCommon.Write_Binary(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter,
                errorMask: errorMask);
        }
        #endregion

        #endregion

        public Place Copy(
            Place_CopyMask copyMask = null,
            IPlaceGetter def = null)
        {
            return Place.Copy(
                this,
                copyMask: copyMask,
                def: def);
        }

        public static Place Copy(
            IPlace item,
            Place_CopyMask copyMask = null,
            IPlaceGetter def = null)
        {
            Place ret = (Place)System.Activator.CreateInstance(item.GetType());
            ret.CopyFieldsFrom(
                item,
                copyMask: copyMask,
                def: def);
            return ret;
        }

        public static Place Copy_ToLoqui(
            IPlaceGetter item,
            Place_CopyMask copyMask = null,
            IPlaceGetter def = null)
        {
            Place ret = (Place)System.Activator.CreateInstance(item.GetType());
            ret.CopyFieldsFrom(
                item,
                copyMask: copyMask,
                def: def);
            return ret;
        }

        public void CopyFieldsFrom(
            IPlaceGetter rhs,
            Place_CopyMask copyMask,
            IPlaceGetter def = null,
            NotifyingFireParameters cmds = null)
        {
            this.CopyFieldsFrom(
                rhs: rhs,
                def: def,
                doMasks: false,
                errorMask: out var errMask,
                copyMask: copyMask,
                cmds: cmds);
        }

        public void CopyFieldsFrom(
            IPlaceGetter rhs,
            out Place_ErrorMask errorMask,
            Place_CopyMask copyMask = null,
            IPlaceGetter def = null,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            PlaceCommon.CopyFieldsFrom(
                item: this,
                rhs: rhs,
                def: def,
                errorMask: errorMaskBuilder,
                copyMask: copyMask,
                cmds: cmds);
            errorMask = Place_ErrorMask.Factory(errorMaskBuilder);
        }

        public void CopyFieldsFrom(
            IPlaceGetter rhs,
            ErrorMaskBuilder errorMask,
            Place_CopyMask copyMask = null,
            IPlaceGetter def = null,
            NotifyingFireParameters cmds = null,
            bool doMasks = true)
        {
            PlaceCommon.CopyFieldsFrom(
                item: this,
                rhs: rhs,
                def: def,
                errorMask: errorMask,
                copyMask: copyMask,
                cmds: cmds);
        }

        protected override void SetNthObject(ushort index, object obj, NotifyingFireParameters cmds = null)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    base.SetNthObject(index, obj, cmds);
                    break;
            }
        }

        public override void Clear(NotifyingUnsetParameters cmds = null)
        {
            CallClearPartial_Internal(cmds);
            PlaceCommon.Clear(this, cmds);
        }


        protected new static void CopyInInternal_Place(Place obj, KeyValuePair<ushort, object> pair)
        {
            if (!EnumExt.TryParse(pair.Key, out Place_FieldIndex enu))
            {
                CopyInInternal_MajorRecord(obj, pair);
            }
            switch (enu)
            {
                default:
                    throw new ArgumentException($"Unknown enum type: {enu}");
            }
        }
        public static void CopyIn(IEnumerable<KeyValuePair<ushort, object>> fields, Place obj)
        {
            ILoquiObjectExt.CopyFieldsIn(obj, fields, def: null, skipProtected: false, cmds: null);
        }

    }
    #endregion

    #region Interface
    public partial interface IPlace : IPlaceGetter, IMajorRecord, ILoquiClass<IPlace, IPlaceGetter>, ILoquiClass<Place, IPlaceGetter>
    {
    }

    public partial interface IPlaceGetter : IMajorRecordGetter
    {

    }

    #endregion

}

namespace Mutagen.Bethesda.Oblivion.Internals
{
    #region Field Index
    public enum Place_FieldIndex
    {
        MajorRecordFlags = 0,
        FormID = 1,
        Version = 2,
        EditorID = 3,
        RecordType = 4,
    }
    #endregion

    #region Registration
    public class Place_Registration : ILoquiRegistration
    {
        public static readonly Place_Registration Instance = new Place_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Oblivion.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Oblivion.ProtocolKey,
            msgID: 163,
            version: 0);

        public const string GUID = "9413b2c4-8392-4e96-8cb2-374ab5e65bbf";

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 5;

        public static readonly Type MaskType = typeof(Place_Mask<>);

        public static readonly Type ErrorMaskType = typeof(Place_ErrorMask);

        public static readonly Type ClassType = typeof(Place);

        public static readonly Type GetterType = typeof(IPlaceGetter);

        public static readonly Type SetterType = typeof(IPlace);

        public static readonly Type CommonType = typeof(PlaceCommon);

        public const string FullName = "Mutagen.Bethesda.Oblivion.Place";

        public const string Name = "Place";

        public const string Namespace = "Mutagen.Bethesda.Oblivion";

        public const byte GenericCount = 0;

        public static readonly Type GenericRegistrationType = null;

        public static ushort? GetNameIndex(StringCaseAgnostic str)
        {
            switch (str.Upper)
            {
                default:
                    return null;
            }
        }

        public static bool GetNthIsEnumerable(ushort index)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.GetNthIsEnumerable(index);
            }
        }

        public static bool GetNthIsLoqui(ushort index)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.GetNthIsLoqui(index);
            }
        }

        public static bool GetNthIsSingleton(ushort index)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.GetNthIsSingleton(index);
            }
        }

        public static string GetNthName(ushort index)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.GetNthName(index);
            }
        }

        public static bool IsNthDerivative(ushort index)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.IsNthDerivative(index);
            }
        }

        public static bool IsProtected(ushort index)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.IsProtected(index);
            }
        }

        public static Type GetNthType(ushort index)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecord_Registration.GetNthType(index);
            }
        }

        public static readonly RecordType CELL_HEADER = new RecordType("CELL");
        public static readonly RecordType WRLD_HEADER = new RecordType("WRLD");
        public static ICollectionGetter<RecordType> TriggeringRecordTypes => _TriggeringRecordTypes.Value;
        private static readonly Lazy<ICollectionGetter<RecordType>> _TriggeringRecordTypes = new Lazy<ICollectionGetter<RecordType>>(() =>
        {
            return new CollectionGetterWrapper<RecordType>(
                new HashSet<RecordType>(
                    new RecordType[]
                    {
                        CELL_HEADER,
                        WRLD_HEADER
                    })
            );
        });
        public const int NumStructFields = 0;
        public const int NumTypedFields = 0;
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
        ObjectKey ILoquiRegistration.ObjectKey => ObjectKey;
        string ILoquiRegistration.GUID => GUID;
        ushort ILoquiRegistration.FieldCount => FieldCount;
        ushort ILoquiRegistration.AdditionalFieldCount => AdditionalFieldCount;
        Type ILoquiRegistration.MaskType => MaskType;
        Type ILoquiRegistration.ErrorMaskType => ErrorMaskType;
        Type ILoquiRegistration.ClassType => ClassType;
        Type ILoquiRegistration.SetterType => SetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type ILoquiRegistration.CommonType => CommonType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => GetNameIndex(name);
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => GetNthIsEnumerable(index);
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => GetNthIsLoqui(index);
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => GetNthIsSingleton(index);
        string ILoquiRegistration.GetNthName(ushort index) => GetNthName(index);
        bool ILoquiRegistration.IsNthDerivative(ushort index) => IsNthDerivative(index);
        bool ILoquiRegistration.IsProtected(ushort index) => IsProtected(index);
        Type ILoquiRegistration.GetNthType(ushort index) => GetNthType(index);
        #endregion

    }
    #endregion

    #region Extensions
    public static partial class PlaceCommon
    {
        #region Copy Fields From
        public static void CopyFieldsFrom(
            IPlace item,
            IPlaceGetter rhs,
            IPlaceGetter def,
            ErrorMaskBuilder errorMask,
            Place_CopyMask copyMask,
            NotifyingFireParameters cmds = null)
        {
            MajorRecordCommon.CopyFieldsFrom(
                item,
                rhs,
                def,
                errorMask,
                copyMask,
                cmds);
        }

        #endregion

        public static void SetNthObjectHasBeenSet(
            ushort index,
            bool on,
            IPlace obj,
            NotifyingFireParameters cmds = null)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    MajorRecordCommon.SetNthObjectHasBeenSet(index, on, obj);
                    break;
            }
        }

        public static void UnsetNthObject(
            ushort index,
            IPlace obj,
            NotifyingUnsetParameters cmds = null)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    MajorRecordCommon.UnsetNthObject(index, obj);
                    break;
            }
        }

        public static bool GetNthObjectHasBeenSet(
            ushort index,
            IPlace obj)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecordCommon.GetNthObjectHasBeenSet(index, obj);
            }
        }

        public static object GetNthObject(
            ushort index,
            IPlaceGetter obj)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    return MajorRecordCommon.GetNthObject(index, obj);
            }
        }

        public static void Clear(
            IPlace item,
            NotifyingUnsetParameters cmds = null)
        {
        }

        public static Place_Mask<bool> GetEqualsMask(
            this IPlaceGetter item,
            IPlaceGetter rhs)
        {
            var ret = new Place_Mask<bool>();
            FillEqualsMask(item, rhs, ret);
            return ret;
        }

        public static void FillEqualsMask(
            IPlaceGetter item,
            IPlaceGetter rhs,
            Place_Mask<bool> ret)
        {
            if (rhs == null) return;
            MajorRecordCommon.FillEqualsMask(item, rhs, ret);
        }

        public static string ToString(
            this IPlaceGetter item,
            string name = null,
            Place_Mask<bool> printMask = null)
        {
            var fg = new FileGeneration();
            item.ToString(fg, name, printMask);
            return fg.ToString();
        }

        public static void ToString(
            this IPlaceGetter item,
            FileGeneration fg,
            string name = null,
            Place_Mask<bool> printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"{nameof(Place)} =>");
            }
            else
            {
                fg.AppendLine($"{name} ({nameof(Place)}) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
            }
            fg.AppendLine("]");
        }

        public static bool HasBeenSet(
            this IPlaceGetter item,
            Place_Mask<bool?> checkMask)
        {
            return true;
        }

        public static Place_Mask<bool> GetHasBeenSetMask(IPlaceGetter item)
        {
            var ret = new Place_Mask<bool>();
            return ret;
        }

        public static Place_FieldIndex? ConvertFieldIndex(MajorRecord_FieldIndex? index)
        {
            if (!index.HasValue) return null;
            return ConvertFieldIndex(index: index.Value);
        }

        public static Place_FieldIndex ConvertFieldIndex(MajorRecord_FieldIndex index)
        {
            switch (index)
            {
                case MajorRecord_FieldIndex.MajorRecordFlags:
                    return (Place_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.FormID:
                    return (Place_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.Version:
                    return (Place_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.EditorID:
                    return (Place_FieldIndex)((int)index);
                case MajorRecord_FieldIndex.RecordType:
                    return (Place_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }

        #region Xml Translation
        #region Xml Write
        public static void Write_Xml(
            XElement node,
            IPlaceGetter item,
            bool doMasks,
            out Place_ErrorMask errorMask,
            Place_TranslationMask translationMask,
            string name = null)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            Write_Xml(
                node: node,
                name: name,
                item: item,
                errorMask: errorMaskBuilder,
                translationMask: translationMask?.GetCrystal());
            errorMask = Place_ErrorMask.Factory(errorMaskBuilder);
        }

        public static void Write_Xml(
            XElement node,
            IPlaceGetter item,
            ErrorMaskBuilder errorMask,
            TranslationCrystal translationMask,
            string name = null)
        {
            var elem = new XElement(name ?? "Mutagen.Bethesda.Oblivion.Place");
            node.Add(elem);
            if (name != null)
            {
                elem.SetAttributeValue("type", "Mutagen.Bethesda.Oblivion.Place");
            }
        }
        #endregion

        #endregion

        #region Binary Translation
        #region Binary Write
        public static void Write_Binary(
            MutagenWriter writer,
            Place item,
            RecordTypeConverter recordTypeConverter,
            bool doMasks,
            out Place_ErrorMask errorMask)
        {
            ErrorMaskBuilder errorMaskBuilder = doMasks ? new ErrorMaskBuilder() : null;
            Write_Binary(
                writer: writer,
                item: item,
                recordTypeConverter: recordTypeConverter,
                errorMask: errorMaskBuilder);
            errorMask = Place_ErrorMask.Factory(errorMaskBuilder);
        }

        public static void Write_Binary(
            MutagenWriter writer,
            Place item,
            RecordTypeConverter recordTypeConverter,
            ErrorMaskBuilder errorMask)
        {
            MajorRecordCommon.Write_Binary_Embedded(
                item: item,
                writer: writer,
                errorMask: errorMask);
            MajorRecordCommon.Write_Binary_RecordTypes(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter,
                errorMask: errorMask);
        }
        #endregion

        #endregion

    }
    #endregion

    #region Modules

    #region Mask
    public class Place_Mask<T> : MajorRecord_Mask<T>, IMask<T>, IEquatable<Place_Mask<T>>
    {
        #region Ctors
        public Place_Mask()
        {
        }

        public Place_Mask(T initialValue)
        {
        }
        #endregion

        #region Equals
        public override bool Equals(object obj)
        {
            if (!(obj is Place_Mask<T> rhs)) return false;
            return Equals(rhs);
        }

        public bool Equals(Place_Mask<T> rhs)
        {
            if (rhs == null) return false;
            if (!base.Equals(rhs)) return false;
            return true;
        }
        public override int GetHashCode()
        {
            int ret = 0;
            ret = ret.CombineHashCode(base.GetHashCode());
            return ret;
        }

        #endregion

        #region All Equal
        public override bool AllEqual(Func<T, bool> eval)
        {
            if (!base.AllEqual(eval)) return false;
            return true;
        }
        #endregion

        #region Translate
        public new Place_Mask<R> Translate<R>(Func<T, R> eval)
        {
            var ret = new Place_Mask<R>();
            this.Translate_InternalFill(ret, eval);
            return ret;
        }

        protected void Translate_InternalFill<R>(Place_Mask<R> obj, Func<T, R> eval)
        {
            base.Translate_InternalFill(obj, eval);
        }
        #endregion

        #region Clear Enumerables
        public override void ClearEnumerables()
        {
            base.ClearEnumerables();
        }
        #endregion

        #region To String
        public override string ToString()
        {
            return ToString(printMask: null);
        }

        public string ToString(Place_Mask<bool> printMask = null)
        {
            var fg = new FileGeneration();
            ToString(fg, printMask);
            return fg.ToString();
        }

        public void ToString(FileGeneration fg, Place_Mask<bool> printMask = null)
        {
            fg.AppendLine($"{nameof(Place_Mask<T>)} =>");
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
            }
            fg.AppendLine("]");
        }
        #endregion

    }

    public class Place_ErrorMask : MajorRecord_ErrorMask, IErrorMask<Place_ErrorMask>
    {
        #region IErrorMask
        public override object GetNthMask(int index)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    return base.GetNthMask(index);
            }
        }

        public override void SetNthException(int index, Exception ex)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    base.SetNthException(index, ex);
                    break;
            }
        }

        public override void SetNthMask(int index, object obj)
        {
            Place_FieldIndex enu = (Place_FieldIndex)index;
            switch (enu)
            {
                default:
                    base.SetNthMask(index, obj);
                    break;
            }
        }

        public override bool IsInError()
        {
            if (Overall != null) return true;
            return false;
        }
        #endregion

        #region To String
        public override string ToString()
        {
            var fg = new FileGeneration();
            ToString(fg);
            return fg.ToString();
        }

        public override void ToString(FileGeneration fg)
        {
            fg.AppendLine("Place_ErrorMask =>");
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                if (this.Overall != null)
                {
                    fg.AppendLine("Overall =>");
                    fg.AppendLine("[");
                    using (new DepthWrapper(fg))
                    {
                        fg.AppendLine($"{this.Overall}");
                    }
                    fg.AppendLine("]");
                }
                ToString_FillInternal(fg);
            }
            fg.AppendLine("]");
        }
        protected override void ToString_FillInternal(FileGeneration fg)
        {
            base.ToString_FillInternal(fg);
        }
        #endregion

        #region Combine
        public Place_ErrorMask Combine(Place_ErrorMask rhs)
        {
            var ret = new Place_ErrorMask();
            return ret;
        }
        public static Place_ErrorMask Combine(Place_ErrorMask lhs, Place_ErrorMask rhs)
        {
            if (lhs != null && rhs != null) return lhs.Combine(rhs);
            return lhs ?? rhs;
        }
        #endregion

        #region Factory
        public static Place_ErrorMask Factory(ErrorMaskBuilder errorMask)
        {
            if (errorMask?.Empty ?? true) return null;
            return new Place_ErrorMask();
        }
        #endregion

    }
    public class Place_CopyMask : MajorRecord_CopyMask
    {
    }
    public class Place_TranslationMask : MajorRecord_TranslationMask
    {
        #region Members
        private TranslationCrystal _crystal;
        #endregion

        protected override void GetCrystal(List<(bool On, TranslationCrystal SubCrystal)> ret)
        {
            base.GetCrystal(ret);
        }
    }
    #endregion





    #endregion

}
