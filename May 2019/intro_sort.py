import math
numbers = [5, 1, 9, 6, 2, 4, 10, 7, 8, 3]

#main function
#depth is not a required parameter
def intro_sort(array, depth=None):
  n = len(array)
  if depth == None:
    depth = 2*math.floor(math.log(n))

  if n <= 16:
    array = insertion_sort(array)
    return array

  if depth == 0:
    array = heap_sort(array)
    return array

  else:
    depth -= 1
    pivot = partition(array)
    temp_arr1 = intro_sort(array[:pivot], depth)
    temp_arr2 = intro_sort(array[pivot+1:], depth)
    array = temp_arr1 + temp_arr2
  return array

#auxillary functions
def insertion_sort(array):
  for index in range(1, len(array)):
    while array[index] < array[index-1] and index>0:
       array[index], array[index-1] = array[index-1], array[index]
       index -= 1

  return array

def heap_sort(array):
  n = len(array)
  for i in range((int)(n/2), -1, -1):
    heapify(array, i, n)
  for j in range(n-1, -1, -1):
    array[0], array[j] = array[j], array[0]
    heapify(array, 0, j)

  return array

def heapify(array, parent, heap_size):
  largest = parent
  left_child = 2*parent + 1
  right_child = 2*parent + 2

  if left_child < heap_size and array[left_child] > array[largest]:
    largest = left_child
  if right_child < heap_size and array[right_child] > array[largest]:
    largest = right_child
  if largest != parent:
    array[parent], array[largest] = array[largest], array[parent]
    heapify(array, largest, heap_size)

def partition(array):
  left = -1
  right = len(array)
  pivot = array[len(array)-1]

  for x in range(0, right):
    if array[x] < pivot:
      left += 1
      array[x], array[left] = array[left], array[x]

  array[right-1], array[left+1] = array[left+1], array[right-1]

  return left+1

print(intro_sort(numbers))
