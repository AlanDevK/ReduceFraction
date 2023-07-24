# ReduceFraction

Hi guys! Alan here! So I just found this problem in CodinGame's Clash Of Code match and I got kinda confused about this problem. The main objective is to reduce the
fraction to its end. If the given fraction can't be reduce, then the program will print out exactly that fraction. I try to find the solution and the pattern for this
exercise for maybe 2 days because I was busy but eventually, I solve it.

To solve this issue, firstly we just have to extract the numerator and the denominator from the fraction string. Then, we will find the GCD (greatest common number) of 
these 2 numbers and divide them by that number. If the GCD is 1 then the fraction is considered as in its end and if it is not then we will divide the numerator and the
denominator with the GCD. If 1 of them can't divide more then we will print the final fraction.

I divide the main code and the finding GCD fucnction so that the code will be cleaner but then I realize that it is frickin not lmao

If you have some ideas, please share with me

As always, you can find my program inside the FractionProblem folder and click on the cs program.

Thank you

-Alan-
