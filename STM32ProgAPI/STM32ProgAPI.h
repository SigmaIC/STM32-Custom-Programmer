namespace STM32Prog
{
    namespace Cpp
    {
        // This is our native implementation
        // It's marked with __declspec(dllexport) 
        // to be visible from outside the DLL boundaries
        class __declspec(dllexport) STLink
        {
        public:
            int Connect() const; // That's where our code goes
        };
    }
} 
