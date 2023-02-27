// Определить количество цифр в числе.

int CountOfNum(int num)
{
int count = 0;
if (num == 0) count = 1;
else
{
while (num != 0)
{
num /= 10;
count++;
}
}
return count;
}