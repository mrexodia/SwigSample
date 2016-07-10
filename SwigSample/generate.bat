@echo off
swig -csharp -c++ SwigSample.i
move SwigSample*.cs ..\CSharpCaller\swig\