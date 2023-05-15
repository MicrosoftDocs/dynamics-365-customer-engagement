---
title: "Share a forecast - Dynamics 365 Sales | MicrosoftDocs"
description: "Share forecasts with other users in the hierarchy or outside the hierarchy with a specific access permission."
ms.date: 01/25/2022
ms.topic: article

author: lavanyakr01
ms.author: lavanyakr
---

# Share a forecast

Share the forecasts that you own, with anyone in your hierarchy or outside of your hierarchy. You can specify the access level (such as read, or read and adjust rollup) that you want to give the user. For example, Henry, the Sales Manager, wants to go on a vacation and wants one of the direct reports, Serena Davis, to manage the forecasts. Henry can share the forecast hierarchy with Serena and assign the appropriate permissions. Depending on the permissions granted, Serena can view or adjust the forecast. However, Serena cannot share the forecast with any other user as Henry is the owner of the forecast.  

> [!NOTE]
> Only a forecast owner can share their forecast. To know more, see [Who owns the forecast?](faqs-sales.md#who-owns-the-forecast).

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## Share a forecast or forecast hierarchy

1.  Go to **Performance &gt; Forecasts** in the Sales Hub sitemap.

    You'll see the **Share** icon :::image type="icon" source="media/share-icon.png" border="false"::: next to the forecasts that are enabled for sharing.  

    > [!NOTE]
    > If you don't see the Share icon, it means that either you’re not the owner of the forecast or forecast sharing is not enabled. To know who owns the forecast, see [this FAQ](faqs-sales.md#who-owns-the-forecast). Contact your administrator to identify the root cause and take appropriate action. 

2.  Select the **Share** icon :::image type="icon" source="media/share-icon.png" border="false"::: next to the forecast record or hierarchy that you want to share. 

3.  In the **Sharing** dialog, specify the users with whom you want to share the forecast and select the pencil icon to specify the access level.

    > [!NOTE]
    >  You can specify different level of access for each user if your administrator has set the **Read and adjust** option.
    
    :::image type="content" source="media/forecast-sharing-options.png" alt-text="Screenshot of access levels available for sharing":::

    The selected forecast record or hierarchy is shared with the specified users.

## Stop sharing a forecast

To stop sharing a forecast with a user, select the **Share** icon :::image type="icon" source="media/share-icon.png" border="false"::: next to the forecast record. In the **Sharing** dialog, find the user you want to stop sharing with, and then select the **Delete** icon next to the username. 

To stop sharing the entire forecast hierarchy from all the users, your administrator needs to disable the sharing option at the forecast configuration level. For more information, see [Enable or disable forecast sharing](provide-permissions-forecast.md#enable-or-disable-forecast-sharing).

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also
[Enable or disable forecast sharing](provide-permissions-forecast.md#enable-or-disable-forecast-sharing)  
[Provide permissions to access and share a forecast](provide-permissions-forecast.md)  
