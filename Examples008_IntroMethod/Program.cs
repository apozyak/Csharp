int a1 = 4;
int b1 = 9;
int c1 = 8;
int a2 = 11;
int b2 = 54;
int c2 = 2;
int a3 = 44;
int b3 = 13;
int c3 = 20;

int max = a1;
if (max < b1) max = b1;
if (max < c1) max = c1;

if (max < a2) max = a2;
if (max < b2) max = b2;
if (max < c2) max = c2;

if (max < a3) max = a3;
if (max < b3) max = b3;
if (max < c3) max = c3;

Console.WriteLine(max);

