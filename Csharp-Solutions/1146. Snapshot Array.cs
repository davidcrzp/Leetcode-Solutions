using System;
using System.Collections;


class Program
{
    static void Main(string[] args)
    {
        SnapshotArray snapshot = new SnapshotArray(4);
        snapshot.Snap();
        snapshot.Snap();
        Console.WriteLine(snapshot.Get(1, 2));
        snapshot.Set(2, 4);
        snapshot.Snap();
        snapshot.Set(1, 4);
    }
}
public class SnapshotArray
{

    List<List<(int, int)>> list;
    int id = 0;
    public SnapshotArray(int length)
    {
        list = new List<List<(int, int)>>(length);
        for (int i = 0; i < length; i++)
        {
            list.Add(new List<(int, int)>());
            list[i].Add((0, 0));
        }
    }

    public void Set(int index, int val)
    {
        list[index].Add((id, val));
    }

    public int Snap()
    {
        return id++;
    }

    public int Get(int index, int snap_id)
    {
        var changes = list[index];
        var l = 0;
        var r = changes.Count - 1;
        while (l < r)
        {
            var mid = (l + r + 1) / 2;
            if (changes[mid].Item1 <= snap_id)
            {
                l = mid;
            }
            else
            {
                r = mid - 1;
            }
        }

        return changes[l].Item2;
    }
}
