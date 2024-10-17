using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lmstudiolocal
{
    internal class SamplePlugin
    {
        public bool Quit { get; set; }

        void NotifyCall([CallerMemberName] string? fnname = null)
        {
            Console.WriteLine($"Kernel function called: {fnname}");
        }

        [KernelFunction]
        [Description("Call this to terminate the chat session.")]
        public void terminate()
        {
            NotifyCall();
            Quit = true;
        }

        [KernelFunction]
        public double add(double a, double b)
        {
            NotifyCall();
            return a + b;
        }

        [KernelFunction]
        public double subtact(double a, double b)
        {
            NotifyCall();
            return a - b;
        }

        [KernelFunction]
        public double multiply(double a, double b)
        {
            NotifyCall();
            return a * b;
        }

        [KernelFunction]
        public double divide(double a, double b)
        {
            NotifyCall();
            return a / b;
        }
    }
}
