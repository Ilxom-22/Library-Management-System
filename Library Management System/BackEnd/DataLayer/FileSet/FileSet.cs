using BackEnd.Models.Common;
using System.Text.Json;

namespace BackEnd.DataLayer.FileSet;

public class FileSet<T> : List<T> where T : class, IEntity
{
    private string _fileName;
    private string _directoryName;
    private string _path;

    public FileSet(string name, string directoryName = "Database")
    {
        _fileName = $"{name.ToLower()}.json";
        _directoryName = Path.Combine(Directory.GetCurrentDirectory(), directoryName);
        _path = Path.Combine(directoryName, _fileName);

        EnsurePathExists();
    }

    public void Initialize()
    {
        var fileStream = File.Open(_path, FileMode.Open);
        var reader = new StreamReader(fileStream);
        var rawData = reader.ReadToEnd();

        if (!string.IsNullOrWhiteSpace(rawData))
        {
            Clear();
            var previousData = JsonSerializer.Deserialize<List<T>>(rawData);
            AddRange(previousData);
        }

        fileStream.Flush();
        fileStream.Close();
    }

    public void SaveChanges()
    {
        var fileStream = File.Open(_path, FileMode.Open);
        fileStream.SetLength(0);
        JsonSerializer.Serialize(fileStream, this);

        fileStream.Flush();
        fileStream.Close();
    }

    public new void Add(T item)
    {
        item.Id = Count == 0 ? 1 : this.Last().Id + 1;
        base.Add(item);
    }

    private void EnsurePathExists()
    {
        Directory.CreateDirectory(_directoryName);
        File.Open(_path, FileMode.OpenOrCreate).Close();
    }
}