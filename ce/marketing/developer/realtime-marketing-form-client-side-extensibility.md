---
title: "Extend realtime marketing forms using code (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Extend realtime marketing forms with JavaScript to apply custom business logic in Dynamics 365 Marketing."
ms.date: 05/04/2021
ms.custom:
- dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType:
- developer
search.app:
- D365CE
- D365Mktg
---

# Extend realtime marketing forms using code

> [!NOTE]
> Marketing forms are in private preview, extensibility features will be released as part of global availability   

## JavaScript API
  
Realtime forms are consisting of two part - so called form placeholder, which looks similar to this:
```
<div
  data-form-id='{msdynmkt_marketingformid}'
  data-submit-form-url='https://{server}.dynamics.com/api/v1.0/orgs/{organizationid}/landingpageforms/forms/{msdynmkt_marketingformid}'
  data-cached-form-url='https://{server}.dynamics.com/{organizationid}/digitalassets/forms/{msdynmkt_marketingformid}' >
</div>
```
And form loader that lights up the form placeholders:
```
<script src = 'https://{server}/global/FormLoader/FormLoader.bundle.js' ></script>
```

### Custom events

| Custom event | Description |
|------|-------|
|`d365mkt-beforeformload`|Triggered when form placeholder is recognized before the actual form content is fetched |
|`d365mkt-formrender`|Triggered after the form content is fetched and right before it is injected into form placeholder |
|`d365mkt-afterformload`|Triggered after form is injected into placeholder |
|`d365mkt-formsubmit`| Triggered when form is getting submitted, cancellable
  
  You can attach to events using the standard event attach mechanics
  ```
  <script>
document.addEventListener("d365mkt-beforeformload", function() { console.log("d365mkt-beforeformload") });
document.addEventListener("d365mkt-afterformload", function() { console.log("d365mkt-afterformload") });
document.addEventListener("d365mkt-formrender", function() { console.log("d365mkt-formrender") });
document.addEventListener("d365mkt-formsubmit", function(event) {
    // example of validation using form submit event - cancelling form submission unless first name is John 
    if (document.forms[0]["firstname"].value !== "John") { 
      event.preventDefault(); 
      console.log("blocked mkt-formsubmit"); 
      return;
    }
    console.log("mkt-formsubmit"); 
});
</script>
```

### Form behavior customization
You can customize the form behavior by including configuration script before the loader script is injected into a page.
 ```
 <script>
 var d365mkt = {
   // disables showing of progress bar during form loading
   hideProgressBar: true
 };
 </script>
``` 

> [!NOTE]
> The Javascript API is available only for forms hosted as a script, it is not supported for the iframe hosting option.  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
