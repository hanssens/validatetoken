# Validate Token for ASP.NET MVC 4

Proof of concept for a [RequireSessionKey] attribute in ASP.NET MVC.

## Getting Started

This project should compile and run out-of-the-box without any problems. If you want to integrate the sample in your own project, use the following instructions:

1. Add the `RequireSessionKey()` class to your project
2. [optional] Rename it as you please
3. Decorate your Controllers, or ActionResults, with the `[RequireSessionKey]` attribute

Tip of the day: don't forget to provide an anonymously accessible action to authenticate against. 