numbers = [9, 8, 7, 6, 5, 4, 3, 2, 1]

def brick_sort(array):
  n = len(array)-1
  swapped = True

  while swapped == True:
    swapped = False
    for index in range(0, n, 2):
      if array[index] > array[index+1]:
        array[index], array[index+1] = array[index+1], array[index]
        swapped = True
      
    for index in range(1, n, 2):
      if array[index] > array[index+1]:
        array[index], array[index+1] = array[index+1], array[index]
        swapped = True

  return array

print(brick_sort(numbers))
