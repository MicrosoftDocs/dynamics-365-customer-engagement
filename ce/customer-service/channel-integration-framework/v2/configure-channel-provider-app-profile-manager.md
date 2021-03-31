---
title: "Configure channel provider using app profile manager in Channel Integration Framework (CIF) version 2.0| Microsoft Docs"
description: "Learn how to configure a channel provider using the app profile manager."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/02/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
---

# Configure channel provider using app profile manager

The app profile manager is an out-of-the-box solution that lets you create targeted app experiences for agents and supervisors. More information: [App profile manager](../../../app-profile-manager/overview.md).

Channel Integration Framework version 2.0 is for multi-session applications such as Omnichannel for Customer Service and Customer Service workspace. Use the app profile manager as follows to configure a third-party voice channel provider with a multi-session application:

1. Sign in to your [Power Apps](https://make.powerapps.com) portal.

2. Under the available apps, select the ellipses to the right of **Omnichannel for Customer Service** or **Customer service workspace**.

3. On the menu that appears, select **App profile manager**.

4. Select **App profiles** from the site map, and then, select your app profile.

5. Select the **Channels** tab.

  > ![Select app profiles](../media/channel-app-profile-manager.PNG "Select app profiles")

6. Select **Add channel providers** and then, select **Create a new channel provider in Unified Interface**. The **New Channel Provider** page opens in a new tab.

  > ![Create new channel provider](../media/create-new-channel-provider-app-profile-manager.PNG "Create new channel provider")

7. Fill in all the required details to configure a new channel provider.

| Field | Description |
|-------|-------|
|Name|Name of the channel provider.|
|Unique Name|A unique identifier in the <*prefix*>_<*name*> format. <br>**IMPORTANT:** The following are required for the unique name:<ul><li> The prefix can only be alphanumeric and its length must be between 3 to 8 characters.</li><li>An underscore must be there between the prefix and name</li></ul>|
|Label|The label is displayed as the title on the widget.|
|Channel URL|The URL of the provider to host in the widget. See the JavaScript APIs on how to develop communication widget with Dynamics 365 Channel Integration Framework.|
|Enable Outbound Communication|Selecting a phone number in the Dynamics 365 Unified Interface page, the widget initiates the call or outbound communication.|
|Channel Order|The order precedence of the channel providers. That is, the priority to display the channel for the agents and unified Interface Apps.|
|API Version|The version of the Channel Integration Framework APIs.|
|Trusted Domain| An additional domain if the initial landing URL and the final domain from which the communication widget is hosted are different. Add the domain (URL) to access the Channel Integration Framework APIs. |
|Custom Parameter|This takes a text blob as input and `Microsoft.CIFramework.getEnvironment` will return this as value of key `customParams`.|
|Enable Analytics|Select `Yes` if you wish to enable analytics for your channel provider.|

  > ![Configure channel provider](../media/channel-provider-app-profile.png "Configure channel provider")

  > [!NOTE]
  > The `Api Version` field is set to `2` when you navigate from the app profile manager.

8. After you have configured the channel provider, go back to the app profile manager and add the channel provider to the app profile.
  
## See also

[App profile manager](../../../app-profile-manager/overview.md)<br />
[Enable outbound communication (ClickToAct)](enable-outbound-communication-clicktoact.md)<br />
[Microsoft.CIFramework.getEnvironment](../v2/reference/microsoft-ciframework/getEnvironment.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]