deposited_sum = float(input())
deposit_duration = int(input())
yearly_interest_percentage = float(input())

interest_rate = yearly_interest_percentage / 100
interest_sum = deposited_sum * interest_rate
interest_per_month = interest_sum / 12
total_sum = deposited_sum + (deposit_duration * interest_per_month)

print(total_sum)