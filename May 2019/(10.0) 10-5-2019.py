import math
numbers = [3, 7, 4, 8, 6, 2, 1, 5]

def bitonic_sort(array):
  def swap(a, b):
    array[a], array[b] = array[b], array[a]

  def comparator(start, end, comp, div, swap_type):
    index = start
    while index + comp < end:
      if swap_type == 1 and array[index] > array[index + comp]:
        swap(index, index + comp)
      if swap_type == -1 and array[index] < array[index + comp]:
        swap(index, index + comp)
      index += 1

    if div >= 2:
      comparator(start, int(end/2), int(comp/2), int(div/2), swap_type)
      comparator(int(end/2), end, int(comp/2), int(div/2), swap_type)
    
  n = len(array)
  stages = int(math.log(n, 2))
  for stage in range(1, stages+1):
    x = int(math.pow(2, stage))
    end = x
    while end <= n:
      comparator(end-x, end, int(x/2), x, 1)
      end += x
      if end <= n:
        comparator(end-x, end, int(x/2), x, -1)
        end += x

  return array

print(bitonic_sort(numbers))
