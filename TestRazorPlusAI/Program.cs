using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;

using OpenAI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton(new OpenAIClient(Environment.GetEnvironmentVariable("OPENAI_API_KEY")));
builder.Services.AddChatClient(services => services.GetRequiredService<OpenAIClient>().AsChatClient("gpt-4o-mini"));

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
