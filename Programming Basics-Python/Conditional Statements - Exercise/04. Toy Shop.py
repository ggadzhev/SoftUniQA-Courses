excursion_price = float(input())
total_puzzles = int(input())
talking_dolls = int(input())
fluffy_bears = int(input())
total_minions = int(input())
total_toy_trucks = int(input())


total_toys_sum = total_puzzles * 2.60 + \
                 talking_dolls * 3.00 + \
                 fluffy_bears * 4.10 + \
                 total_minions * 8.20 + \
                 total_toy_trucks * 2.00

total_toys_amount = total_puzzles + talking_dolls + fluffy_bears + total_minions + total_toy_trucks

if total_toys_amount >= 50:
    discount_price = total_toys_sum * 0.25
    overall_amount = total_toys_sum - discount_price
    rent = overall_amount * 0.10
    total_earnings = overall_amount - rent
    money_left = total_earnings - excursion_price
    print(f'Yes! {money_left:.2f} lv left.')
elif total_toys_amount < 50:
    rent = total_toys_sum * 0.10
    total_earnings = total_toys_sum - rent
    money_needed = excursion_price - total_earnings
    print(f'Not enough money! {money_needed:.2f} lv needed.')



