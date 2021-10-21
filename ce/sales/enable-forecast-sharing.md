---
title: "Enable or disable forecast sharing - Sales Enterprise | MicrosoftDocs"
description: "Enable forecast sharing to allow users to share forecast records that they have access to"
ms.date: 10/21/2021
ms.topic: article
ms.service: dynamics-365-sales
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

## Enable or disable forecast sharing

Forecast sharing is disabled by default. As an administrator or forecast manager, enable the forecast sharing option for the forecasts that needs to be shared. Users can only share forecast records that they have access to.  

**To enable forecast sharing**

1.  From the **Change area** in Sales Hub, select **App Settings**.

2.  Select **Forecast configuration** under **Performance management**.

3.  Select the forecast configuration for which you want to enable sharing.

4.  Select the **Permissions** step and specify the share permissions. Select one of the following options:

    - **None**: Indicates that forecast sharing is disabled and hence can't be shared with anyone. If you select this option while there are active sharing, the shared forecasts will no longer be available to the shared users.
    
    - **Read-only**: Indicates that the users in the forecast hierarchy can share the forecast with view permission.
    
    - **Read and adjust**: Indicates that the forecast can be shared with either the view only permission, or read and adjust permission. If you want to be able to share the forecast with different levels of access to different users, then select this setting.
    
5. Save the changes. 
   If you have selected **Read-only** or **Read and adjust**, all the forecast records in the forecast configuration are enabled for sharing. Sellers and managers can now share the records. See, [Share a forecast](share-forecasts.md). 

### See also
[Adjust values in a forecast](adjust-values-in-forecast.md)