using Microsoft.SemanticKernel;

namespace sk_customllm;

public class CustomPromptExecutionSettings : PromptExecutionSettings
{
    public float? Temperature { get; set; }
}