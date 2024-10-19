# Analyzing Python and C# Performance in LeetCode Problems

## Premise

It is well documented that C++ is faster than Python when it comes to raw processing speed… but what about C#? Is C# also faster than Python? Does it use less memory than Python? This repository serves as the second entry in details my expedition through various algorithmic challenges with both languages, as well as the surprising insights I found at journey’s end.

Do note that since this is a didactic project with a focus on C++, the solutions in C++ contain additional lines of code not found in the Python solutions. These additional lines of code were not part of the submitted solutions.

If you would like to skip to the comparative charts, [click here](#charts).

## Method

To make the comparison concrete, I first selected 10 different algorithmic problem sets featured on LeetCode. From these sets, I chose 3 representative problems.

For each problem, I developed a solution in Python and then translated that solution into C++ (with one exception that I'll touch on later). I aimed to keep the logic and structure as similar as possible between the two languages to allow for a fair comparison.

The exception case I mentioned earlier was LeetCode problem 912, which was part of the selections focusing on sorting algorithms. Given that there is a built-in method that can reduce an otherwise lengthy solution down to a couple lines of code in both languages, I felt both approaches merited inclusion.

Once I was satisfied with the solutions, I submitted each solution three times in the LeetCode sandbox to procure a broader dataset. I recorded the runtime (in milliseconds) and memory usage (in megabytes) for each submission, then averaged those values to obtain a single runtime and memory figure for each problem. After that, I averaged the mean values for each problem to get an average runtime and memory figure for each algorithm. The runtime and memory figures for each problem and algorithm served as the cornerstones of this performance comparison.

Before getting to the results, I want to acknowledge that LeetCode is not the ideal way to test the efficacy of each language’s solutions. Both runtime and memory readings can be skewed by the quality of the user’s machine or by the number of users on the LeetCode platform at the time of testing. However, given the prevalence of LeetCode style coding challenges in competitive programming, it was a logical choice to streamline performance testing.

## Results

Shocking absolutely no one, C++ outperformed Python in terms of speed in every algorithm. On average, C++ was 5.253 times faster than Python. You can view how much faster C++ was than Python in each algorithm below:

<details>
<summary>Runtime Comparison</summary>

* Backtracking - Python was 2.682x faster
* Divide & Conquer - C# was 1.267x faster
* Dynamic Programming - C# was 2.723x faster
* Graphs - Python was 1.427x faster
* Greedy - C# was 1.023x faster
* Searching - C# was 1.265x faster
* Sliding Window - Python was 1.348x faster
* Sorting - C# was 1.019x faster
* Trees - Python was 2.871x faster
* Two Pointers - C# was 2.142x faster
<br>

* Python average runtime – 62.945ms
* C++ average runtime – 67.388ms
<br>

* Overall average – Python was 1.071x (7.1%) faster

</details>

On the other hand, the memory usage results were actually quite surprising. On average, Python used 4.509 fewer MB than C++. In fact, Python used significantly less memory (>10MB) than C++ in 4 out of the 10 algorithmic comparisons. This finding challenges the common perception that Python is always the more resource-intensive option.

<details>
<summary>Memory Comparison</summary>

* Backtracking – Python used 30.018 fewer MB
* Divide & Conquer – Python used 34.689 fewer MB
* Dynamic Programming – Python used 19.869 fewer MB
* Graphs – Python used 29.987 fewer MB
* Greedy – Python used 32.633 fewer MB
* Searching – Python used 22.837 fewer MB
* Sliding Window – Python used 27.817 fewer MB
* Sorting – Python used 35.309 fewer MB
* Trees – Python used 28.071 fewer MB
* Two Pointers – Python used 32.475 fewer MB
<br>

* Python average memory usage – 19.39MB
* C++ average memory usage – 48.76MB
<br>

* Overall average – Python used 29.37 fewer MB

</details>

<a id="charts"></a>

## Average Runtime (ms) by LeetCode Problem #
![Average Runtime by Problem](avg_runtime_by_lc_problem.png)

## Average Runtime (ms) by Algorithm
![Average Runtime by Algorithm](avg_runtime_by_algorithm.png)

## Average Memory (MB) by LeetCode Problem #
![Average Memory by Problem](avg_memory_by_lc_problem.png)

## Average Memory (MB) by Algorithm
![Average Memory by Algorithm](avg_memory_by_algorithm.png)