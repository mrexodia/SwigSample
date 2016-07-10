@echo off
swig -csharp -c++ -namespace Swig.SwigSample SwigSample.i
move *.cs ..\CSharpCaller\swig\