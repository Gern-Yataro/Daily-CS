numbers = [1, 9, 5, 3, 7, 2, 4, 8, 6]

def counting_sort(array):
  output_list = [0]*(len(array))
  number_dict = {}
  #Find range of sort dictionary
  max_number = array[0]
  min_number = array[0]
  for number in array:
    if number > max_number:
      max_number = number
    if number < min_number:
      min_number = number

  #Initialise sort dictionary
  for x in range(min_number, max_number+1):
    number_dict[x] = 0

  #Find number of occurences of each number
  for number in array:
    number_dict[number] += 1

  #Summing up key values from left to right (to get appended index)
  number_sum = 0
  for x in number_dict:
    number_dict[x] += number_sum
    number_sum = number_dict[x]

  #key values is the assigned index of value in new array
  for y in array:
    output_list[number_dict[y]-1] = y
    number_dict[y] -= 1

  return output_list

print(counting_sort(numbers))
