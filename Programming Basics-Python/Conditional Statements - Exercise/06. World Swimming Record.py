record_in_seconds = float(input())
length_meters = float(input())
time_in_seconds = float(input())
additional_time_added = (length_meters // 15) * 12.5
time_required = length_meters * time_in_seconds
total_time = time_required + additional_time_added

if total_time < record_in_seconds:
    print(f'Yes, he succeeded! The new world record is {total_time:.2f} seconds.')
else:
    print(f'No, he failed! He was {total_time - record_in_seconds:.2f} seconds slower.')
