numbers = [2, 4, 6, 8, 9, 7, 5, 3, 1]

def comb_sort(array):
  gap = len(array)
  swapped = True

  while gap != 1 or swapped == True:
    index = 0
    swapped = False

    while index + gap < len(array):
      if array[index] > array[index + gap]:      
        array[index], array[index + gap] = array[index + gap], array[index]
        swapped = True
      index += 1

    gap = int(gap/1.3)
    if gap < 1:
      gap = 1

  return array

print(comb_sort(numbers))
