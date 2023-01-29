// See https://aka.ms/new-console-template for more information
static Dictionary<int, int> CountEachElement(int[] arr)
{
    Dictionary<int, int> result = new Dictionary<int, int>();
	foreach (var item in arr)
	{
		if (result.ContainsKey(item))
		{
			result[item]++;
		}
		else
		{
			result.Add(item, 1);
		}
	}
	return result;
}

foreach (var kvp in CountEachElement(new int[] {1,5,6,8,2,1,6,5}))
{
	Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}