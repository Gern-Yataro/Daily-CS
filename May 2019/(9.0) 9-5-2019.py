numbers = [6, 7, 9, 3, 5, 4, 1, 0, 8, 2]

def shell_sort(array):
  #Initialise gaps
  gaps = []
  temp_gap = len(array)-1
  while temp_gap >= 1:
    gaps.append(temp_gap)
    temp_gap = (int)(temp_gap/2.25)
    if temp_gap < 1:
      gaps.append(1)
      break
  
  for gap in gaps:
    for index in range(gap, len(array), gap):
      while index >= gap and array[index] < array[index-gap]:
        array[index], array[index-gap] = array[index-gap], array[index]
        index -= gap

  return array

print(shell_sort(numbers))
