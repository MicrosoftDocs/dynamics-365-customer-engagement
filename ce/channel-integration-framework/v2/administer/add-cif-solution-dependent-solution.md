---
title: Manage Dynamics 365 Channel Integration Framework 2.0 solutions
description: Learn how to add and remove Dynamics 365 Channel Integration Framework 2.0 solutions from Dynamics 365.
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to
ms.date: 12/10/2024
ms.custom: bap-template
---

# Manage Dynamics 365 Channel Integration Framework 2.0 solutions in Dynamics 365

Third-party channel providers can add Dynamics 365 Channel Integration Framework 2.0 components as a dependent solution for use in solutions that they develop for Dynamics 365. This article describes how you can add and remove Dynamics 365 Channel Integration Framework 2.0 solutions from your Dynamics 365 instance.

You can export solution files from one organization and import them into another organization using the Dynamics 365 **Settings** > **Customizations** > **Solutions** page. Before exporting, you can choose to remove any channel provider components using the **Solutions** page, but ensure that the channel provider URL doesn't get overwritten in the target environment during the import process. To prevent this, you can either edit the customizations XML file before exporting the solution or ensure that you export the solution with the target organization's channel provider URL.

[!INCLUDE[token-add-cif-solution-dependent-solution](../../shared/token-add-cif-solution-dependent-solution.md)]

### Related information

[Authenticate channel users to the channel (widget)](../../v1/administer/authenticate-channel-users.md)  
[Get Dynamics 365 Channel Integration Framework](../../v1/administer/get-channel-integration-framework.md)  
[Configure channel providers in Dynamics 365 Channel Integration Framework 2.0](configure-channel-provider-app-profile-manager.md)  
[Enable outbound communication (ClickToAct)](../../v1/administer/enable-outbound-communication-clicktoact.md)  
[Pass a Dynamics 365 URL to a widget library](../../v1/administer/pass-url-widget-library.md)  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
