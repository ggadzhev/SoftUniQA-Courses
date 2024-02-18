ticket_type = input()
total_rows = int(input())
total_columns = int(input())

income = 0

capacity = total_rows * total_columns

if ticket_type == "Premiere":
    income = capacity * 12.00
elif ticket_type == "Normal":
    income = capacity * 7.50
elif ticket_type == "Discount":
    income = capacity * 5.00

print(f"{income:.2f} leva")