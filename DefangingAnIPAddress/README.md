# Problem Name: Defanging an IP Address
- Side note: Defanging and IP address is making it so that an unsuspecting user doesn't accidentally click on a malicious IP address.

## My journey
- I didn't know about the `.Replace()` function on strings so I did it the hard way first. 
- I explored how to iterate through a string using `for` and `foreach` loops.
- Strings into Arrays
    - I explored how to turn each character in a string into an array of chars.
    - I also made sure I knew how to put them back together.
    - Chars are single characters and in C# once you make an array you can't change its size. So I wouldn't be able to put `[` and `]` on either side of the `.`
    - The solution to this line of thinking was using a `List<>`.
- String into a `List<>`
    - It's easy to make a list of Chars from a string.
    - If you want to make a list of individual strings you have to cast them using `.ToString()` as you add them.
- Easy to change items in a list of strings
    - A simple for loops to search for each `.` and turn them into `[.]`
- The `string.Join(string, string[])` method is a simple way to turn all the elements of a list back into a single string.

## Easy solution
- After I found my hard way then I looked up the answer and in C# it's stupid easy.
    - `address.Replace(".", @"[.]")` does all the steps above in 1 line of code. (it's faster and uses less memory)