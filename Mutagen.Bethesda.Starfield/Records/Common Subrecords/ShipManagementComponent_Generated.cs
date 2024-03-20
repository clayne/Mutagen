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
    public partial class ShipManagementComponent :
        AComponent,
        IEquatable<IShipManagementComponentGetter>,
        ILoquiObjectSetter<ShipManagementComponent>,
        IShipManagementComponent
    {
        #region Ctor
        public ShipManagementComponent()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion


        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ShipManagementComponentMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IShipManagementComponentGetter rhs) return false;
            return ((ShipManagementComponentCommon)((IShipManagementComponentGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IShipManagementComponentGetter? obj)
        {
            return ((ShipManagementComponentCommon)((IShipManagementComponentGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((ShipManagementComponentCommon)((IShipManagementComponentGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public new class Mask<TItem> :
            AComponent.Mask<TItem>,
            IEquatable<Mask<TItem>>,
            IMask<TItem>
        {
            #region Ctors
            public Mask(TItem initialValue)
            : base(initialValue)
            {
            }


            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

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
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(base.GetHashCode());
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public override bool All(Func<TItem, bool> eval)
            {
                if (!base.All(eval)) return false;
                return true;
            }
            #endregion

            #region Any
            public override bool Any(Func<TItem, bool> eval)
            {
                if (base.Any(eval)) return true;
                return false;
            }
            #endregion

            #region Translate
            public new Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new ShipManagementComponent.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                base.Translate_InternalFill(obj, eval);
            }
            #endregion

            #region To String
            public override string ToString() => this.Print();

            public string Print(ShipManagementComponent.Mask<bool>? printMask = null)
            {
                var sb = new StructuredStringBuilder();
                Print(sb, printMask);
                return sb.ToString();
            }

            public void Print(StructuredStringBuilder sb, ShipManagementComponent.Mask<bool>? printMask = null)
            {
                sb.AppendLine($"{nameof(ShipManagementComponent.Mask<TItem>)} =>");
                using (sb.Brace())
                {
                }
            }
            #endregion

        }

        public new class ErrorMask :
            AComponent.ErrorMask,
            IErrorMask<ErrorMask>
        {
            #region IErrorMask
            public override object? GetNthMask(int index)
            {
                ShipManagementComponent_FieldIndex enu = (ShipManagementComponent_FieldIndex)index;
                switch (enu)
                {
                    default:
                        return base.GetNthMask(index);
                }
            }

            public override void SetNthException(int index, Exception ex)
            {
                ShipManagementComponent_FieldIndex enu = (ShipManagementComponent_FieldIndex)index;
                switch (enu)
                {
                    default:
                        base.SetNthException(index, ex);
                        break;
                }
            }

            public override void SetNthMask(int index, object obj)
            {
                ShipManagementComponent_FieldIndex enu = (ShipManagementComponent_FieldIndex)index;
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
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
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
            AComponent.TranslationMask,
            ITranslationMask
        {
            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
                : base(defaultOn, onOverall)
            {
            }

            #endregion

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ShipManagementComponentBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((ShipManagementComponentBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }
        #region Binary Create
        public new static ShipManagementComponent CreateFromBinary(
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            var ret = new ShipManagementComponent();
            ((ShipManagementComponentSetterCommon)((IShipManagementComponentGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                translationParams: translationParams);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out ShipManagementComponent item,
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
            ((ShipManagementComponentSetterCommon)((IShipManagementComponentGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static new ShipManagementComponent GetNew()
        {
            return new ShipManagementComponent();
        }

    }
    #endregion

    #region Interface
    public partial interface IShipManagementComponent :
        IAComponent,
        ILoquiObjectSetter<IShipManagementComponent>,
        IShipManagementComponentGetter
    {
    }

    public partial interface IShipManagementComponentGetter :
        IAComponentGetter,
        IBinaryItem,
        ILoquiObject<IShipManagementComponentGetter>
    {
        static new ILoquiRegistration StaticRegistration => ShipManagementComponent_Registration.Instance;

    }

    #endregion

    #region Common MixIn
    public static partial class ShipManagementComponentMixIn
    {
        public static void Clear(this IShipManagementComponent item)
        {
            ((ShipManagementComponentSetterCommon)((IShipManagementComponentGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static ShipManagementComponent.Mask<bool> GetEqualsMask(
            this IShipManagementComponentGetter item,
            IShipManagementComponentGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((ShipManagementComponentCommon)((IShipManagementComponentGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string Print(
            this IShipManagementComponentGetter item,
            string? name = null,
            ShipManagementComponent.Mask<bool>? printMask = null)
        {
            return ((ShipManagementComponentCommon)((IShipManagementComponentGetter)item).CommonInstance()!).Print(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void Print(
            this IShipManagementComponentGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ShipManagementComponent.Mask<bool>? printMask = null)
        {
            ((ShipManagementComponentCommon)((IShipManagementComponentGetter)item).CommonInstance()!).Print(
                item: item,
                sb: sb,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IShipManagementComponentGetter item,
            IShipManagementComponentGetter rhs,
            ShipManagementComponent.TranslationMask? equalsMask = null)
        {
            return ((ShipManagementComponentCommon)((IShipManagementComponentGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs,
                equalsMask: equalsMask?.GetCrystal());
        }

        public static void DeepCopyIn(
            this IShipManagementComponent lhs,
            IShipManagementComponentGetter rhs,
            out ShipManagementComponent.ErrorMask errorMask,
            ShipManagementComponent.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((ShipManagementComponentSetterTranslationCommon)((IShipManagementComponentGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = ShipManagementComponent.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IShipManagementComponent lhs,
            IShipManagementComponentGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((ShipManagementComponentSetterTranslationCommon)((IShipManagementComponentGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static ShipManagementComponent DeepCopy(
            this IShipManagementComponentGetter item,
            ShipManagementComponent.TranslationMask? copyMask = null)
        {
            return ((ShipManagementComponentSetterTranslationCommon)((IShipManagementComponentGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static ShipManagementComponent DeepCopy(
            this IShipManagementComponentGetter item,
            out ShipManagementComponent.ErrorMask errorMask,
            ShipManagementComponent.TranslationMask? copyMask = null)
        {
            return ((ShipManagementComponentSetterTranslationCommon)((IShipManagementComponentGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static ShipManagementComponent DeepCopy(
            this IShipManagementComponentGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((ShipManagementComponentSetterTranslationCommon)((IShipManagementComponentGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IShipManagementComponent item,
            MutagenFrame frame,
            TypedParseParams translationParams = default)
        {
            ((ShipManagementComponentSetterCommon)((IShipManagementComponentGetter)item).CommonSetterInstance()!).CopyInFromBinary(
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
    internal enum ShipManagementComponent_FieldIndex
    {
    }
    #endregion

    #region Registration
    internal partial class ShipManagementComponent_Registration : ILoquiRegistration
    {
        public static readonly ShipManagementComponent_Registration Instance = new ShipManagementComponent_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Starfield.ProtocolKey;

        public const ushort AdditionalFieldCount = 0;

        public const ushort FieldCount = 0;

        public static readonly Type MaskType = typeof(ShipManagementComponent.Mask<>);

        public static readonly Type ErrorMaskType = typeof(ShipManagementComponent.ErrorMask);

        public static readonly Type ClassType = typeof(ShipManagementComponent);

        public static readonly Type GetterType = typeof(IShipManagementComponentGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IShipManagementComponent);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Starfield.ShipManagementComponent";

        public const string Name = "ShipManagementComponent";

        public const string Namespace = "Mutagen.Bethesda.Starfield";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly RecordType TriggeringRecordType = RecordTypes.BFCB;
        public static RecordTriggerSpecs TriggerSpecs => _recordSpecs.Value;
        private static readonly Lazy<RecordTriggerSpecs> _recordSpecs = new Lazy<RecordTriggerSpecs>(() =>
        {
            var all = RecordCollection.Factory(RecordTypes.BFCB);
            return new RecordTriggerSpecs(allRecordTypes: all);
        });
        public static readonly Type BinaryWriteTranslation = typeof(ShipManagementComponentBinaryWriteTranslation);
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
    internal partial class ShipManagementComponentSetterCommon : AComponentSetterCommon
    {
        public new static readonly ShipManagementComponentSetterCommon Instance = new ShipManagementComponentSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IShipManagementComponent item)
        {
            ClearPartial();
            base.Clear(item);
        }
        
        public override void Clear(IAComponent item)
        {
            Clear(item: (IShipManagementComponent)item);
        }
        
        #region Mutagen
        public void RemapLinks(IShipManagementComponent obj, IReadOnlyDictionary<FormKey, FormKey> mapping)
        {
            base.RemapLinks(obj, mapping);
        }
        
        #endregion
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IShipManagementComponent item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            PluginUtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                translationParams: translationParams,
                fillTyped: ShipManagementComponentBinaryCreateTranslation.FillBinaryRecordTypes);
        }
        
        public override void CopyInFromBinary(
            IAComponent item,
            MutagenFrame frame,
            TypedParseParams translationParams)
        {
            CopyInFromBinary(
                item: (ShipManagementComponent)item,
                frame: frame,
                translationParams: translationParams);
        }
        
        #endregion
        
    }
    internal partial class ShipManagementComponentCommon : AComponentCommon
    {
        public new static readonly ShipManagementComponentCommon Instance = new ShipManagementComponentCommon();

        public ShipManagementComponent.Mask<bool> GetEqualsMask(
            IShipManagementComponentGetter item,
            IShipManagementComponentGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new ShipManagementComponent.Mask<bool>(false);
            ((ShipManagementComponentCommon)((IShipManagementComponentGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IShipManagementComponentGetter item,
            IShipManagementComponentGetter rhs,
            ShipManagementComponent.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            base.FillEqualsMask(item, rhs, ret, include);
        }
        
        public string Print(
            IShipManagementComponentGetter item,
            string? name = null,
            ShipManagementComponent.Mask<bool>? printMask = null)
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
            IShipManagementComponentGetter item,
            StructuredStringBuilder sb,
            string? name = null,
            ShipManagementComponent.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                sb.AppendLine($"ShipManagementComponent =>");
            }
            else
            {
                sb.AppendLine($"{name} (ShipManagementComponent) =>");
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
            IShipManagementComponentGetter item,
            StructuredStringBuilder sb,
            ShipManagementComponent.Mask<bool>? printMask = null)
        {
            AComponentCommon.ToStringFields(
                item: item,
                sb: sb,
                printMask: printMask);
        }
        
        public static ShipManagementComponent_FieldIndex ConvertFieldIndex(AComponent_FieldIndex index)
        {
            switch (index)
            {
                default:
                    throw new ArgumentException($"Index is out of range: {index.ToStringFast()}");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IShipManagementComponentGetter? lhs,
            IShipManagementComponentGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            if (!EqualsMaskHelper.RefEquality(lhs, rhs, out var isEqual)) return isEqual;
            if (!base.Equals((IAComponentGetter)lhs, (IAComponentGetter)rhs, equalsMask)) return false;
            return true;
        }
        
        public override bool Equals(
            IAComponentGetter? lhs,
            IAComponentGetter? rhs,
            TranslationCrystal? equalsMask)
        {
            return Equals(
                lhs: (IShipManagementComponentGetter?)lhs,
                rhs: rhs as IShipManagementComponentGetter,
                equalsMask: equalsMask);
        }
        
        public virtual int GetHashCode(IShipManagementComponentGetter item)
        {
            var hash = new HashCode();
            hash.Add(base.GetHashCode());
            return hash.ToHashCode();
        }
        
        public override int GetHashCode(IAComponentGetter item)
        {
            return GetHashCode(item: (IShipManagementComponentGetter)item);
        }
        
        #endregion
        
        
        public override object GetNew()
        {
            return ShipManagementComponent.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<IFormLinkGetter> EnumerateFormLinks(IShipManagementComponentGetter obj)
        {
            foreach (var item in base.EnumerateFormLinks(obj))
            {
                yield return item;
            }
            yield break;
        }
        
        #endregion
        
    }
    internal partial class ShipManagementComponentSetterTranslationCommon : AComponentSetterTranslationCommon
    {
        public new static readonly ShipManagementComponentSetterTranslationCommon Instance = new ShipManagementComponentSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IShipManagementComponent item,
            IShipManagementComponentGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            base.DeepCopyIn(
                (IAComponent)item,
                (IAComponentGetter)rhs,
                errorMask,
                copyMask,
                deepCopy: deepCopy);
        }
        
        
        public override void DeepCopyIn(
            IAComponent item,
            IAComponentGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            this.DeepCopyIn(
                item: (IShipManagementComponent)item,
                rhs: (IShipManagementComponentGetter)rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: deepCopy);
        }
        
        #endregion
        
        public ShipManagementComponent DeepCopy(
            IShipManagementComponentGetter item,
            ShipManagementComponent.TranslationMask? copyMask = null)
        {
            ShipManagementComponent ret = (ShipManagementComponent)((ShipManagementComponentCommon)((IShipManagementComponentGetter)item).CommonInstance()!).GetNew();
            ((ShipManagementComponentSetterTranslationCommon)((IShipManagementComponentGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public ShipManagementComponent DeepCopy(
            IShipManagementComponentGetter item,
            out ShipManagementComponent.ErrorMask errorMask,
            ShipManagementComponent.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ShipManagementComponent ret = (ShipManagementComponent)((ShipManagementComponentCommon)((IShipManagementComponentGetter)item).CommonInstance()!).GetNew();
            ((ShipManagementComponentSetterTranslationCommon)((IShipManagementComponentGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = ShipManagementComponent.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public ShipManagementComponent DeepCopy(
            IShipManagementComponentGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            ShipManagementComponent ret = (ShipManagementComponent)((ShipManagementComponentCommon)((IShipManagementComponentGetter)item).CommonInstance()!).GetNew();
            ((ShipManagementComponentSetterTranslationCommon)((IShipManagementComponentGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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
    public partial class ShipManagementComponent
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ShipManagementComponent_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => ShipManagementComponent_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ShipManagementComponentCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterInstance()
        {
            return ShipManagementComponentSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ShipManagementComponentSetterTranslationCommon.Instance;

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Starfield
{
    public partial class ShipManagementComponentBinaryWriteTranslation :
        AComponentBinaryWriteTranslation,
        IBinaryWriteTranslator
    {
        public new static readonly ShipManagementComponentBinaryWriteTranslation Instance = new();

        public void Write(
            MutagenWriter writer,
            IShipManagementComponentGetter item,
            TypedWriteParams translationParams)
        {
            AComponentBinaryWriteTranslation.WriteRecordTypes(
                item: item,
                writer: writer,
                translationParams: translationParams);
            using (HeaderExport.Subrecord(writer, RecordTypes.BFCE)) { } // End Marker
        }

        public override void Write(
            MutagenWriter writer,
            object item,
            TypedWriteParams translationParams = default)
        {
            Write(
                item: (IShipManagementComponentGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

        public override void Write(
            MutagenWriter writer,
            IAComponentGetter item,
            TypedWriteParams translationParams)
        {
            Write(
                item: (IShipManagementComponentGetter)item,
                writer: writer,
                translationParams: translationParams);
        }

    }

    internal partial class ShipManagementComponentBinaryCreateTranslation : AComponentBinaryCreateTranslation
    {
        public new static readonly ShipManagementComponentBinaryCreateTranslation Instance = new ShipManagementComponentBinaryCreateTranslation();

    }

}
namespace Mutagen.Bethesda.Starfield
{
    #region Binary Write Mixins
    public static class ShipManagementComponentBinaryTranslationMixIn
    {
    }
    #endregion


}
namespace Mutagen.Bethesda.Starfield
{
    internal partial class ShipManagementComponentBinaryOverlay :
        AComponentBinaryOverlay,
        IShipManagementComponentGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => ShipManagementComponent_Registration.Instance;
        public new static ILoquiRegistration StaticRegistration => ShipManagementComponent_Registration.Instance;
        [DebuggerStepThrough]
        protected override object CommonInstance() => ShipManagementComponentCommon.Instance;
        [DebuggerStepThrough]
        protected override object CommonSetterTranslationInstance() => ShipManagementComponentSetterTranslationCommon.Instance;

        #endregion

        void IPrintable.Print(StructuredStringBuilder sb, string? name) => this.Print(sb, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected override object BinaryWriteTranslator => ShipManagementComponentBinaryWriteTranslation.Instance;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            TypedWriteParams translationParams = default)
        {
            ((ShipManagementComponentBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                translationParams: translationParams);
        }

        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected ShipManagementComponentBinaryOverlay(
            MemoryPair memoryPair,
            BinaryOverlayFactoryPackage package)
            : base(
                memoryPair: memoryPair,
                package: package)
        {
            this.CustomCtor();
        }

        public static IShipManagementComponentGetter ShipManagementComponentFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            stream = ExtractTypelessSubrecordRecordMemory(
                stream: stream,
                meta: package.MetaData.Constants,
                translationParams: translationParams,
                memoryPair: out var memoryPair,
                offset: out var offset,
                finalPos: out var finalPos);
            var ret = new ShipManagementComponentBinaryOverlay(
                memoryPair: memoryPair,
                package: package);
            ret.FillTypelessSubrecordTypes(
                stream: stream,
                finalPos: stream.Length,
                offset: offset,
                translationParams: translationParams,
                fill: ret.FillRecordType);
            return ret;
        }

        public static IShipManagementComponentGetter ShipManagementComponentFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            TypedParseParams translationParams = default)
        {
            return ShipManagementComponentFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                translationParams: translationParams);
        }

        #region To String

        public override void Print(
            StructuredStringBuilder sb,
            string? name = null)
        {
            ShipManagementComponentMixIn.Print(
                item: this,
                sb: sb,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (obj is not IShipManagementComponentGetter rhs) return false;
            return ((ShipManagementComponentCommon)((IShipManagementComponentGetter)this).CommonInstance()!).Equals(this, rhs, equalsMask: null);
        }

        public bool Equals(IShipManagementComponentGetter? obj)
        {
            return ((ShipManagementComponentCommon)((IShipManagementComponentGetter)this).CommonInstance()!).Equals(this, obj, equalsMask: null);
        }

        public override int GetHashCode() => ((ShipManagementComponentCommon)((IShipManagementComponentGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

