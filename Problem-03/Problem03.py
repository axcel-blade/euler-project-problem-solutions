#Largest Prime Factor

Dividend = 600851475143
Divisor = 2
Factors = []

while(Divisor < Dividend):
    if(Dividend % Divisor == 0):
        Factors.append(Divisor)
    Divisor = Divisor + 1

print(Factors)