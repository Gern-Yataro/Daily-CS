numbers = [4, 1, 6, 5, 3, 2, 9, 7, 8]

def insertion_sort(array):
  for index in range(1, len(array)):
    if array[index] < array[index-1]:
      for y in range(0, index):
        if array[y] > array[index]:
          array.insert(y, array.pop(index))   
          break;

  for z in array:
    print(z, end=" ")

insertion_sort(numbers)
