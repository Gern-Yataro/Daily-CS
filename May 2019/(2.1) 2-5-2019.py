numbers = [4, 1, 6, 5, 3, 2, 9, 7, 8]

def insertion_sort(array):
  for index in range(1, len(array)):
    while array[index] < array[index-1] and index>0:
       array[index], array[index-1] = array[index-1], array[index]
       index -= 1

  return array

print(insertion_sort(numbers))

