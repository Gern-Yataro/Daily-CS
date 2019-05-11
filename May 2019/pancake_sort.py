numbers = [8, 6, 4, 1, 3, 7, 9, 5, 2]

def pancake_sort(array):
  target_index = len(array)-1
  while target_index > 0:
    max_value = array[target_index]
    max_index = target_index
    for number in range(0, target_index):
      if array[number] > max_value:
        max_value = array[number]
        max_index = number
    array = flip(array, max_index)
    array = flip(array, target_index)
    target_index -= 1
  return array

def flip(array, end_index):
  unreversed_part = array[end_index+1:]
  reversed_part = array[end_index::-1]
  return reversed_part + unreversed_part

print(pancake_sort(numbers))
