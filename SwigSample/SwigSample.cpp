#include "SwigSample.h"
#include <cstdio>

void Test()
{
    puts("SwigSample Test()");
}

int Add(int a, int b)
{
    return a + b;
}

int AddStruct(MyStruct* s)
{
    if (!s)
        return 0;
    return Add(s->a, s->b);
}
