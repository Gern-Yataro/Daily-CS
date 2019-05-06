numbers = [2, 9, 7, 5, 3, 4, 1, 6, 8]

def cocktail_sort(array):
  n = len(array)
  m = -1
  swapped = True
  
  while n > 0 and swapped == True:
    swapped = False
    #Back to front
    for index in range (m+1, n):
      if array[index] < array[index-1]:
        array[index], array[index-1] = array[index-1], array[index]
        swapped = True 
    n -= 1
    #Front to back
    for index in range (n-1, m+1, -1):
      if array[index] < array[index-1]:
        array[index], array[index-1] = array[index-1], array[index]
        swapped = True 
    m += 1
  return array

print(cocktail_sort(numbers))
