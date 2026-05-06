---
title: Share a forecast
description: "Share forecasts with other users in the hierarchy or outside the hierarchy with a specific access permission."
ms.date: 10/16/2025
ms.topic: how-to

author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Share a forecast

Use forecast sharing to give specific users access to your forecast data without changing their security roles. You control exactly what access each person gets — view only, or view and adjust — and you can revoke access at any time. Sharing is useful when you're delegating responsibilities temporarily, collaborating across teams, or providing visibility to stakeholders outside your hierarchy.

For example, Henry, the Sales Manager, wants to go on a vacation and wants one of the direct reports, Serena Davis, to manage the forecasts. Henry can share the forecast hierarchy with Serena and assign the appropriate permissions. Depending on the permissions granted, Serena can view or adjust the forecast. However, Serena cannot share the forecast with any other user as Henry is the owner of the forecast.

> [!IMPORTANT]
> **Only the forecast owner can share a forecast.** To find out who owns a forecast, see [Who owns the forecast?](faq-forecasting.md#who-owns-the-forecast).

## Share a forecast or forecast hierarchy

1.  Go to **Performance &gt; Forecasts** in the Sales Hub sitemap.

    You'll see the **Share** icon :::image type="icon" source="media/share-icon.png" border="false"::: next to the forecasts that are enabled for sharing.  

    > [!NOTE]
    > If you don't see the Share icon, it means that either you’re not the owner of the forecast or forecast sharing is not enabled. To know who owns the forecast, see [this FAQ](faq-forecasting.md#who-owns-the-forecast). Contact your administrator to identify the root cause and take appropriate action. 

2.  Select the **Share** icon :::image type="icon" source="media/share-icon.png" border="false"::: next to the forecast record or hierarchy that you want to share. 

3.  In the **Sharing** dialog, specify the users with whom you want to share the forecast and select the pencil icon to specify the access level.

    The following access levels are available:

    | Access level | Can view? | Can adjust values? | Can share further? |
    |---|---|---|---|
    | Read | Yes | No | No |
    | Read and adjust | Yes | Yes (within their hierarchy) | No |

    > [!NOTE]
    > You can specify a different access level for each user. The **Read and adjust** option must be enabled by your administrator in the forecast configuration.
    
    :::image type="content" source="media/forecast-sharing-options.png" alt-text="Screenshot of access levels available for sharing":::

    The selected forecast record or hierarchy is shared with the specified users.

## Stop sharing a forecast

To stop sharing a forecast with a user, select the **Share** icon :::image type="icon" source="media/share-icon.png" border="false"::: next to the forecast record. In the **Sharing** dialog, find the user you want to stop sharing with, and then select the **Delete** icon next to the username. 

To stop sharing the entire forecast hierarchy from all the users, your administrator needs to disable the sharing option at the forecast configuration level. For more information, see [Enable or disable forecast sharing](provide-permissions-forecast.md#enable-or-disable-forecast-sharing).

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information
[Enable or disable forecast sharing](provide-permissions-forecast.md#enable-or-disable-forecast-sharing)  
[Provide permissions to access and share a forecast](provide-permissions-forecast.md)  
