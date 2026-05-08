# 🔑 Core Concepts

- **Algorithm** = step-by-step recipe for solving a problem.

- **Deterministic** = same input → same output.

- **Time Complexity** = growth of runtime with input size.

- **Space Complexity** = growth of memory usage with input size.

- **Big O Notation** = describes asymptotic behavior (ignore constants, focus on growth).


*********************************************************************************

# ⚡ Common Complexities

| Complexity | Example | Notes |
|------------|----------|--------|
| O(1) | Accessing array element | Constant time |
| O(log n) | Binary Search | Input halves each step |
| O(n) | Linear search | Iterates once over input |
| O(n log n) | Merge Sort, Quick Sort | Efficient sorting |
| O(n²) | Nested loops | Compare all pairs |
| O(2ⁿ) | Recursive subset generation | Exponential growth |



## Question 1
**Why ignore constants in Big O?**

**Answer:**  
Because Big O focuses on growth rate as input → ∞. Whether O(n) or O(5n), both scale linearly.

## Question 2
**Difference between O(n) and O(log n)?**

**Answer:**  
O(n) grows linearly (searching all elements).
O(log n) grows logarithmically (binary search halves input each step).

## Question 3
**Can an algorithm be O(1) but still slow?**

**Answer:**  
Yes. Example: O(5000000) = constant time, but practically heavy. Complexity ≠ actual runtime.

## Question 4
**Best vs Worst Case?**

**Answer:**  
Always explain worst case in interviews. Example: QuickSort best case O(n log n), worst case O(n²).

## Question 5
**Why is O(n log n) important?**

**Answer:**  
It’s the complexity of efficient sorting algorithms (Merge Sort, Quick Sort). Interviewers love this.

## Question 5
**Space vs Time Tradeoff?**

**Answer:**  
HashMap lookup is O(1) time but uses O(n) space. Sometimes we sacrifice memory for speed.