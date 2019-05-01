numbers = [2, 4, 9, 1, 7, 6, 5, 8, 3]

def bubble_sort(array):
  search_length = len(array)-1
  swapped = True

  #Keeps iterating, comparing and swapping until a complete loop without swapping is detected
  while swapped == True:
    swapped = False
    for index in range(search_length):
      if array[index] > array[index+1]:
        temp = array[index+1]
        array[index+1] = array[index]
        array[index] = temp
        swapped = True
    search_length -= 1

  print("Sorted result:")
  for number in array:  
    print(number, end=" ")

bubble_sort(numbers)
