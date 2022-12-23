
int size;
int rectSec = -1;
int isOddSize;

size = Convert.ToInt32(Console.ReadLine());

isOddSize = (size % 2 == 0) ? 1 : 0;

size = size * 2;

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (i < (size / 4))
        {
            if ((j == ((size / 2) - i)) || j == ((size / 2) + i))
            {
                Console.Write("*");
            } else
            {
                Console.Write(" ");
            }
        }
        else if (i == (size / 4))
        {
            Console.Write("*");
            if (rectSec == -1)
            {
                rectSec++;
            }                
        }
        else if (i > (size / 4) && (i < size - (size / 4) + (1 * isOddSize)))
        {
            if (j == rectSec || j == size - rectSec)
            {
                Console.Write("*");
            }
            else if ((j == ((size / 2) - i)) || j == ((size / 2) + i))
            {
                Console.Write("*");
            }
            else if ((size / 2) - i == 0)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }
    }
    
    Console.WriteLine();
    if (rectSec > -1)
    {
        rectSec++;
    }
}

