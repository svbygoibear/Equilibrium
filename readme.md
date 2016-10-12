#Equilibrium
##Synopsis
"An equilibrium index of an array is any index of that array and the sum of the lower indexes value is equal to the sum of the higher indexes value. That means if "i" is called the equilibrium index of array arr, then i should be 0 =< i =<arr.Length and arr[0]+arr[1]+.....+arr[i-1] = arr[i+1]+arr[i+2]+....+arr[arr.Length-1]."

##Code Example
###Assignment
Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index are equal to the sum of all the items to the right of the index.

###Example Output
Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12] the output would be "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

###Assumptions/Constraints
From the instructions given, the following assumptions can be deducted from it:
- Constraints: 0 <= N <= 100 000
- If no index exists then output -1

###Code Snippet
Here the input can be read from a text file, but for the anagram checker you can just use a list of string that originates from anywhere else as well:
```javascript
var path = Path.Combine(Directory.GetCurrentDirectory().ToString(), "wordlist.txt");
var words = path.readFile();
```

Using the list of string, which is our "anagram library", we can now identify all the anagrams for a specific input:
```javascript
var input = "horse";
var anagramsFound = getAllAnagrams(words, input); 
```

This will yeild the following results in the anagramsFound list:
```
heros
horse
shore
```


##Installation
To run this app, you'll need .NET 4.5 or higher installed on your machine, and to open up the project file you'll need Visual Studio. Other than that, no installation required. Microsoft .NET Framework 4.5 can be installed by downloading it from the microsoft website.

##Contributors
Feel free to pop me a message or flag an issue if you come across it - I'll see what I can do about it.

##License

Copyright © `2016` `Simone van Buuren`

Permission is hereby granted, free of charge, to any person
obtaining a copy of this software and associated documentation
files (the “Software”), to deal in the Software without
restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the
Software is furnished to do so, subject to the following
conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
OTHER DEALINGS IN THE SOFTWARE.