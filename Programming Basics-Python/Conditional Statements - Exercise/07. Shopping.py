budget = float(input())
video_cards = int(input())
processors = int(input())
ram_memory = int(input())

video_cards_price = video_cards * 250
processor_price = (video_cards_price * 0.35) * processors
ram_memory_price = (video_cards_price * 0.10) * ram_memory

total_sum = video_cards_price + processor_price + ram_memory_price

if video_cards > processors:
    total_sum = total_sum - (total_sum * 0.15)
if budget >= total_sum:
    print(f"You have {budget - total_sum:.2f} leva left!")
elif budget < total_sum:
    print(f"Not enough money! You need {total_sum - budget:.2f} leva more!")
