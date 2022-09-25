# Application-for-Visualization-of-Sorting-Algorithms

## Short description ##

  This application was built in C# using Microsoft Visual Studio. It is made for visualizing sorting steps of algorithms. The files are neatly seperated into folders
  and the project contains a few icons that are used throughout the application. For someone to check the project out, you need to start the solution file
  Algoritmi Sortiranja.sln. Of course you need to have Visual Studio downloaded and MSVC Redistributable files for it to compile. The settings and table .txt files are 
  set to folder "Postavke" by default but you can change the path in the code as well.
  
## Algorithms
  
  | Algorithms | Pros | Cons |
  | --- | --- | --- |
  | **Bubble sort** | Popular and easy to implement.  | Does not deal well with a list containing a huge number of items. |
  | **Quick sort** | Best sorting algorithm that deals very well with large list. | Disadvantage with the worst case efficiency. |
  | **Merge sort** | It can be applied to files of any size. | Requires extra space ca. N |
  | **Insertion sort** | Simple, performs well on a small list and minimal space is required. | Does not deal well with the huge list. |
  | **Selection sort** | Performs well on a small list and no additional temporary storage is required.  | Poor efficiency when dealing with a huge list of items. |
  | **Radix sort** | Fast when the keys are short i.e. when the range of the array elements is small. | Since Radix sort depends on digits or letters, Radix sort is much less flexible than other sorts. Hence, for every different type of data it needs to be rewritten. | 
  | **Max Heap sort** | The algorithm is efficient. Performance is optimal. This implies that no other sorting algorithms can perform better in comparison. | A stable sort maintains the relative order of items that have the same key. i.e the way they are present in initial array. Heap sort is unstable sort. It might rearrange the relative order. | 
  | **Shell sort** |  Efficient for medium-size lists. | Somewhat complex algorithm, not nearly as efficient as the merge, heap, and quick sorts. |
  
## Functionalities

  | Functionality |
  | --- |
  | Enable/Disable counting the number of times an array has been accessed. |
  | Enable/Disable counting the number of times two elements of an array have been compared. |
  | Enable/Disable both of the mentioned things at once. |
  | Enable/Disable execution time in the "Poredi Algoritme" tab. |
  | Enable/Disable saving the data of comparison even after exiting the application. |
  | The application is using threading which is making the algorithms much more optimized. |
  | Amount of elements vary from the canvas's size. You can resize it to gain more elements. |
  | Using file reading/writing in C# to write everything to the .txt files. |
  | Changing the settings file while the application is running will make the changes immediately |
  
