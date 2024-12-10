---
title: removeHandler (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0 
description: Includes reference information such as description, syntax, and parameters for the removeHandler method in JavaScript API Reference for Dynamics 365 Channel Integration Framework 2.0.
ms.date: 12/10/2024
ms.topic: reference
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template 
---

# removeHandler (JavaScript API Reference) for Dynamics 365 Channel Integration Framework 2.0

[!INCLUDE[removeHandler-description](../../../../v1/develop/reference/microsoft-ciframework/Includes/removeHandler-description.md)]

[!INCLUDE[token-removeHandler](../../../../shared/token-removeHandler.md)]

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
