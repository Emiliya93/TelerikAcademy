Data Structures, Algorithms and Complexity Homework
===

**Task 1.** What is the expected running time of the following C# code? Explain why.
Assume the array's size is n.

The complexity is O(n^2), because for each n we will have n more operation over it.

**Task 2.** What is the expected running time of the following C# code?
Explain why.
Assume the input matrix has size of n * m.

The complexity is O(n*m), because for each row it loops for each column.

**Task 3.**  What is the expected running time of the following C# code?
Explain why.
Assume the input matrix has size of n * m.

The complexity is O(n*m), because for the given row in the method it loops for each column and recursively calls the same method with next row. So again for each row - each column.