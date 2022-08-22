using System;
using System.Runtime.CompilerServices;

public static class Extensions
{
	public static Motorcycle FirstOrDefault(this IEnumerable<Motorcycle> motorcycles, Func<Motorcycle, bool> predicate)
	{
		foreach (var motorcycle in motorcycles)
			if (predicate(motorcycle))
				return motorcycle;

		return default(Motorcycle);
	}
}
