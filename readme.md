# Introduction
This is a sample project for Prism with Xamarin.Forms using DryIoC.

Prism is a framework for building loosely coupled, maintainable, and testable XAML applications in WPF, Windows 10 UWP, and Xamarin Forms. Separate releases are available for each platform and those will be developed on independent timelines. Prism provides an implementation of a collection of design patterns that are helpful in writing well-structured and maintainable XAML applications, including MVVM, dependency injection, commands, EventAggregator, and others. Prism's core functionality is a shared code base in a Portable Class Library targeting these platforms.

Author: [Damian Suess](https://www.linkedin.com/in/damiansuess/)

## Semi-Requirements
The project works best if you include the [Prism Template Pack](https://marketplace.visualstudio.com/items?itemName=BrianLagunas.PrismTemplatePack). This allows the system to quickly type in code for you and _even creates a ViewModel class when you create a new page_!

## TODO
* [ ] Compare benchmarks across engines
  * Create an up-to-date benchmark of [Battling Serializers](https://michaelscodingspot.com/the-battle-of-c-to-json-serializers-in-net-core-3/) - [GitHub](https://github.com/michaelscodingspot/PracticalDebugging/blob/master/Benchmarks/Serializers/Models.cs)

## Engines

| Name | Active | NuGet |
|------|--------|-------|
| [Swifter.Json](https://github.com/Dogwei/Swifter.Json) | Active | [Nuget](https://www.nuget.org/packages/Swifter.Json)
| [Newtonsoft](https://www.newtonsoft.com/json) | Active | [NuGet](https://www.nuget.org/packages/Newtonsoft.Json/)
| [Jil](https://github.com/kevin-montrose/Jil) | Active | 
| [Utf8Json](https://github.com/neuecc/Utf8Json/) | Inactive | [NuGet](https://www.nuget.org/packages/Utf8Json/)
| [System.Text.Json](https://github.com/dotnet/runtime/tree/master/src/libraries/System.Text.Json) | Active | [NuGet](https://www.nuget.org/packages/System.Text.Json)
| [Service Stack](https://github.com/ServiceStack/ServiceStack.Text) | Active |

Misc:
* [Data Contracts](https://docs.microsoft.com/en-us/dotnet/framework/wcf/samples/json-serialization)

# Resources
* [Prism Library](https://prismlibrary.github.io/)
* [Prism Template Pack](https://marketplace.visualstudio.com/items?itemName=BrianLagunas.PrismTemplatePack)
* [Prism on GitHub](https://github.com/PrismLibrary/Prism)
