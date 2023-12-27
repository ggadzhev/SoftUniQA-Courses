total_yards_for_greening = float(input())

total_price_for_greening = total_yards_for_greening * 7.61
discount_total_price = total_price_for_greening * 0.18
total_sum_for_service = total_price_for_greening - discount_total_price

print(f"The final price is: {total_sum_for_service} lv.")
print(f"The discount is: {discount_total_price} lv.")