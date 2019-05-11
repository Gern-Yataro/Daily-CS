numbers = [4, 1, 6, 5, 3, 2, 9, 7, 8]

def selection_sort(array):
  for x in range(len(array)):
    min_index = x
    for y in range(x+1, len(array)):
      if array[min_index] > array[y]:
        min_index = y 
  array[x], array[min_index] = array[min_index], array[x]

  return array

print(selection_sort(numbers))
