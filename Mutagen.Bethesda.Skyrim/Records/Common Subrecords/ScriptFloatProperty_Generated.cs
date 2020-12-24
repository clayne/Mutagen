/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Internals;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Skyrim.Internals;
using Noggog;
using System;
using System.Buffers.Binary;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Text;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Skyrim
{
    #region Class
    public partial class ScriptFloatProperty :
        ScriptProperty,
        IScriptFloatProperty,
        ILoquiObjectSetter<ScriptFloatProperty>,
        IEquatable<IScriptFloatPropertyGetter>
    {
        #region Ctor
        public ScriptFloatProperty()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Data
        public Single Data { get; set; } = default;
        #endregion

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ScriptFloatPropertyMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IScriptFloatPropertyGetter rhs)) return false;
            return ((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IScriptFloatPropertyGetter? obj)
        {
            return ((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            ScriptProperty.Mask<TItem>,
            IMask<TItem>,
            IEquatable<Mask<TItem>>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
                this.Data = initialValue;
            }

            public Mask(
                TItem Name,
                TItem Flags,
                TItem Data)
            : base(
                Name: Name,
                Flags: Flags)
            {
                this.Data = Data;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem Data;
            #endregion

            #region Equals
            public override bool Equals(object? obj)
            {
                if (!(obj is Mask<TItem> rhs)) return false;
                return Equals(rhs);
            }

            public bool Equals(Mask<TItem>? rhs)
            {
                if (rhs == null) return false;
                if (!base.Equals(rhs)) return false;
                if (!object.Equals(this.Data, rhs.Data)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.Data);
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                if (!eval(this.Data)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                if (eval(this.Data)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new ScriptFloatProperty.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
                obj.Data = eval(this.Data);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(ScriptFloatProperty.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, ScriptFloatProperty.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(ScriptFloatProperty.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.Data ?? true)
                    {
                        fg.AppendItem(Data, "Data");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public new class ErrorMask :
            ScriptProperty.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Data;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                ScriptFloatProperty_FieldIndex enu = (ScriptFloatProperty_FieldIndex)index;
                switch (enu)
                {
                    case ScriptFloatProperty_FieldIndex.Data:
                        return Data;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                ScriptFloatProperty_FieldIndex enu = (ScriptFloatProperty_FieldIndex)index;
                switch (enu)
                {
                    case ScriptFloatProperty_FieldIndex.Data:
                        this.Data = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                ScriptFloatProperty_FieldIndex enu = (ScriptFloatProperty_FieldIndex)index;
                switch (enu)
                {
                    case ScriptFloatProperty_FieldIndex.Data:
                        this.Data = (Exception?)obj;
                        break;
                    default:
                        base.SetNthMask(index, obj);
                        break;
                }
            }

            public override bool IsInError()
            {
                if (Overall != null) return true;
                if (Data != null) return true;
                return false;
            }
            #endregion

            #region To String
            public override string ToString()
            {
                var fg = new FileGeneration();
                ToString(fg, null);
                return fg.ToString();
            }

            public override void ToString(FileGeneration fg, string? name = null)
            {
                fg.AppendLine($"{(name ?? "ErrorMask")} =>");
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
                fg.AppendItem(Data, "Data");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.Data = this.Data.Combine(rhs.Data);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static new ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public new class TranslationMask :
            ScriptProperty.TranslationMask,
            ITranslationMask
        {
            #region Members
            public bool Data;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
                this.Data = defaultOn;
            }

            #endregion

            protected override void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                base.GetCrystal(ret);
                ret.Add((Data, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ScriptFloatPropertyBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ScriptFloatPropertyBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public new static ScriptFloatProperty CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new ScriptFloatProperty();
            ((ScriptFloatPropertySetterCommon)((IScriptFloatPropertyGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out ScriptFloatProperty item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(frame, recordTypeConverter);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        void IClearable.Clear()
        {
            ((ScriptFloatPropertySetterCommon)((IScriptFloatPropertyGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new ScriptFloatProperty GetNew()
        {
            return new ScriptFloatProperty();
        }

    }
    #endregion

    #region Interface
    public partial interface IScriptFloatProperty :
        IScriptFloatPropertyGetter,
        IScriptProperty,
        ILoquiObjectSetter<IScriptFloatProperty>
    {
        new Single Data { get; set; }
    }

    public partial interface IScriptFloatPropertyGetter :
        IScriptPropertyGetter,
        ILoquiObject<IScriptFloatPropertyGetter>,
        IBinaryItem
    {
        static new ILoquiRegistration Registration => ScriptFloatProperty_Registration.Instance;
        Single Data { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class ScriptFloatPropertyMixIn
    {
        public static void Clear(this IScriptFloatProperty item)
        {
            ((ScriptFloatPropertySetterCommon)((IScriptFloatPropertyGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ScriptFloatProperty.Mask<bool> GetEqualsMask(
            this IScriptFloatPropertyGetter item,
            IScriptFloatPropertyGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IScriptFloatPropertyGetter item,
            string? name = null,
            ScriptFloatProperty.Mask<bool>? printMask = null)
        {
            return ((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IScriptFloatPropertyGetter item,
            FileGeneration fg,
            string? name = null,
            ScriptFloatProperty.Mask<bool>? printMask = null)
        {
            ((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IScriptFloatPropertyGetter item,
            IScriptFloatPropertyGetter rhs)
        {
            return ((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this IScriptFloatProperty lhs,
            IScriptFloatPropertyGetter rhs,
            out ScriptFloatProperty.ErrorMask errorMask,
            ScriptFloatProperty.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ScriptFloatPropertySetterTranslationCommon)((IScriptFloatPropertyGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ScriptFloatProperty.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IScriptFloatProperty lhs,
            IScriptFloatPropertyGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ScriptFloatPropertySetterTranslationCommon)((IScriptFloatPropertyGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ScriptFloatProperty DeepCopy(
            this IScriptFloatPropertyGetter item,
            ScriptFloatProperty.TranslationMask? copyMask = null)
        {
            return ((ScriptFloatPropertySetterTranslationCommon)((IScriptFloatPropertyGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ScriptFloatProperty DeepCopy(
            this IScriptFloatPropertyGetter item,
            out ScriptFloatProperty.ErrorMask errorMask,
            ScriptFloatProperty.TranslationMask? copyMask = null)
        {
            return ((ScriptFloatPropertySetterTranslationCommon)((IScriptFloatPropertyGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ScriptFloatProperty DeepCopy(
            this IScriptFloatPropertyGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ScriptFloatPropertySetterTranslationCommon)((IScriptFloatPropertyGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IScriptFloatProperty item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ScriptFloatPropertySetterCommon)((IScriptFloatPropertyGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim.Internals
{
    #region Field Index
    public enum ScriptFloatProperty_FieldIndex
    {
        Name = 0,
        Flags = 1,
        Data = 2,
    }
    #endregion

    #region Registration
    public partial class ScriptFloatProperty_Registration : ILoquiRegistration
    {
        public static readonly ScriptFloatProperty_Registration Instance = new ScriptFloatProperty_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Skyrim.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Skyrim.ProtocolKey,
            msgID: 97,
            version: 0);

        public const string GUID = "011cdbc3-c08d-49c7-88ad-0d13e4419523";

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 3;

        public static readonly Type MaskType = typeof(ScriptFloatProperty.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ScriptFloatProperty.ErrorMask);

        public static readonly Type ClassType = typeof(ScriptFloatProperty);

        public static readonly Type GetterType = typeof(IScriptFloatPropertyGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IScriptFloatProperty);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Skyrim.ScriptFloatProperty";

        public const string Name = "ScriptFloatProperty";

        public const string Namespace = "Mutagen.Bethesda.Skyrim";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(ScriptFloatPropertyBinaryWriteTranslation);
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
        Type? ILoquiRegistration.InternalSetterType => InternalSetterType;
        Type ILoquiRegistration.GetterType => GetterType;
        Type? ILoquiRegistration.InternalGetterType => InternalGetterType;
        string ILoquiRegistration.FullName => FullName;
        string ILoquiRegistration.Name => Name;
        string ILoquiRegistration.Namespace => Namespace;
        byte ILoquiRegistration.GenericCount => GenericCount;
        Type? ILoquiRegistration.GenericRegistrationType => GenericRegistrationType;
        ushort? ILoquiRegistration.GetNameIndex(StringCaseAgnostic name) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsEnumerable(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsLoqui(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.GetNthIsSingleton(ushort index) => throw new NotImplementedException();
        string ILoquiRegistration.GetNthName(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsNthDerivative(ushort index) => throw new NotImplementedException();
        bool ILoquiRegistration.IsProtected(ushort index) => throw new NotImplementedException();
        Type ILoquiRegistration.GetNthType(ushort index) => throw new NotImplementedException();
        #endregion

    }
    #endregion

    #region Common
    public partial class ScriptFloatPropertySetterCommon : ScriptPropertySetterCommon
    {
        public new static readonly ScriptFloatPropertySetterCommon Instance = new ScriptFloatPropertySetterCommon();

        partial void ClearPartial();
        
        public void Clear(IScriptFloatProperty item)
        {
            ClearPartial();
            item.Data = default;
            base.Clear(item);
        }
        
        public override void Clear(IScriptProperty item)
        {
            Clear(item: (IScriptFloatProperty)item);
        }
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IScriptFloatProperty item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            UtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: ScriptFloatPropertyBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IScriptProperty item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            CopyInFromBinary(
                item: (ScriptFloatProperty)item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }
        
        #endregion
        
    }
    public partial class ScriptFloatPropertyCommon : ScriptPropertyCommon
    {
        public new static readonly ScriptFloatPropertyCommon Instance = new ScriptFloatPropertyCommon();

        public ScriptFloatProperty.Mask<bool> GetEqualsMask(
            IScriptFloatPropertyGetter item,
            IScriptFloatPropertyGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ScriptFloatProperty.Mask<bool>(false);
            ((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IScriptFloatPropertyGetter item,
            IScriptFloatPropertyGetter rhs,
            ScriptFloatProperty.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.Data = item.Data.EqualsWithin(rhs.Data);
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string ToString(
            IScriptFloatPropertyGetter item,
            string? name = null,
            ScriptFloatProperty.Mask<bool>? printMask = null)
        {
            var fg = new FileGeneration();
            ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
            return fg.ToString();
        }
        
        public void ToString(
            IScriptFloatPropertyGetter item,
            FileGeneration fg,
            string? name = null,
            ScriptFloatProperty.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"ScriptFloatProperty =>");
            }
            else
            {
                fg.AppendLine($"{name} (ScriptFloatProperty) =>");
            }
            fg.AppendLine("[");
            using (new DepthWrapper(fg))
            {
                ToStringFields(
                    item: item,
                    fg: fg,
                    printMask: printMask);
            }
            fg.AppendLine("]");
        }
        
        protected static void ToStringFields(
            IScriptFloatPropertyGetter item,
            FileGeneration fg,
            ScriptFloatProperty.Mask<bool>? printMask = null)
        {
            ScriptPropertyCommon.ToStringFields(
                item: item,
                fg: fg,
                printMask: printMask);
            if (printMask?.Data ?? true)
            {
                fg.AppendItem(item.Data, "Data");
            }
        }
        
        public static ScriptFloatProperty_FieldIndex ConvertFieldIndex(ScriptProperty_FieldIndex index)
        {
            switch (index)
            {
                case ScriptProperty_FieldIndex.Name:
                    return (ScriptFloatProperty_FieldIndex)((int)index);
                case ScriptProperty_FieldIndex.Flags:
                    return (ScriptFloatProperty_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast_Enum_Only()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IScriptFloatPropertyGetter? lhs,
            IScriptFloatPropertyGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (!base.Equals((IScriptPropertyGetter)lhs, (IScriptPropertyGetter)rhs)) return false;
            if (!lhs.Data.EqualsWithin(rhs.Data)) return false;
            return true;
        }
        
        public override bool Equals(
            IScriptPropertyGetter? lhs,
            IScriptPropertyGetter? rhs)
        {
            return Equals(
                lhs: (IScriptFloatPropertyGetter?)lhs,
                rhs: rhs as IScriptFloatPropertyGetter);
        }
        
        public virtual int GetHashCode(IScriptFloatPropertyGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Data);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IScriptPropertyGetter item)
        {
            return GetHashCode(item: (IScriptFloatPropertyGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return ScriptFloatProperty.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetLinkFormKeys(IScriptFloatPropertyGetter obj)
        {
            foreach (var item in base.GetLinkFormKeys(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        public void RemapLinks(IScriptFloatPropertyGetter obj, IReadOnlyDictionary<FormKey, FormKey> mapping) => throw new NotImplementedException();
        #endregion
        
    }
    public partial class ScriptFloatPropertySetterTranslationCommon : ScriptPropertySetterTranslationCommon
    {
        public new static readonly ScriptFloatPropertySetterTranslationCommon Instance = new ScriptFloatPropertySetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IScriptFloatProperty item,
            IScriptFloatPropertyGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IScriptProperty)item,
                (IScriptPropertyGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)ScriptFloatProperty_FieldIndex.Data) ?? true))
            {
                item.Data = rhs.Data;
            }
        }
        
        
        public override void DeepCopyIn(
            IScriptProperty item,
            IScriptPropertyGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IScriptFloatProperty)item,
                rhs: (IScriptFloatPropertyGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public ScriptFloatProperty DeepCopy(
            IScriptFloatPropertyGetter item,
            ScriptFloatProperty.TranslationMask? copyMask = null)
        {
            ScriptFloatProperty ret = (ScriptFloatProperty)((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)item).CommonInstance()!).GetNew();
            ((ScriptFloatPropertySetterTranslationCommon)((IScriptFloatPropertyGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ScriptFloatProperty DeepCopy(
            IScriptFloatPropertyGetter item,
            out ScriptFloatProperty.ErrorMask errorMask,
            ScriptFloatProperty.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ScriptFloatProperty ret = (ScriptFloatProperty)((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)item).CommonInstance()!).GetNew();
            ((ScriptFloatPropertySetterTranslationCommon)((IScriptFloatPropertyGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ScriptFloatProperty.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ScriptFloatProperty DeepCopy(
            IScriptFloatPropertyGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ScriptFloatProperty ret = (ScriptFloatProperty)((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)item).CommonInstance()!).GetNew();
            ((ScriptFloatPropertySetterTranslationCommon)((IScriptFloatPropertyGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: true);
            return ret;
        }
        
    }
    #endregion

}

namespace Mutagen.Bethesda.Skyrim
{
    public partial class ScriptFloatProperty
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ScriptFloatProperty_Registration.Instance;
        public new static ScriptFloatProperty_Registration Registration => ScriptFloatProperty_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ScriptFloatPropertyCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return ScriptFloatPropertySetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ScriptFloatPropertySetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ScriptFloatPropertyBinaryWriteTranslation :
        ScriptPropertyBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new readonly static ScriptFloatPropertyBinaryWriteTranslation Instance = new ScriptFloatPropertyBinaryWriteTranslation();

        public static void WriteEmbedded(
            IScriptFloatPropertyGetter item,
            MutagenWriter writer)
        {
            ScriptPropertyBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
            Mutagen.Bethesda.Binary.FloatBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Data);
        }

        public void Write(
            MutagenWriter writer,
            IScriptFloatPropertyGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IScriptFloatPropertyGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public override void Write(
            MutagenWriter writer,
            IScriptPropertyGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IScriptFloatPropertyGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class ScriptFloatPropertyBinaryCreateTranslation : ScriptPropertyBinaryCreateTranslation
    {
        public new readonly static ScriptFloatPropertyBinaryCreateTranslation Instance = new ScriptFloatPropertyBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IScriptFloatProperty item,
            MutagenFrame frame)
        {
            ScriptPropertyBinaryCreateTranslation.FillBinaryStructs(
                item: item,
                frame: frame);
            item.Data = Mutagen.Bethesda.Binary.FloatBinaryTranslation.Instance.Parse(frame: frame);
        }

    }

}
namespace Mutagen.Bethesda.Skyrim
{
    #region Binary Write Mixins
    public static class ScriptFloatPropertyBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Skyrim.Internals
{
    public partial class ScriptFloatPropertyBinaryOverlay :
        ScriptPropertyBinaryOverlay,
        IScriptFloatPropertyGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ScriptFloatProperty_Registration.Instance;
        public new static ScriptFloatProperty_Registration Registration => ScriptFloatProperty_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ScriptFloatPropertyCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ScriptFloatPropertySetterTranslationCommon.Instance;

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ScriptFloatPropertyBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((ScriptFloatPropertyBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public Single Data => _data.Slice(0x0, 0x4).Float();
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ScriptFloatPropertyBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static ScriptFloatPropertyBinaryOverlay ScriptFloatPropertyFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new ScriptFloatPropertyBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x4),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x4;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static ScriptFloatPropertyBinaryOverlay ScriptFloatPropertyFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return ScriptFloatPropertyFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public override void ToString(
            FileGeneration fg,
            string? name = null)
        {
            ScriptFloatPropertyMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IScriptFloatPropertyGetter rhs)) return false;
            return ((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IScriptFloatPropertyGetter? obj)
        {
            return ((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((ScriptFloatPropertyCommon)((IScriptFloatPropertyGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

