numbers = [2, 5, 7, 6, 4, 1, 3, 9, 8]

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

print(heap_sort(numbers))
