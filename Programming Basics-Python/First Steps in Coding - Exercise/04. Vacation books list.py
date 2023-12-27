number_of_pages = int(input())
pages_read_per_hour = int(input())
days_required_to_read_all = int(input())

total_time_reading = number_of_pages / pages_read_per_hour
time_per_day_required = total_time_reading / days_required_to_read_all
time_per_day_rounded = round(time_per_day_required)

print(time_per_day_rounded)
