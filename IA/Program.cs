
using Microsoft.Extensions.AI;

using OpenAI;

var key = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

IChatClient client = new OpenAIClient(key)
					 .AsChatClient("gpt-4o-mini");

Console.WriteLine(await client.GetResponseAsync("What is AI?"));

