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
```HTML
<div
  data-form-id='{msdynmkt_marketingformid}'
  data-form-api-url='https://{server}.dynamics.com/api/v1.0/orgs/{organizationid}/landingpageforms/forms/{msdynmkt_marketingformid}'
  data-cached-form-url='https://{server}.dynamics.com/{organizationid}/digitalassets/forms/{msdynmkt_marketingformid}' >
</div>
```
And form loader that lights up the form placeholders once page is loaded (`DOMContentLoaded` event is triggered)
```
<script src='https://cxppusa1formui01cdnsa01-endpoint.azureedge.net/global/FormLoader/FormLoader.bundle.js'></script>
```

### Custom events

| Custom event | Description |
|------|-------|
|`d365mkt-beforeformload`|Triggered when form placeholder is recognized before the actual form content is fetched |
|`d365mkt-formrender`|Triggered after the form content is fetched and right before it is injected into form placeholder |
|`d365mkt-afterformload`|Triggered after form is injected into placeholder |
|`d365mkt-formsubmit`| Triggered when form is getting submitted, cancellable
  
  You can attach to events using the standard event attach mechanics
  ```HTML
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
 ```HTML
 <script>
 var d365mkt = {
   // disables showing of progress bar during form loading
   hideProgressBar: true
 };
 </script>
``` 

### Rendering marketing form via javascript api
It can be inconvenient to wait for `DOMContentLoaded` - especially for scenarios like dynamic content loading. For this situations you can use the `createForm` helper function. `createForm` returns dom element `div` - which is returned immediatelly and triggers fetching of form content on background (the form is injected into placeholder the moment it is fetched).   

```HTML
<html>
  <body>
    <script src="https://cxpiusa1formui01cdnsa01-endpoint.azureedge.net/global/FormLoader/FormLoader.bundle.js"></script>
    <div id="root"></div>
    <script>
      const root = document.getElementById('root');
      root.appendChild(d365mktforms.createForm(
        'formId',
        'formApiBaseUrl',
        'formUrl'));
    </script>
  </body>
</html>
```

### Injecting marketing form into react application
You can use marketing forms within your react application. The form loader exposes `d365mktforms.FormPlaceholder` react component that you can inject into your application. 

```HTML
<html>
  <head>
    <script crossorigin src="https://unpkg.com/react@18/umd/react.development.js"></script>
    <script crossorigin src="https://unpkg.com/react-dom@18/umd/react-dom.development.js"></script>
    <script src="https://cxppusa1formui01cdnsa01-endpoint.azureedge.net/global/FormLoader/FormLoader.bundle.js"></script>
  </head>
  <body>
    <div id="root"></div>
    <script>
      const root = ReactDOM.createRoot(document.getElementById('root'));
      root.render(React.createElement(d365mktforms.FormPlaceholder, {
        formId:'{msdynmkt_marketingformid}',
        formApiBaseUrl:'https://{server-api}/api/v1.0/orgs/{organizationid}/landingpageforms',
        formUrl:'https://{server-load}/{organizationid}/digitalassets/forms/{msdynmkt_marketingformid}'
      }, null));
    </script>
  </body>
</html>
```
>NOTE: your have to replace {msdynmkt_marketingformid} with actual identifier of marketing form entity, {organizationid} with actual identifier of your organization and {server-} should point to server endpoints of your organization. Easiest way to grab those is via "Get Javascript Code" from form publish options.
> | Widget attribute | React component property |
> |---------------------|---------------------------------|
> | data-form-id | formId |
> | data-form-api-url | formApiBaseUrl |
> | data-cached-form-url | formUrl |

> [!NOTE]
> The Javascript API is available only for forms hosted as a script, it is not supported for the iframe hosting option.  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
