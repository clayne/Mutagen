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
using Mutagen.Bethesda.Oblivion.Internals;
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
namespace Mutagen.Bethesda.Oblivion
{
    #region Class
    public partial class InterCellPoint :
        IInterCellPoint,
        ILoquiObjectSetter<InterCellPoint>,
        IEquatable<IInterCellPointGetter>
    {
        #region Ctor
        public InterCellPoint()
        {
            CustomCtor();
        }
        partial void CustomCtor();
        #endregion

        #region PointID
        public Int32 PointID { get; set; } = default;
        #endregion
        #region Point
        public P3Float Point { get; set; } = default;
        #endregion

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            InterCellPointMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IInterCellPointGetter rhs)) return false;
            return ((InterCellPointCommon)((IInterCellPointGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IInterCellPointGetter? obj)
        {
            return ((InterCellPointCommon)((IInterCellPointGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((InterCellPointCommon)((IInterCellPointGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

        #region Mask
        public class Mask<TItem> :
            IMask<TItem>,
            IEquatable<Mask<TItem>>
        {
            #region Ctors
            public Mask(TItem initialValue)
            {
                this.PointID = initialValue;
                this.Point = initialValue;
            }

            public Mask(
                TItem PointID,
                TItem Point)
            {
                this.PointID = PointID;
                this.Point = Point;
            }

            #pragma warning disable CS8618
            protected Mask()
            {
            }
            #pragma warning restore CS8618

            #endregion

            #region Members
            public TItem PointID;
            public TItem Point;
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
                if (!object.Equals(this.PointID, rhs.PointID)) return false;
                if (!object.Equals(this.Point, rhs.Point)) return false;
                return true;
            }
            public override int GetHashCode()
            {
                var hash = new HashCode();
                hash.Add(this.PointID);
                hash.Add(this.Point);
                return hash.ToHashCode();
            }

            #endregion

            #region All
            public bool All(Func<TItem, bool> eval)
            {
                if (!eval(this.PointID)) return false;
                if (!eval(this.Point)) return false;
                return true;
            }
            #endregion

            #region Any
            public bool Any(Func<TItem, bool> eval)
            {
                if (eval(this.PointID)) return true;
                if (eval(this.Point)) return true;
                return false;
            }
            #endregion

            #region Translate
            public Mask<R> Translate<R>(Func<TItem, R> eval)
            {
                var ret = new InterCellPoint.Mask<R>();
                this.Translate_InternalFill(ret, eval);
                return ret;
            }

            protected void Translate_InternalFill<R>(Mask<R> obj, Func<TItem, R> eval)
            {
                obj.PointID = eval(this.PointID);
                obj.Point = eval(this.Point);
            }
            #endregion

            #region To String
            public override string ToString()
            {
                return ToString(printMask: null);
            }

            public string ToString(InterCellPoint.Mask<bool>? printMask = null)
            {
                var fg = new FileGeneration();
                ToString(fg, printMask);
                return fg.ToString();
            }

            public void ToString(FileGeneration fg, InterCellPoint.Mask<bool>? printMask = null)
            {
                fg.AppendLine($"{nameof(InterCellPoint.Mask<TItem>)} =>");
                fg.AppendLine("[");
                using (new DepthWrapper(fg))
                {
                    if (printMask?.PointID ?? true)
                    {
                        fg.AppendItem(PointID, "PointID");
                    }
                    if (printMask?.Point ?? true)
                    {
                        fg.AppendItem(Point, "Point");
                    }
                }
                fg.AppendLine("]");
            }
            #endregion

        }

        public class ErrorMask :
            IErrorMask,
            IErrorMask<ErrorMask>
        {
            #region Members
            public Exception? Overall { get; set; }
            private List<string>? _warnings;
            public List<string> Warnings
            {
                get
                {
                    if (_warnings == null)
                    {
                        _warnings = new List<string>();
                    }
                    return _warnings;
                }
            }
            public Exception? PointID;
            public Exception? Point;
            #endregion

            #region IErrorMask
            public object? GetNthMask(int index)
            {
                InterCellPoint_FieldIndex enu = (InterCellPoint_FieldIndex)index;
                switch (enu)
                {
                    case InterCellPoint_FieldIndex.PointID:
                        return PointID;
                    case InterCellPoint_FieldIndex.Point:
                        return Point;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthException(int index, Exception ex)
            {
                InterCellPoint_FieldIndex enu = (InterCellPoint_FieldIndex)index;
                switch (enu)
                {
                    case InterCellPoint_FieldIndex.PointID:
                        this.PointID = ex;
                        break;
                    case InterCellPoint_FieldIndex.Point:
                        this.Point = ex;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public void SetNthMask(int index, object obj)
            {
                InterCellPoint_FieldIndex enu = (InterCellPoint_FieldIndex)index;
                switch (enu)
                {
                    case InterCellPoint_FieldIndex.PointID:
                        this.PointID = (Exception?)obj;
                        break;
                    case InterCellPoint_FieldIndex.Point:
                        this.Point = (Exception?)obj;
                        break;
                    default:
                        throw new ArgumentException($"Index is out of range: {index}");
                }
            }

            public bool IsInError()
            {
                if (Overall != null) return true;
                if (PointID != null) return true;
                if (Point != null) return true;
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

            public void ToString(FileGeneration fg, string? name = null)
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
            protected void ToString_FillInternal(FileGeneration fg)
            {
                fg.AppendItem(PointID, "PointID");
                fg.AppendItem(Point, "Point");
            }
            #endregion

            #region Combine
            public ErrorMask Combine(ErrorMask? rhs)
            {
                if (rhs == null) return this;
                var ret = new ErrorMask();
                ret.PointID = this.PointID.Combine(rhs.PointID);
                ret.Point = this.Point.Combine(rhs.Point);
                return ret;
            }
            public static ErrorMask? Combine(ErrorMask? lhs, ErrorMask? rhs)
            {
                if (lhs != null && rhs != null) return lhs.Combine(rhs);
                return lhs ?? rhs;
            }
            #endregion

            #region Factory
            public static ErrorMask Factory(ErrorMaskBuilder errorMask)
            {
                return new ErrorMask();
            }
            #endregion

        }
        public class TranslationMask : ITranslationMask
        {
            #region Members
            private TranslationCrystal? _crystal;
            public readonly bool DefaultOn;
            public bool OnOverall;
            public bool PointID;
            public bool Point;
            #endregion

            #region Ctors
            public TranslationMask(
                bool defaultOn,
                bool onOverall = true)
            {
                this.DefaultOn = defaultOn;
                this.OnOverall = onOverall;
                this.PointID = defaultOn;
                this.Point = defaultOn;
            }

            #endregion

            public TranslationCrystal GetCrystal()
            {
                if (_crystal != null) return _crystal;
                var ret = new List<(bool On, TranslationCrystal? SubCrystal)>();
                GetCrystal(ret);
                _crystal = new TranslationCrystal(ret.ToArray());
                return _crystal;
            }

            protected void GetCrystal(List<(bool On, TranslationCrystal? SubCrystal)> ret)
            {
                ret.Add((PointID, null));
                ret.Add((Point, null));
            }

            public static implicit operator TranslationMask(bool defaultOn)
            {
                return new TranslationMask(defaultOn: defaultOn, onOverall: defaultOn);
            }

        }
        #endregion

        #region Binary Translation
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => InterCellPointBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((InterCellPointBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }
        #region Binary Create
        public static InterCellPoint CreateFromBinary(
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new InterCellPoint();
            ((InterCellPointSetterCommon)((IInterCellPointGetter)ret).CommonSetterInstance()!).CopyInFromBinary(
                item: ret,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
            return ret;
        }

        #endregion

        public static bool TryCreateFromBinary(
            MutagenFrame frame,
            out InterCellPoint item,
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
            ((InterCellPointSetterCommon)((IInterCellPointGetter)this).CommonSetterInstance()!).Clear(this);
        }

        internal static InterCellPoint GetNew()
        {
            return new InterCellPoint();
        }

    }
    #endregion

    #region Interface
    public partial interface IInterCellPoint :
        IInterCellPointGetter,
        ILoquiObjectSetter<IInterCellPoint>
    {
        new Int32 PointID { get; set; }
        new P3Float Point { get; set; }
    }

    public partial interface IInterCellPointGetter :
        ILoquiObject,
        ILoquiObject<IInterCellPointGetter>,
        IBinaryItem
    {
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object? CommonSetterInstance();
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        object CommonSetterTranslationInstance();
        static ILoquiRegistration Registration => InterCellPoint_Registration.Instance;
        Int32 PointID { get; }
        P3Float Point { get; }

    }

    #endregion

    #region Common MixIn
    public static partial class InterCellPointMixIn
    {
        public static void Clear(this IInterCellPoint item)
        {
            ((InterCellPointSetterCommon)((IInterCellPointGetter)item).CommonSetterInstance()!).Clear(item: item);
        }

        public static InterCellPoint.Mask<bool> GetEqualsMask(
            this IInterCellPointGetter item,
            IInterCellPointGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            return ((InterCellPointCommon)((IInterCellPointGetter)item).CommonInstance()!).GetEqualsMask(
                item: item,
                rhs: rhs,
                include: include);
        }

        public static string ToString(
            this IInterCellPointGetter item,
            string? name = null,
            InterCellPoint.Mask<bool>? printMask = null)
        {
            return ((InterCellPointCommon)((IInterCellPointGetter)item).CommonInstance()!).ToString(
                item: item,
                name: name,
                printMask: printMask);
        }

        public static void ToString(
            this IInterCellPointGetter item,
            FileGeneration fg,
            string? name = null,
            InterCellPoint.Mask<bool>? printMask = null)
        {
            ((InterCellPointCommon)((IInterCellPointGetter)item).CommonInstance()!).ToString(
                item: item,
                fg: fg,
                name: name,
                printMask: printMask);
        }

        public static bool Equals(
            this IInterCellPointGetter item,
            IInterCellPointGetter rhs)
        {
            return ((InterCellPointCommon)((IInterCellPointGetter)item).CommonInstance()!).Equals(
                lhs: item,
                rhs: rhs);
        }

        public static void DeepCopyIn(
            this IInterCellPoint lhs,
            IInterCellPointGetter rhs)
        {
            ((InterCellPointSetterTranslationCommon)((IInterCellPointGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: default,
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IInterCellPoint lhs,
            IInterCellPointGetter rhs,
            InterCellPoint.TranslationMask? copyMask = null)
        {
            ((InterCellPointSetterTranslationCommon)((IInterCellPointGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: default,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
        }

        public static void DeepCopyIn(
            this IInterCellPoint lhs,
            IInterCellPointGetter rhs,
            out InterCellPoint.ErrorMask errorMask,
            InterCellPoint.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            ((InterCellPointSetterTranslationCommon)((IInterCellPointGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: false);
            errorMask = InterCellPoint.ErrorMask.Factory(errorMaskBuilder);
        }

        public static void DeepCopyIn(
            this IInterCellPoint lhs,
            IInterCellPointGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask)
        {
            ((InterCellPointSetterTranslationCommon)((IInterCellPointGetter)lhs).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: lhs,
                rhs: rhs,
                errorMask: errorMask,
                copyMask: copyMask,
                deepCopy: false);
        }

        public static InterCellPoint DeepCopy(
            this IInterCellPointGetter item,
            InterCellPoint.TranslationMask? copyMask = null)
        {
            return ((InterCellPointSetterTranslationCommon)((IInterCellPointGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask);
        }

        public static InterCellPoint DeepCopy(
            this IInterCellPointGetter item,
            out InterCellPoint.ErrorMask errorMask,
            InterCellPoint.TranslationMask? copyMask = null)
        {
            return ((InterCellPointSetterTranslationCommon)((IInterCellPointGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: out errorMask);
        }

        public static InterCellPoint DeepCopy(
            this IInterCellPointGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            return ((InterCellPointSetterTranslationCommon)((IInterCellPointGetter)item).CommonSetterTranslationInstance()!).DeepCopy(
                item: item,
                copyMask: copyMask,
                errorMask: errorMask);
        }

        #region Binary Translation
        public static void CopyInFromBinary(
            this IInterCellPoint item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((InterCellPointSetterCommon)((IInterCellPointGetter)item).CommonSetterInstance()!).CopyInFromBinary(
                item: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter);
        }

        #endregion

    }
    #endregion

}

namespace Mutagen.Bethesda.Oblivion.Internals
{
    #region Field Index
    public enum InterCellPoint_FieldIndex
    {
        PointID = 0,
        Point = 1,
    }
    #endregion

    #region Registration
    public partial class InterCellPoint_Registration : ILoquiRegistration
    {
        public static readonly InterCellPoint_Registration Instance = new InterCellPoint_Registration();

        public static ProtocolKey ProtocolKey => ProtocolDefinition_Oblivion.ProtocolKey;

        public static readonly ObjectKey ObjectKey = new ObjectKey(
            protocolKey: ProtocolDefinition_Oblivion.ProtocolKey,
            msgID: 135,
            version: 0);

        public const string GUID = "550dc884-f88b-403d-832e-130d9a0ddfd1";

        public const ushort AdditionalFieldCount = 2;

        public const ushort FieldCount = 2;

        public static readonly Type MaskType = typeof(InterCellPoint.Mask<>);

        public static readonly Type ErrorMaskType = typeof(InterCellPoint.ErrorMask);

        public static readonly Type ClassType = typeof(InterCellPoint);

        public static readonly Type GetterType = typeof(IInterCellPointGetter);

        public static readonly Type? InternalGetterType = null;

        public static readonly Type SetterType = typeof(IInterCellPoint);

        public static readonly Type? InternalSetterType = null;

        public const string FullName = "Mutagen.Bethesda.Oblivion.InterCellPoint";

        public const string Name = "InterCellPoint";

        public const string Namespace = "Mutagen.Bethesda.Oblivion";

        public const byte GenericCount = 0;

        public static readonly Type? GenericRegistrationType = null;

        public static readonly Type BinaryWriteTranslation = typeof(InterCellPointBinaryWriteTranslation);
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
    public partial class InterCellPointSetterCommon
    {
        public static readonly InterCellPointSetterCommon Instance = new InterCellPointSetterCommon();

        partial void ClearPartial();
        
        public void Clear(IInterCellPoint item)
        {
            ClearPartial();
            item.PointID = default;
            item.Point = default;
        }
        
        #region Binary Translation
        public virtual void CopyInFromBinary(
            IInterCellPoint item,
            MutagenFrame frame,
            RecordTypeConverter? recordTypeConverter = null)
        {
            UtilityTranslation.SubrecordParse(
                record: item,
                frame: frame,
                recordTypeConverter: recordTypeConverter,
                fillStructs: InterCellPointBinaryCreateTranslation.FillBinaryStructs);
        }
        
        #endregion
        
    }
    public partial class InterCellPointCommon
    {
        public static readonly InterCellPointCommon Instance = new InterCellPointCommon();

        public InterCellPoint.Mask<bool> GetEqualsMask(
            IInterCellPointGetter item,
            IInterCellPointGetter rhs,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            var ret = new InterCellPoint.Mask<bool>(false);
            ((InterCellPointCommon)((IInterCellPointGetter)item).CommonInstance()!).FillEqualsMask(
                item: item,
                rhs: rhs,
                ret: ret,
                include: include);
            return ret;
        }
        
        public void FillEqualsMask(
            IInterCellPointGetter item,
            IInterCellPointGetter rhs,
            InterCellPoint.Mask<bool> ret,
            EqualsMaskHelper.Include include = EqualsMaskHelper.Include.All)
        {
            if (rhs == null) return;
            ret.PointID = item.PointID == rhs.PointID;
            ret.Point = item.Point.Equals(rhs.Point);
        }
        
        public string ToString(
            IInterCellPointGetter item,
            string? name = null,
            InterCellPoint.Mask<bool>? printMask = null)
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
            IInterCellPointGetter item,
            FileGeneration fg,
            string? name = null,
            InterCellPoint.Mask<bool>? printMask = null)
        {
            if (name == null)
            {
                fg.AppendLine($"InterCellPoint =>");
            }
            else
            {
                fg.AppendLine($"{name} (InterCellPoint) =>");
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
            IInterCellPointGetter item,
            FileGeneration fg,
            InterCellPoint.Mask<bool>? printMask = null)
        {
            if (printMask?.PointID ?? true)
            {
                fg.AppendItem(item.PointID, "PointID");
            }
            if (printMask?.Point ?? true)
            {
                fg.AppendItem(item.Point, "Point");
            }
        }
        
        #region Equals and Hash
        public virtual bool Equals(
            IInterCellPointGetter? lhs,
            IInterCellPointGetter? rhs)
        {
            if (lhs == null && rhs == null) return false;
            if (lhs == null || rhs == null) return false;
            if (lhs.PointID != rhs.PointID) return false;
            if (!lhs.Point.Equals(rhs.Point)) return false;
            return true;
        }
        
        public virtual int GetHashCode(IInterCellPointGetter item)
        {
            var hash = new HashCode();
            hash.Add(item.PointID);
            hash.Add(item.Point);
            return hash.ToHashCode();
        }
        
        #endregion
        
        
        public object GetNew()
        {
            return InterCellPoint.GetNew();
        }
        
        #region Mutagen
        public IEnumerable<FormLinkInformation> GetLinkFormKeys(IInterCellPointGetter obj)
        {
            yield break;
        }
        
        public void RemapLinks(IInterCellPointGetter obj, IReadOnlyDictionary<FormKey, FormKey> mapping) => throw new NotImplementedException();
        #endregion
        
    }
    public partial class InterCellPointSetterTranslationCommon
    {
        public static readonly InterCellPointSetterTranslationCommon Instance = new InterCellPointSetterTranslationCommon();

        #region DeepCopyIn
        public void DeepCopyIn(
            IInterCellPoint item,
            IInterCellPointGetter rhs,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask,
            bool deepCopy)
        {
            if ((copyMask?.GetShouldTranslate((int)InterCellPoint_FieldIndex.PointID) ?? true))
            {
                item.PointID = rhs.PointID;
            }
            if ((copyMask?.GetShouldTranslate((int)InterCellPoint_FieldIndex.Point) ?? true))
            {
                item.Point = rhs.Point;
            }
        }
        
        #endregion
        
        public InterCellPoint DeepCopy(
            IInterCellPointGetter item,
            InterCellPoint.TranslationMask? copyMask = null)
        {
            InterCellPoint ret = (InterCellPoint)((InterCellPointCommon)((IInterCellPointGetter)item).CommonInstance()!).GetNew();
            ((InterCellPointSetterTranslationCommon)((IInterCellPointGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                item: ret,
                rhs: item,
                errorMask: null,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            return ret;
        }
        
        public InterCellPoint DeepCopy(
            IInterCellPointGetter item,
            out InterCellPoint.ErrorMask errorMask,
            InterCellPoint.TranslationMask? copyMask = null)
        {
            var errorMaskBuilder = new ErrorMaskBuilder();
            InterCellPoint ret = (InterCellPoint)((InterCellPointCommon)((IInterCellPointGetter)item).CommonInstance()!).GetNew();
            ((InterCellPointSetterTranslationCommon)((IInterCellPointGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
                ret,
                item,
                errorMask: errorMaskBuilder,
                copyMask: copyMask?.GetCrystal(),
                deepCopy: true);
            errorMask = InterCellPoint.ErrorMask.Factory(errorMaskBuilder);
            return ret;
        }
        
        public InterCellPoint DeepCopy(
            IInterCellPointGetter item,
            ErrorMaskBuilder? errorMask,
            TranslationCrystal? copyMask = null)
        {
            InterCellPoint ret = (InterCellPoint)((InterCellPointCommon)((IInterCellPointGetter)item).CommonInstance()!).GetNew();
            ((InterCellPointSetterTranslationCommon)((IInterCellPointGetter)ret).CommonSetterTranslationInstance()!).DeepCopyIn(
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

namespace Mutagen.Bethesda.Oblivion
{
    public partial class InterCellPoint
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => InterCellPoint_Registration.Instance;
        public static InterCellPoint_Registration Registration => InterCellPoint_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => InterCellPointCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterInstance()
        {
            return InterCellPointSetterCommon.Instance;
        }
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => InterCellPointSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IInterCellPointGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object IInterCellPointGetter.CommonSetterInstance() => this.CommonSetterInstance();
        [DebuggerStepThrough]
        object IInterCellPointGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

    }
}

#region Modules
#region Binary Translation
namespace Mutagen.Bethesda.Oblivion.Internals
{
    public partial class InterCellPointBinaryWriteTranslation : IBinaryWriteTranslator
    {
        public readonly static InterCellPointBinaryWriteTranslation Instance = new InterCellPointBinaryWriteTranslation();

        public static void WriteEmbedded(
            IInterCellPointGetter item,
            MutagenWriter writer)
        {
            writer.Write(item.PointID);
            Mutagen.Bethesda.Binary.P3FloatBinaryTranslation.Instance.Write(
                writer: writer,
                item: item.Point);
        }

        public void Write(
            MutagenWriter writer,
            IInterCellPointGetter item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            WriteEmbedded(
                item: item,
                writer: writer);
        }

        public void Write(
            MutagenWriter writer,
            object item,
            RecordTypeConverter? recordTypeConverter = null)
        {
            Write(
                item: (IInterCellPointGetter)item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }

    public partial class InterCellPointBinaryCreateTranslation
    {
        public readonly static InterCellPointBinaryCreateTranslation Instance = new InterCellPointBinaryCreateTranslation();

        public static void FillBinaryStructs(
            IInterCellPoint item,
            MutagenFrame frame)
        {
            item.PointID = frame.ReadInt32();
            item.Point = Mutagen.Bethesda.Binary.P3FloatBinaryTranslation.Instance.Parse(frame: frame);
        }

    }

}
namespace Mutagen.Bethesda.Oblivion
{
    #region Binary Write Mixins
    public static class InterCellPointBinaryTranslationMixIn
    {
        public static void WriteToBinary(
            this IInterCellPointGetter item,
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((InterCellPointBinaryWriteTranslation)item.BinaryWriteTranslator).Write(
                item: item,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

    }
    #endregion


}
namespace Mutagen.Bethesda.Oblivion.Internals
{
    public partial class InterCellPointBinaryOverlay :
        BinaryOverlay,
        IInterCellPointGetter
    {
        #region Common Routing
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ILoquiRegistration ILoquiObject.Registration => InterCellPoint_Registration.Instance;
        public static InterCellPoint_Registration Registration => InterCellPoint_Registration.Instance;
        [DebuggerStepThrough]
        protected object CommonInstance() => InterCellPointCommon.Instance;
        [DebuggerStepThrough]
        protected object CommonSetterTranslationInstance() => InterCellPointSetterTranslationCommon.Instance;
        [DebuggerStepThrough]
        object IInterCellPointGetter.CommonInstance() => this.CommonInstance();
        [DebuggerStepThrough]
        object? IInterCellPointGetter.CommonSetterInstance() => null;
        [DebuggerStepThrough]
        object IInterCellPointGetter.CommonSetterTranslationInstance() => this.CommonSetterTranslationInstance();

        #endregion

        void IPrintable.ToString(FileGeneration fg, string? name) => this.ToString(fg, name);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected object BinaryWriteTranslator => InterCellPointBinaryWriteTranslation.Instance;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        object IBinaryItem.BinaryWriteTranslator => this.BinaryWriteTranslator;
        void IBinaryItem.WriteToBinary(
            MutagenWriter writer,
            RecordTypeConverter? recordTypeConverter = null)
        {
            ((InterCellPointBinaryWriteTranslation)this.BinaryWriteTranslator).Write(
                item: this,
                writer: writer,
                recordTypeConverter: recordTypeConverter);
        }

        public Int32 PointID => BinaryPrimitives.ReadInt32LittleEndian(_data.Slice(0x0, 0x4));
        public P3Float Point => P3FloatBinaryTranslation.Read(_data.Slice(0x4, 0xC));
        partial void CustomFactoryEnd(
            OverlayStream stream,
            int finalPos,
            int offset);

        partial void CustomCtor();
        protected InterCellPointBinaryOverlay(
            ReadOnlyMemorySlice<byte> bytes,
            BinaryOverlayFactoryPackage package)
            : base(
                bytes: bytes,
                package: package)
        {
            this.CustomCtor();
        }

        public static InterCellPointBinaryOverlay InterCellPointFactory(
            OverlayStream stream,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            var ret = new InterCellPointBinaryOverlay(
                bytes: stream.RemainingMemory.Slice(0, 0x10),
                package: package);
            int offset = stream.Position;
            stream.Position += 0x10;
            ret.CustomFactoryEnd(
                stream: stream,
                finalPos: stream.Length,
                offset: offset);
            return ret;
        }

        public static InterCellPointBinaryOverlay InterCellPointFactory(
            ReadOnlyMemorySlice<byte> slice,
            BinaryOverlayFactoryPackage package,
            RecordTypeConverter? recordTypeConverter = null)
        {
            return InterCellPointFactory(
                stream: new OverlayStream(slice, package),
                package: package,
                recordTypeConverter: recordTypeConverter);
        }

        #region To String

        public void ToString(
            FileGeneration fg,
            string? name = null)
        {
            InterCellPointMixIn.ToString(
                item: this,
                name: name);
        }

        #endregion

        #region Equals and Hash
        public override bool Equals(object? obj)
        {
            if (!(obj is IInterCellPointGetter rhs)) return false;
            return ((InterCellPointCommon)((IInterCellPointGetter)this).CommonInstance()!).Equals(this, rhs);
        }

        public bool Equals(IInterCellPointGetter? obj)
        {
            return ((InterCellPointCommon)((IInterCellPointGetter)this).CommonInstance()!).Equals(this, obj);
        }

        public override int GetHashCode() => ((InterCellPointCommon)((IInterCellPointGetter)this).CommonInstance()!).GetHashCode(this);

        #endregion

    }

}
#endregion

#endregion

