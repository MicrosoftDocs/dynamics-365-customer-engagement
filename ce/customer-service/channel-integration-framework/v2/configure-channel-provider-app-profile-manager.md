---
title: "Configure channel providers in Dynamics 365 Channel Integration Framework 2.0| MicrosoftDocs"
description: "Learn how to configure channel providers using the app profile manager or the Customer Service admin center in Dynamics 365 Channel Integration Framework 2.0."
author: gandhamm
ms.author: mgandham
manager: shujoshi
ms.date: 02/22/2023
ms.custom: 
  - "dyn365-a11y"
  - "dyn365-developer"
searchScope: 
 - D365-App-customerservicehub 
 - D365-Entity-msdyn_channelprovider
 - D365-UI-*
 - Dynamics 365 
 - Customer Service 
 - Customer Engagement
---

# Configure channel providers in Dynamics 365 Channel Integration Framework 2.0

Dynamics 365 Channel Integration Framework 2.0 is intended for multisession applications such as Omnichannel for Customer Service and Customer Service workspace. You can configure channel providers for multisession applications either using Customer Service admin center or Power Apps.

More information: 
- [Agent experience profiles](../../../app-profile-manager/overview.md)
- [Customer Service admin center](../../../customer-service/cs-admin-center.md)

## Configure a third-party channel provider

1. Go to one of the apps, and perform the following steps:
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
   
    1. In the site map, select **Workspaces** in **Agent experience**. The **Workspaces** page opens.
    
    2. Select **Manage** for **Third party voice channel provider**.
    
    3. Select a provider from the **Active Channel Providers** list and select **Edit**, or select **New** to add a new channel provider.

    ### [Power Apps](#tab/appprofilemanager)    
    1. Sign in to the [Power Apps](https://make.powerapps.com) portal.

    2. Under the available apps, select the ellipses next to **Omnichannel for Customer Service** or **Customer Service workspace**.

    3. On the menu that appears, select **App profile manager**.

    4. Select **App profiles** from the site map, and then select your app profile.

    5. Select the **Channels** tab.

      > ![Select app profiles.](../media/channel-app-profile-manager.PNG "Select app profiles")

    6. Select **Add channel providers**, and then select **Create a new channel provider in Unified Interface**. The **New Channel Provider** page opens in a new tab.

      > ![Create new channel provider.](../media/create-new-channel-provider-app-profile-manager.PNG "Create new channel provider")

2. Enter or update the following details:

| Field | Description |
|-------|-------|
|Name|Name of the channel provider.|
|Unique Name|A unique identifier in the <*prefix*>_<*name*> format. <br>**IMPORTANT:** The following are required for the unique name:<ul><li> The prefix has to be alphanumeric with a length of 3-8 characters.</li><li>The prefix must include an underscore</li></ul>|
|Label|The label is displayed as the title on the widget.|
|Channel URL|The URL of the provider to host in the widget. See the JavaScript APIs on how to develop communication widget with Dynamics 365 Channel Integration Framework.|
|Enable Outbound Communication|Selecting a phone number in the Dynamics 365 Unified Interface page, the widget initiates the call or outbound communication.|
|Channel Order|The order of precedence of the channel providers. That is, the priority to display the channel for the agents and Unified Interface apps.|
|Api Version|The version of the Channel Integration Framework APIs.|
|Trusted Domain| An additional domain if the initial landing URL and the final domain from which the communication widget is hosted are different. Add the domain (URL) to access the Channel Integration Framework APIs. |
|Custom Parameters|This takes a text blob as input and `Microsoft.CIFramework.getEnvironment` will return this as value of key `customParams`.|
|Enable Analytics|Select `Yes` if you'd like to enable analytics for your channel provider.|

  > ![Configure channel provider.](../media/channel-provider-app-profile.png "Configure channel provider")

  > [!NOTE]
  > The `Api Version` field is set to `2` when you navigate from the app profile manager.

3. If you're using the app profile manager, add the channel provider to the app profile. If you're using Customer Service admin center, then select **Save & Close**.

## Deactivate or delete a channel provider

1. In the site map of Customer Service admin center, select **Workspaces** in **Agent experience**. The **Workspaces** page opens.
    
2. Select **Manage** for **Third party voice channel provider**.
    
3. Select a provider from the **Active Channel Providers** list, and do one of the following:

    - To deactivate the channel provider, select **Deactivate**. In the **Confirm Deactivation** dialog, select **Yes**. You can reactivate the channel later by selecting **Activate**.
    - To delete the channel provider, select **Delete**. In the **Confirm Deletion** dialog, select **Yes** if you're sure you want to delete the channel provider. Note that you can't reactivate the channel provider after it's deleted.

### See also

[Overview of agent experience](../../../app-profile-manager/overview.md)  
[Enable outbound communication (ClickToAct)](enable-outbound-communication-clicktoact.md)  
[Microsoft.CIFramework.getEnvironment](../v2/reference/microsoft-ciframework/getEnvironment.md)  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
