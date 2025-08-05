## Methods:
```
IList<T>.GetRandomItem()
IList<T>.GetFirst()
IList<T>.GetLast()
```

## Example
```
using ListHelper;

var numbers = new List<int> { 10, 30, 75, -5 };

Console.WriteLine(numbers.GetRandomItem()); // ???

Console.WriteLine(numbers.GetFirst()); // 10
Console.WriteLine(numbers.GetLast()); // -5
```
