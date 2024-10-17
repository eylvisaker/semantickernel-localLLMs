namespace sk_customllm.Models
{
    public class ChatRequest
    {
        public ChatRequest()
        {
            messages = new List<ChatMessage>();
            temperature = 0.7f;
            max_tokens = 2500;
            stream = false;
            model = "";
        }
        public string model { get; set; }
        public List<ChatMessage> messages { get; set; }
        public float temperature { get; set; }
        public int max_tokens { get; set; }
        public bool stream { get; set; }
        public List<ChatTool>? tools { get; set; }
        public object tool_choice { get; set; }
    }

    public class ChatTool
    {
        public string type { get; set; } = "function";
        public Function? function { get; set; }

        public class Function
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public FunctionParameters Parameters { get; set; }

        }

        public class FunctionParameters
        {
            public string Type { get; set; } = "object";
            public List<string>? Required { get; set; }
            public bool AdditionalProperties { get; set; }

            public Dictionary<string, FunctionProperty>? Properties { get; set; }
        }

        public class FunctionProperty
        {
            public string? Type { get; set; }
            public string? Description { get; set; }
        }
    }


}
