int a1, a2, a3, b1, b2, b3, c1, c2, c3;
int cs1, cs2, cs3, cs4, cs5, cs6;
int cs;
int cm = 1;
int temp;


temp = a3;
a3 = a2;
a2 = a1;
a1 = temp;
cs = cs1;

cs = 0;
Console.Clear();

cm = cm + 1;
temp = b3;
b3 = b2;
b2 = b1;
b1 = temp;
cs = cs2;

cs = 0;
Console.Clear();

cm = cm + 1;
temp = c3;
c3 = c2;
c2 = c1;
c1 = temp;
cs = cs3;

cs = 0;
Console.Clear();

cm = cm + 1;
temp = c1;
c1 = b1;
b1 = a1;
a1 = temp;
cs = cs4;

cs = 0;
Console.Clear();

cm = cm + 1;
temp = c2;
c2 = b2;
b2 = a2;
a2 = temp;
cs = cs5;

cs = 0;
Console.Clear();

cm = cm + 1;
temp = c3;
c3 = b3;
b3 = a3;
a3 = temp;
cs = cs6;

Console.Clear();

if (cs1=>cs2 || cs1=>cs3 || cs1=>cs4 || cs1=>cs5 || cs1=>cs6)
{
    temp = a3;
    a3 = a2;
    a2 = a1;
    a1 = temp;
}

else if (cs2=>cs1 || cs2=>cs3 || cs2=>cs4 || cs2=>cs5 || cs2=>cs6)
{
    temp = b3;
    b3 = b2;
    b2 = b1;
    b1 = temp;
}
else if (cs3 => cs1 || cs3=> cs2 || cs3=>cs4 || cs3=>cs5 || cs3=>cs6)
{
    temp = c3;
    c3 = c2;
    c2 = c1;
    c1 = temp;
}
else if (cs4 => cs1 || cs4=> cs2 || cs4=>cs3 || cs4=>cs5 || cs4=>cs6)
{
    temp = c1;
    c1 = b1;
    b1 = a1;
    a1 = temp;
}
else if (cs5 => cs1 || cs5=> cs2 || cs5=>cs3 || cs5=>cs4 || cs5=>cs6)
{
    temp = c2;
    c2 = b2;
    b2 = a2;
    a2 = temp;
}
else if (cs6 => cs1 || cs6=> cs2 || cs6=>cs3 || cs6=>cs4 || cs6=>cs5)
{
    temp = c3;
    c3 = b3;
    b3 = a3;
    a3 = temp;
}