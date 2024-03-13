using System;
using System.IO;

public class Journal
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry i in _entries)
        {
            Console.WriteLine($"Date: {i._date} - Prompt: {i._promptText}");
            Console.WriteLine(i._entryText);
        }
    }
     public void SaveToFile(string file)
    {
           using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine("Date,Prompt,Entry");
            foreach (Entry entry in _entries)
            {
                writer.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
            }
        }
    }

     public void LoadToFile(string file)
    {
         string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                };
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Data loaded from file");
        

    }

}