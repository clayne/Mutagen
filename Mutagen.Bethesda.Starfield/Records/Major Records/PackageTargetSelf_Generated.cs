/*
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
 * Autogenerated by Loqui.  Do not manually change.
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * 
*/
#region Usings
using Loqui;
using Loqui.Interfaces;
using Loqui.Internal;
using Mutagen.Bethesda.Binary;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Binary.Headers;
using Mutagen.Bethesda.Plugins.Binary.Overlay;
using Mutagen.Bethesda.Plugins.Binary.Streams;
using Mutagen.Bethesda.Plugins.Binary.Translations;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Plugins.Internals;
using Mutagen.Bethesda.Plugins.Meta;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins.Records.Internals;
using Mutagen.Bethesda.Plugins.Records.Mapping;
using Mutagen.Bethesda.Starfield;
using Mutagen.Bethesda.Starfield.Internals;
using Mutagen.Bethesda.Translations.Binary;
using Noggog;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using RecordTypeInts = Mutagen.Bethesda.Starfield.Internals.RecordTypeInts;
using RecordTypes = Mutagen.Bethesda.Starfield.Internals.RecordTypes;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reactive.Disposables;
using System.Reactive.Linq;
#endregion

#nullable enable
namespace Mutagen.Bethesda.Starfield
{
    #region Class
    public partial class PackageTargetSelf :
        APackageTarget,
        IEquatable<IPackageTargetSelfGetter>,
        ILoquiObjectSetter<PackageTargetSelf>,
        IPackageTargetSelf
    {
        #region Ctor
        public PackageTargetSelf()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region Data
        public Int32 Data { get; set; } = default;
        #endregion

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            PackageTargetSelfMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IPackageTargetSelfGetter rhs) return false;
            return ((PackageTargetSelfCommon)((IPackageTargetSelfGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IPackageTargetSelfGetter? obj)
        {
            return ((PackageTargetSelfCommon)((IPackageTargetSelfGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((PackageTargetSelfCommon)((IPackageTargetSelfGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            APackageTarget.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
                this.Data = initialValue;
            }

            public Mask(
                TItem CountOrDistance,
                TItem Data)
            : base(CountOrDistance: CountOrDistance)
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
                var ret = new PackageTargetSelf.Mask<R>();
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
            public override string ToString() => this.Print();

            public string Print(PackageTargetSelf.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, PackageTargetSelf.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(PackageTargetSelf.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                    if (printMask?.Data ?? true)
                    {
                        sb.AppendItem(Data, "Data");
                    }
                }
            }
            #endregion

        }

        public new class ErrorMask :
            APackageTarget.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Data;
            #endregion

            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                PackageTargetSelf_FieldIndex enu = (PackageTargetSelf_FieldIndex)index;
                switch (enu)
                {
                    case PackageTargetSelf_FieldIndex.Data:
                        return Data;
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                PackageTargetSelf_FieldIndex enu = (PackageTargetSelf_FieldIndex)index;
                switch (enu)
                {
                    case PackageTargetSelf_FieldIndex.Data:
                        this.Data = ex;
                        break;
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                PackageTargetSelf_FieldIndex enu = (PackageTargetSelf_FieldIndex)index;
                switch (enu)
                {
                    case PackageTargetSelf_FieldIndex.Data:
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
            public override string ToString() => this.Print();

            public override void Print(StructuredStringBuilder sb, string? name = null)
            {
                sb.AppendLine($"{(name ?? "ErrorMask")} =>");
                using (sb.Brace())
                {
                    if (this.Overall != null)
                    {
                        sb.AppendLine("Overall =>");
                        using (sb.Brace())
                        {
                            sb.AppendLine($"{this.Overall}");
                        }
                    }
                    PrintFillInternal(sb);
                }
            }
            protected override void PrintFillInternal(StructuredStringBuilder sb)
            {
                base.PrintFillInternal(sb);
                {
                    sb.AppendItem(Data, "Data");
                }
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
            APackageTarget.TranslationMask,
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
        protected override object BinaryWriteTranslator => PackageTargetSelfBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((PackageTargetSelfBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static PackageTargetSelf CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new PackageTargetSelf();
            ((PackageTargetSelfSetterCommon)((IPackageTargetSelfGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out PackageTargetSelf item,
            TypedParseParams translationParams = default)
        {
            var startPos = frame.Position;
            item = CreateFromBinary(
                frame: frame,
                translationParams: translationParams);
            return startPos != frame.Position;
        }
        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        void IClearable.Clear()
        {
            ((PackageTargetSelfSetterCommon)((IPackageTargetSelfGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new PackageTargetSelf GetNew()
        {
            return new PackageTargetSelf();
        }

    }
    #endregion

    #region Interface
    public partial interface IPackageTargetSelf :
        IAPackageTarget,
        ILoquiObjectSetter<IPackageTargetSelf>,
        IPackageTargetSelfGetter
    {
        new Int32 Data { get; set; }
    }

    public partial interface IPackageTargetSelfGetter :
        IAPackageTargetGetter,
        IBinaryItem,
        ILoquiObject<IPackageTargetSelfGetter>
    {
        static new ILoquiRegistration StaticRegistration => PackageTargetSelf_Registration.Instance;
        Int32 Data { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class PackageTargetSelfMixIn
    {
        public static void Clear(this IPackageTargetSelf item)
        {
            ((PackageTargetSelfSetterCommon)((IPackageTargetSelfGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static PackageTargetSelf.Mask<bool> GetEqualsMask(
            this IPackageTargetSelfGetter item,
            IPackageTargetSelfGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((PackageTargetSelfCommon)((IPackageTargetSelfGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IPackageTargetSelfGetter item,
            string? name = null,
            PackageTargetSelf.Mask<bool>? printMask = null)
        {
            return ((PackageTargetSelfCommon)((IPackageTargetSelfGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IPackageTargetSelfGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            PackageTargetSelf.Mask<bool>? printMask = null)
        {
            ((PackageTargetSelfCommon)((IPackageTargetSelfGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IPackageTargetSelfGetter item,
            IPackageTargetSelfGetter rhs,
            PackageTargetSelf.TranslationMask? equalsMask = null)
        {
            return ((PackageTargetSelfCommon)((IPackageTargetSelfGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IPackageTargetSelf lhs,
            IPackageTargetSelfGetter rhs,
            out PackageTargetSelf.ErrorMask errorMask,
            PackageTargetSelf.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((PackageTargetSelfSetterTranslationCommon)((IPackageTargetSelfGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = PackageTargetSelf.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IPackageTargetSelf lhs,
            IPackageTargetSelfGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((PackageTargetSelfSetterTranslationCommon)((IPackageTargetSelfGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static PackageTargetSelf DeepCopy(
            this IPackageTargetSelfGetter item,
            PackageTargetSelf.TranslationMask? copyMask = null)
        {
            return ((PackageTargetSelfSetterTranslationCommon)((IPackageTargetSelfGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static PackageTargetSelf DeepCopy(
            this IPackageTargetSelfGetter item,
            out PackageTargetSelf.ErrorMask errorMask,
            PackageTargetSelf.TranslationMask? copyMask = null)
        {
            return ((PackageTargetSelfSetterTranslationCommon)((IPackageTargetSelfGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static PackageTargetSelf DeepCopy(
            this IPackageTargetSelfGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((PackageTargetSelfSetterTranslationCommon)((IPackageTargetSelfGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IPackageTargetSelf item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((PackageTargetSelfSetterCommon)((IPackageTargetSelfGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                translationParams: translationParams);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Starfield
{
    #region Field Index
    internal enum PackageTargetSelf_FieldIndex
    {
        CountOrDistance = 0,
        Data = 1,
    }
    #endregion

    #region Registration
    internal partial class PackageTargetSelf_Registration : ILoquiRegistration
    {
        public static readonly PackageTargetSelf_Registration Instance = new PackageTargetSelf_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Starfield.ProtocolKey;

        public const ushort AdditionalFieldCount = 1;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(PackageTargetSelf.Mask<>);

        public static readonly Type ErrorMaskType = typeof(PackageTargetSelf.ErrorMask);

        public static readonly Type ClassType = typeof(PackageTargetSelf);

        public static readonly Type GetterType = typeof(IPackageTargetSelfGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IPackageTargetSelf);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Starfield.PackageTargetSelf";

        public const string Name = "PackageTargetSelf";

        public const string Namespace = "Mutagen.Bethesda.Starfield";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(PackageTargetSelfBinaryWriteTranslation);
        #region Interface
        ProtocolKey ILoquiRegistration.ProtocolKey => ProtocolKey;
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
    internal partial class PackageTargetSelfSetterCommon : APackageTargetSetterCommon
    {
        public new static readonly PackageTargetSelfSetterCommon Instance = new PackageTargetSelfSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IPackageTargetSelf item)
        {
            ClearPartial();
            item.Data = default;
            base.Clear(item);
        }
        
        public override void Clear(IAPackageTarget item)
        {
            Clear(item: (IPackageTargetSelf)item);
        }
        
        #region Mutagen
        public void RemapLinks(IPackageTargetSelf obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IPackageTargetSelf item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillStructs: PackageTargetSelfBinaryCreateTranslation.FillBinaryStructs);
        }
        
        public override void CopyInFromBinary(
            IAPackageTarget item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (PackageTargetSelf)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class PackageTargetSelfCommon : APackageTargetCommon
    {
        public new static readonly PackageTargetSelfCommon Instance = new PackageTargetSelfCommon();

        public PackageTargetSelf.Mask<bool> GetEqualsMask(
            IPackageTargetSelfGetter item,
            IPackageTargetSelfGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new PackageTargetSelf.Mask<bool>(false);
            ((PackageTargetSelfCommon)((IPackageTargetSelfGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IPackageTargetSelfGetter item,
            IPackageTargetSelfGetter rhs,
            PackageTargetSelf.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            ret.Data = item.Data == rhs.Data;
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IPackageTargetSelfGetter item,
            string? name = null,
            PackageTargetSelf.Mask<bool>? printMask = null)
        {
            var sb = new StructuredStringBuilder();
            Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
            return sb.ToString();
        }
        
        public void Print(
            IPackageTargetSelfGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            PackageTargetSelf.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"PackageTargetSelf =>");
            }
            else
            {
                sb.AppendLine($"{name} (PackageTargetSelf) =>");
            }
            using (sb.Brace())
            {
                ToStringFields(
                    item: item,
                    sb: sb,
                    printMask: printMask);
            }
        }
        
        protected static void ToStringFields(
            IPackageTargetSelfGetter item,
            StructuredStringBuilder sb,
            PackageTargetSelf.Mask<bool>? printMask = null)
        {
            APackageTargetCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
            if (printMask?.Data ?? true)
            {
                sb.AppendItem(item.Data, "Data");
            }
        }
        
        public static PackageTargetSelf_FieldIndex ConvertFieldIndex(APackageTarget_FieldIndex index)
        {
            switch (index)
            {
                case APackageTarget_FieldIndex.CountOrDistance:
                    return (PackageTargetSelf_FieldIndex)((int)index);
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IPackageTargetSelfGetter? lhs,
            IPackageTargetSelfGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IAPackageTargetGetter)lhs, (IAPackageTargetGetter)rhs, equalsMask)) return false;
            if ((equalsMask?.GetShouldTranslate((int)PackageTargetSelf_FieldIndex.Data) ?? true))
            {
                if (lhs.Data != rhs.Data) return false;
            }
            return true;
        }
        
        public override bool Equals(
            IAPackageTargetGetter? lhs,
            IAPackageTargetGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (IPackageTargetSelfGetter?)lhs,
                rhs: rhs as IPackageTargetSelfGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(IPackageTargetSelfGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.Data);
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IAPackageTargetGetter item)
        {
            return GetHashCode(item: (IPackageTargetSelfGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return PackageTargetSelf.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IPackageTargetSelfGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        #endregion
        
    }
    internal partial class PackageTargetSelfSetterTranslationCommon : APackageTargetSetterTranslationCommon
    {
        public new static readonly PackageTargetSelfSetterTranslationCommon Instance = new PackageTargetSelfSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IPackageTargetSelf item,
            IPackageTargetSelfGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IAPackageTarget)item,
                (IAPackageTargetGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
            if ((copyMask?.GetShouldTranslate((int)PackageTargetSelf_FieldIndex.Data) ?? true))
            {
                item.Data = rhs.Data;
            }
        }
        
        
        public override void DeepCopyIn(
            IAPackageTarget item,
            IAPackageTargetGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IPackageTargetSelf)item,
                rhs: (IPackageTargetSelfGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public PackageTargetSelf DeepCopy(
            IPackageTargetSelfGetter item,
            PackageTargetSelf.TranslationMask? copyMask = null)
        {
            PackageTargetSelf ret = (PackageTargetSelf)((PackageTargetSelfCommon)((IPackageTargetSelfGetter)item).CommonInstance()!).GetNew();
            ((PackageTargetSelfSetterTranslationCommon)((IPackageTargetSelfGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public PackageTargetSelf DeepCopy(
            IPackageTargetSelfGetter item,
            out PackageTargetSelf.ErrorMask errorMask,
            PackageTargetSelf.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            PackageTargetSelf ret = (PackageTargetSelf)((PackageTargetSelfCommon)((IPackageTargetSelfGetter)item).CommonInstance()!).GetNew();
            ((PackageTargetSelfSetterTranslationCommon)((IPackageTargetSelfGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = PackageTargetSelf.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public PackageTargetSelf DeepCopy(
            IPackageTargetSelfGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            PackageTargetSelf ret = (PackageTargetSelf)((PackageTargetSelfCommon)((IPackageTargetSelfGetter)item).CommonInstance()!).GetNew();
            ((PackageTargetSelfSetterTranslationCommon)((IPackageTargetSelfGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Starfield
{
    public partial class PackageTargetSelf
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PackageTargetSelf_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => PackageTargetSelf_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => PackageTargetSelfCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return PackageTargetSelfSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => PackageTargetSelfSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Starfield
{
    public partial class PackageTargetSelfBinaryWriteTranslation :
        APackageTargetBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly PackageTargetSelfBinaryWriteTranslation Instance = new();

        public static void WriteEmbedded(
            IPackageTargetSelfGetter item,
            MutagenWriter writer)
        {
            APackageTargetBinaryWriteTranslation.WriteEmbedded(
                item: item,
                writer: writer);
            writer.Write(item.Data);
        }

        public void Write(
            MutagenWriter writer,
            IPackageTargetSelfGetter item,
            TypedWriteParams translationParams)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IPackageTargetSelfGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IAPackageTargetGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IPackageTargetSelfGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class PackageTargetSelfBinaryCreateTranslation : APackageTargetBinaryCreateTranslation
    {
        public new static readonly PackageTargetSelfBinaryCreateTranslation Instance = new PackageTargetSelfBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IPackageTargetSelf item,
            MutagenFrame frame)
        {
            APackageTargetBinaryCreateTranslation.FillBinaryStructs(
                item: item,
                frame: frame);
            item.Data = frame.ReadInt32();
        }

    }

}
namespace Mutagen.Bethesda.Starfield
{
    #region Binary Write Mixins
    public static class PackageTargetSelfBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Starfield
{
    internal partial class PackageTargetSelfBinaryOverlay :
        APackageTargetBinaryOverlay,
        IPackageTargetSelfGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => PackageTargetSelf_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => PackageTargetSelf_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => PackageTargetSelfCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => PackageTargetSelfSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => PackageTargetSelfBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((PackageTargetSelfBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        public Int32 Data => BinaryPrimitives.ReadInt32LittleEndian(_structData.Slice(0xC, 0x4));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected PackageTargetSelfBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IPackageTargetSelfGetter PackageTargetSelfFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordStructMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                length: 0x10,
                memoryPair: out var memoryPair,
                offset: out var offset);
            var ret = new PackageTargetSelfBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            stream.Position += 0x10;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static IPackageTargetSelfGetter PackageTargetSelfFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return PackageTargetSelfFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            PackageTargetSelfMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IPackageTargetSelfGetter rhs) return false;
            return ((PackageTargetSelfCommon)((IPackageTargetSelfGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IPackageTargetSelfGetter? obj)
        {
            return ((PackageTargetSelfCommon)((IPackageTargetSelfGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((PackageTargetSelfCommon)((IPackageTargetSelfGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

