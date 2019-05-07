numbers = [9, 8, 7, 6, 5, 4, 3, 2, 1]

def cycle_sort(array):
  for cycle_start in range(0, len(array)):
    cycle_number = array[cycle_start]
    index = 0

    #Find the index of target value, index must be larger than index of all previously smaller values
    for x in range(0, len(array)):
      if cycle_number > array[x]:
        index += 1
    
    #If the value is already in correct position,
    if cycle_start == index:
      continue

    #To deal with duplicates by shifting index to front once
    while cycle_number == array[index]:
      index += 1

    array[index], cycle_number = cycle_number, array[index]

    #If the displaced value does not belong to the initial array position
    while index != cycle_start:
      index = cycle_start
      for x in range(cycle_start, len(array)-1):
        if cycle_number > array[x]:
          index += 1

      while cycle_number == array[index]:
        index += 1

      array[index], cycle_number = cycle_number, array[index]

  return array

print(cycle_sort(numbers))
