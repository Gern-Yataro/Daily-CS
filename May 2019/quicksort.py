numbers = [5, 3, 9, 8, 1, 7, 2, 4, 6]

def quick_sort(array):
	if len(array) == 1 or len(array) == 0:
		return array
	
	pivot = 0
	left_point = 1
	right_point = len(array)-1
	while left_point < right_point:
		while array[left_point] < array[pivot]:
			left_point += 1
		while array[right_point] > array[pivot]:
			right_point -= 1
		if left_point < right_point:
			array[left_point], array[right_point] = array[right_point], array[left_point]
	array[pivot], array[right_point] = array[right_point], array[pivot]
	pivot = right_point
	temparr1 = quick_sort(array[:right_point])
	temparr2 = quick_sort(array[right_point+1:])
	return temparr1 + [array[pivot]] + temparr2
	
print(quick_sort(numbers))