int baseNumber = 0; // base number which will be increased by power
int power = 0;  //power by which the base number will be increased

MathPower(baseNumber, power);


static int MathPower(int number, int powerNumber)  // method to increase a number by power amount.
{
    int output = number;

    for (int i = 2; i <= powerNumber; i++)
    {
        output *= number;
    }

    return output;
}

