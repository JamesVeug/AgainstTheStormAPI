
namespace ATS_API.SaveLoading;

/// <summary>
/// Represents the state of a save file.
/// </summary>
public enum SaveFileState
{
    /// <summary>
    /// Indicates that the save file is new. If the save data does not exist, 
    /// a new file is created instead of loading an existing one.
    /// This state signifies that the <see cref="SaveData"/> is newly created.
    /// You may need to perform initialization when receiving this flag.
    /// </summary>
    NewFile,

    /// <summary>
    /// Indicates that the save data was loaded from an existing save file.
    /// This state is used when the save file already exists and is not newly created.
    /// </summary>
    LoadedFile,
}