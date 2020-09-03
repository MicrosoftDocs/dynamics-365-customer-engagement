---
title: "Test the custom messaging channel | Microsoft Docs"
description: "This topic provides sample code to test the integration of custom messaging channels."
author: platkat
ms.author: ktaylor
manager: shujoshi
ms.date: 07/07/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: reference
---
# Preview: Test the custom messaging channel

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.​
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../../legal/dynamics-insider-agreement.md).

Omnichannel for Customer Service allows you to implement a connector to integrate custom messaging channels. The complete [sample code](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/bring-your-own-channel) illustrates how you can create your own connector. 

You can use the following sample code to test the custom messaging channel you want to bring in to Omnichannel for Customer Service. You can modify the sample code to suit the needs of your organization.

```html
<!DOCTYPE html>
<html lang="en-US">
<head>
    <title>Web Chat: Full-featured bundle</title>

    <script src="https://cdn.botframework.com/botframework-webchat/latest/webchat.js"></script>

    <style>
    html, body { height: 100% }
    body {
      margin: 0;
      background-color: paleturquoise;
    }
    #webchat {
      height: 100%;
      width: 100%;
    }
  </style>
</head>
<body>
       <div id="webchat" role="main"></div>
    <script>
    (async function () {
        const res = await fetch('https://directline.botframework.com/v3/directline/conversations', 
{ method: 'POST', headers: { Authorization: 'Bearer ***************Insert Direct Line Secret here *******************' }});

      const { token } = await res.json();

      (async function () {
	window.WebChat.renderWebChat({
      directLine: window.WebChat.createDirectLine({ token }),
      styleOptions: {
        rootHeight: '100%',
        rootWidth: '50%',
		bubbleMaxWidth: 1200,               
        botAvatarInitials: 'C',                
        userAvatarInitials: 'A',  
      }
    }, document.getElementById('webchat'));
    })()
    })().catch(err => console.error(err));
   </script>
</body>
</html>
```

### See also

[Bring your own custom messaging channel: Direct Line Bot](bring-your-own-channel.md)  
[Configure custom messaging channel](../../administrator/configure-custom-channel.md)  
