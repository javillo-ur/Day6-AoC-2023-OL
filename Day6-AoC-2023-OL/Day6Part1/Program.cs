Console.WriteLine(new List<string[]>(){File.ReadAllLines("input.txt")}.Select(j =>
    new Tuple<List<int>,List<int>>(j[0].Split(" ").Where(r => int.TryParse(r, out _)).Select(r => int.Parse(r)).ToList(), j[1].Split(" ").Where(r => int.TryParse(r, out _)).Select(r => int.Parse(r)).ToList()))
    .Select(t => t.Item1.Zip(t.Item2).ToList())
    .Select(j => j.Aggregate(1, (previous, current) => previous * 
        Enumerable.Range(0, current.First).Where(t => t*(current.First - t) > current.Second).Count())).First());