numbers = [0.19, 0.60, 0.57, 0.51, 0.87, 0.52, 0.43, 0.56, 0.70, 0.40, 0.03, 0.59, 0.28, 0.46, 0.20, 0.08, 0.99, 0.35,  0.57, 0.55]

def bucket_sort(array):

  output_array = []
  buckets = {0: [], 1: [], 2: [], 3: [], 4: [], 5: [], 6: [], 7: [], 8: [], 9: []}

  #Put each number into the assigned bucket
  for number in array:
    bucket_index = (int)(number*10 % 10)
    buckets[bucket_index].append(number)

  #Use insertion sort for each bucket
  for x in range(0, 10):
    for y in range(1, len(buckets[x])):
      while y > 0 and buckets[x][y] < buckets[x][y-1]:
        buckets[x][y], buckets[x][y-1] = buckets[x][y-1], buckets[x][y]
        y -= 1
    #Merge numbers in each bucket together
    output_array += buckets[x]

  return output_array

print(bucket_sort(numbers))
