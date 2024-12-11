---
title: Enable outbound communication in Dynamics 365 Channel Integration Framework 1.0 
description: Learn to enable outbound communication (ClickToAct) for your channel in Dynamics 365 Channel Integration Framework 1.0.
ms.date: 12/10/2024
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.custom: bap-template
---

# Enable outbound communication (ClickToAct) in Dynamics 365 Channel Integration Framework 1.0

> [!IMPORTANT]
> - Minimum versions required to use this feature without any customizations.
>    -	Platform version: 9.1.0000.15343
>    -	Dynamics 365 Channel Integration Framework 1.0: 9.1.0.412.
> - ClickToAct event isn't supported in the focused view of Dynamics 365 Sales.

## Enable outbound communication for your channel

1. Sign in to Dynamics 365 and open the **Channel Integration Framework** app.
2. Under **Channel Provider Configuration**, select **Channel Integration Framework v1.0 Providers**. The list of **Active Channel Providers** is displayed.
3. Select your channel provider from the list, and set the **Enable Outbound Communication** field to **Yes**.

> [!div class="nextstepaction"]
> [Add Channel Integration Framework as a dependent solution](add-cif-solution-dependent-solution.md)

###Related information

[Entity reference](../develop/reference/entities-attributes/msdyn-ciprovider.md)  
[setClickToAct](../develop/reference/microsoft-ciframework/setClickToAct.md)  
[getClickToAct](../develop/reference/microsoft-ciframework/getClickToAct.md)  
[onClickToAct](../develop/reference/events/onclicktoact.md)  

[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
