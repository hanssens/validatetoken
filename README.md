# Validate Token for ASP.NET MVC 4

Proof of concept for a [RequireSessionKey] attribute in ASP.NET MVC.

## In short - What's it for?

This little project shows you how to **secure individual actions**, and enable the callers to provide a (valid) sessionkey, or token of your choice.

Now this can be extremely handy not only for securing webapplications in general, but also for *legacy* applications where you don't want to hassle with a lot of rework. In fact, it requires little to no rework at all, considering all you need to do to protect your Actions is add a simple `[RequireSessionKey]` attribute to it.

Let's take a look at an example on how to secure **any** Action:

```

	public ActionResult Homepage() {
		// nothing special here; just another regular page
		return View();
	}

	[RequireSessionKey]
	public ActionResult SuperSecretPage() {
		// Magic! this won't even get executed if you don't provide a sessionkey/token
		return View();
	}

```

All you have to do in your client is something like the sample below, and you're good to go!

```

	$.ajax({
			url: "/supersecretpage",
			headers: {
				"SessionKey": "XXXXXX"
			}
		});

```

## Getting Started

This project should compile and run out-of-the-box without any problems. If you want to integrate the sample in your own project, use the following instructions:

1. Add the `RequireSessionKey()` class to your project
2. [optional] Rename it as you please
3. Decorate your Controllers, or ActionResults, with the `[RequireSessionKey]` attribute

Tip of the day: don't forget to provide an anonymously accessible action to authenticate against. 