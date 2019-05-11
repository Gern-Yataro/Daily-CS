numbers = [5, 6, 9, 2, 4, 7, 8, 1, 3]

def quick_sort(array):
  if len(array)==1 or len(array)==0:
    return array
  left = -1
  right = len(array)
  pivot = array[right-1]

  #Sweep through array, if a value smaller than pivot is found, move to leftmost of array, in front of previously smaller than pivot values
  for x in range(0, right):
    if array[x] < pivot:
      left += 1
      array[x], array[left] = array[left], array[x]

  #Move pivot value to the front of all values smaller than pivot
  array[right-1], array[left+1] = array[left+1], array[right-1]

  #Split array into before and after pivot and call sort recursively
  temparr1 = quick_sort(array[:left+1])
  temparr2 = quick_sort(array[left+2:])
  
  return temparr1 + [pivot] + temparr2

print(quick_sort(numbers))
