numbers = [4, 1, 6, 5, 3, 2, 9, 7, 8]

def selection_sort(array, index=0):
  if index == len(array)-1:
    print("Sorted numbers: ")
    for number in array:
      print(number, end=" ")
    return

  min_index = index
  for a in range(index+1, len(array)):
    if array[min_index] > array[a]:
      min_index = a
  array[index], array[min_index] = array[min_index], array[index]

  index += 1
  selection_sort(array, index)

selection_sort(numbers)
