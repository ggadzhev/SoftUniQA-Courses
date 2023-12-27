naylon_amount_required = int(input())
litters_paint_required = int(input())
litters_thinner_required = int(input())
hours_required_full_work = int(input())

price_naylon = (naylon_amount_required + 2) * 1.50
additional_paint = litters_paint_required + (litters_paint_required * 0.10)
paint_price = additional_paint * 14.50
price_thinner = litters_thinner_required * 5.00
price_per_container = 0.40
total_price_materials = price_naylon + paint_price + price_thinner + price_per_container
price_for_workers = (total_price_materials * 0.30) * hours_required_full_work
total_sum_work = total_price_materials + price_for_workers

print(total_sum_work)