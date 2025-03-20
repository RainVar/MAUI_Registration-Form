using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Assignment_Basic_Registration_Form;

class Program : MauiApplication
{
    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

    static void Main(string[] args)
    {
        var app = new Program();
        app.Run(args);
    }
}