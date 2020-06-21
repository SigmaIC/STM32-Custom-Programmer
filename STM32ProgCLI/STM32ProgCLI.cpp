// STM32ProgCLI.cpp : This file contains the 'main' function. Program execution begins and ends there.
//
// MeaningOfLife.Cpp.CLI/Logic.cpp
#include "STM32ProgCLI.h"
#include "..\STM32ProgAPI\STM32ProgAPI.h"
#include <string>
#include <Windows.h>


using namespace std;

STM32Prog::Cpp::CLI::Logic::Logic()
    : _impl(new Cpp::Logic())
    // Allocate some memory for the native implementation
{
}

int STM32Prog::Cpp::CLI::Logic::Get()
{
    return _impl->Get(); // Call native Get
}

void STM32Prog::Cpp::CLI::Logic::Destroy()
{
    if (_impl != nullptr)
    {
        delete _impl;
        _impl = nullptr;
    }
}

STM32Prog::Cpp::CLI::Logic::~Logic()
{
    // C++ CLI compiler will automaticly make all ref classes implement IDisposable.
    // The default implementation will invoke this method + call GC.SuspendFinalize.
    Destroy(); // Clean-up any native resources 
}

STM32Prog::Cpp::CLI::Logic::!Logic()
{
    // This is the finalizer
    // It's essentially a fail-safe, and will get called
    // in case Logic was not used inside a using block.
    Destroy(); // Clean-up any native resources 
}