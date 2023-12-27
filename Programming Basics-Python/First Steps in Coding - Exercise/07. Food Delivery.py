number_chicken_menus = int(input())
number_fish_menus = int(input())
number_veg_menus = int(input())

price_chicken_menus = number_chicken_menus * 10.35
price_fish_menus = number_fish_menus * 12.40
price_veg_menus = number_veg_menus * 8.15
total_menu_price = price_veg_menus + price_fish_menus + price_chicken_menus
desert_price = total_menu_price * 0.20
delivery_price = 2.50
total_order_price = total_menu_price + desert_price + delivery_price

print(f"{total_order_price:.1f}")
