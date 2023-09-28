#Largest Prime Factor

Dividend = 600851475143

for Divisor in range(2, Dividend):
    if(Dividend % Divisor == 0):
        Dividend = Dividend // Divisor
        LargestPrimeFactor = Divisor

print(LargestPrimeFactor)