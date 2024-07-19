﻿using Mutagen.Bethesda.Plugins.Exceptions;
using Noggog;

namespace Mutagen.Bethesda.Assets;

public readonly struct DataRelativeAssetPath : IEquatable<DataRelativeAssetPath>, IComparable<DataRelativeAssetPath> 
{
    public static readonly string NullPath = string.Empty;
    public static readonly StringComparison PathComparison = StringComparison.OrdinalIgnoreCase;
    public static readonly StringComparer PathComparer = StringComparer.FromComparison(PathComparison);
    public const string DataDirectory = "Data";
    private static readonly string DataPrefix = DataDirectory + System.IO.Path.DirectorySeparatorChar;
    private static readonly string DataPrefixAlt = DataDirectory + System.IO.Path.AltDirectorySeparatorChar;
    private static readonly string DataInfix = System.IO.Path.DirectorySeparatorChar + DataDirectory + System.IO.Path.DirectorySeparatorChar;
    private static readonly string DataInfixAlt = System.IO.Path.AltDirectorySeparatorChar + DataDirectory + System.IO.Path.AltDirectorySeparatorChar;
    private static readonly int DataPrefixLength = DataDirectory.Length + 1;

    public string Path { get; }

    /// <summary>
    /// Extension of the asset
    /// </summary>
    public string Extension => System.IO.Path.GetExtension(Path);

    public bool IsNull => Path == NullPath;

    public DataRelativeAssetPath(string rawPath)
    {
        if (System.IO.Path.IsPathRooted(rawPath))
        {
            AssertHasDataDirectory(rawPath);
        }
        Path = ConvertToDataRelativePath(rawPath);
    }

    private void AssertHasDataDirectory(FilePath filePath)
    {
        var dir = filePath.Directory;
        while (dir != null)
        {
            if (dir.Value.Name.String.Equals(DataDirectory, PathComparison))
            {
                return;
            }

            dir = dir.Value.Directory;
        }

        throw new AssetPathMisalignedException(filePath.Path, "Absolute path did not have Data folder within it.");
    }

    private static string ConvertToDataRelativePath(ReadOnlySpan<char> inputPath)
    {
        Span<char> mySpan = stackalloc char[inputPath.Length];
        inputPath.CopyTo(mySpan);
        IFileSystemExt.CleanDirectorySeparators(mySpan);
        
        ReadOnlySpan<char> path = mySpan;
        
        // Reduce all absolute paths to the path under data directory
        if (path.Contains(System.IO.Path.VolumeSeparatorChar))
        {
            var dataDirectoryIndex = path.IndexOf(DataInfix, PathComparison);
            if (dataDirectoryIndex != -1)
            {
                path = path[(dataDirectoryIndex + DataInfix.Length)..];
            }
            else
            {
                dataDirectoryIndex = path.IndexOf(DataInfixAlt, PathComparison);
                if (dataDirectoryIndex != -1)
                {
                    path = path[(dataDirectoryIndex + DataInfixAlt.Length)..];
                }
            }
        }

        path = path
            .TrimStart(System.IO.Path.DirectorySeparatorChar)
            .TrimStart(System.IO.Path.AltDirectorySeparatorChar);

        // Can be replaced with a version of TrimStart that takes the string comparison into account
        if (path.StartsWith(DataPrefix, PathComparison))
        {
            path = path[DataPrefixLength..];
        }
        else if (path.StartsWith(DataPrefixAlt, PathComparison))
        {
            path = path[DataPrefixLength..];
        }

        return path.ToString();
    }

    public override string ToString()
    {
        return Path;
    }

    public override int GetHashCode()
    {
        return Path.GetHashCode(PathComparison);
    }

    public override bool Equals(object? obj)
    {
        return obj is DataRelativeAssetPath other && Equals(other);
    }

    public bool Equals(DataRelativeAssetPath other)
    {
        return PathComparer.Equals(Path, other.Path);
    }

    public int CompareTo(DataRelativeAssetPath other)
    {
        return PathComparer.Compare(Path, other.Path);
    }

    public static bool operator ==(DataRelativeAssetPath lhs, DataRelativeAssetPath rhs)
    {
        return lhs.Equals(rhs);
    }

    public static bool operator !=(DataRelativeAssetPath lhs, DataRelativeAssetPath rhs)
    {
        return !lhs.Equals(rhs);
    }

    public static implicit operator DataRelativeAssetPath(FileInfo info)
    {
        return new FilePath(info.FullName);
    }

    public static implicit operator DataRelativeAssetPath(string path)
    {
        return new DataRelativeAssetPath(path);
    }

    public static implicit operator DataRelativeAssetPath(FilePath path)
    {
        return new DataRelativeAssetPath(path);
    }
}
