numbers = [170, 90, 2, 802, 2, 45, 75, 66]

#Iterative, least significant digit Radix Sort
def i_lsd_radix_sort(array, max_digits):
  output_array = array
  digits = 0
  buckets = {0:[], 1:[], 2:[], 3:[], 4:[], 5:[], 6:[], 7:[], 8:[], 9:[]}

  while digits < max_digits:
    exponent = pow(10, digits)
    for number in output_array:
      bucket_index = (int)(number / exponent % 10)
      buckets[bucket_index].append(number)

    output_array.clear()
    
    for bucket in buckets:
      output_array += buckets[bucket]
      buckets[bucket].clear()
    digits += 1

  return output_array

#Recursive, most significant digit Radix sort
def r_msd_radix_sort(array, max_digits):
  if max_digits == 0:
    return array

  exponent = pow(10, max_digits-1)
  buckets = {0:[], 1:[], 2:[], 3:[], 4:[], 5:[], 6:[], 7:[], 8:[], 9:[]}
  for number in array:
    bucket_index = (int)(number / exponent % 10)
    buckets[bucket_index].append(number)

  temp_arr = []
  max_digits -= 1
  for bucket in buckets:
    temp_arr += (r_msd_radix_sort(buckets[bucket], max_digits))
  return temp_arr

print("LSD Radix Sort:", i_lsd_radix_sort(numbers, 3))
print("MSD Radix Sort:", r_msd_radix_sort(numbers, 3))
