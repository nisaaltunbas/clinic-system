using Business;
using Core.Abstracts.IServices;
using Core.Concretes.Constants;
using Core.Concretes.Entities.Dent;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using UI.Web;
using Utilities.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();



builder.Services.AddAutoMapper(typeof(CoreMapProfiles));
builder.Services.AddBusinessServices(builder.Configuration);

builder.Services.Configure<EmailSenderOptions>(builder.Configuration.GetSection("EmailSenderOptions"));
builder.Services.AddTransient<IEmailSender, EmailSender>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthorization();
app.UseAuthentication();

app.MapRazorPages();
app.Run();

