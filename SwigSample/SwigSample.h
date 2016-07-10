#ifndef SWIG_SAMPLE_H
#define SWIG_SAMPLE_H

#define SWIGEXPORT __declspec(dllexport)

#ifdef __cplusplus
extern "C"
{
#endif

struct MyStruct
{
    int a;
    int b;
};

SWIGEXPORT void Test();
SWIGEXPORT int Add(int a, int b);
SWIGEXPORT int AddStruct(MyStruct* s);

#ifdef __cplusplus
}
#endif

#endif //SWIG_SAMPLE_H