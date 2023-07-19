---
title: "removeHandler (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 | MicrosoftDocs"
description: "Includes reference information such as description, syntax, and parameters for the removeHandler method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0."
ms.date: 07/11/2023
ms.topic: reference
author: gandhamm
ms.author: mgandham
applies_to: 
  - "Dynamics 365 for Customer Engagement (online)"
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# removeHandler (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[removeHandler-description](includes/removeHandler-description.md)]

[!INCLUDE[token-removeHandler](../../../shared/token-removeHandler.md)]

## Example

```Javascript
Microsoft.CIFramework.removeHandler(eventName, handlerFunction).then(
  function (result) {
      // result will indicate if the passed in handler function has been removed
      console.log(result)
  },
  function (error) {
      // code handling for promise failure
      console.error(error)
  }
);
```

### See also

[onClickToAct](../events/onclicktoact.md)  
[onModeChanged](../events/onmodechanged.md)  
[onPageNavigate](../events/onpagenavigate.md)  
[onSendKBArticle](../events/onsendkbarticle.md)  
[onSizeChanged](../events/onsizechanged.md)  

[!INCLUDE[footer-include](../../../../../includes/footer-banner.md)]
