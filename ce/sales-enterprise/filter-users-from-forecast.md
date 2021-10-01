---
title: "Filter users from forecast hierarchy - Sales Enterprise | MicrosoftDocs"
description: "Include only those users from your forecast hierarchy and get the forecast for only those users and groups that ."
ms.date: 10/01/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Filter users from forecast hierarchy

You can apply filters on your forecast hierarchy to include only those users who meet the specified conditions. You can filter users from a team, role, territory, and others. For example, Olivia Wilson is the Sales head for APAC and EMEA. She wants to view the forecast data of her org in the APAC territory. She can create an org chart forecast and apply the hierarchy filter to include only the APAC forecast data.

> [!NOTE]
> To apply the filter on an existing forecast, clone the forecast configuration, apply the filter, and activate it. You can then deactivate the old forecast.

**To filter users from forecast hierarchy**

1.  Select the **Filter Hierarchy** step of the forecast.

2.  Select the conditions to filter users that you want to include in the forecast. In our example, select **Territory** is equal to APAC. This will include forecast records of users from APAC.

    ![Graphical user interface  application Description automatically generated with medium confidence](media/image1.png)

    > [!NOTE]
    > If a manager is filtered out of the hierarchy, the rollup value of their team will still show up under the manager's name. However, the opportunities that were owned by the manager, will not be displayed in the forecast. Let us suppose that Henry Ross is a Sales Manager in Olivia's org and manages 5 sellers. Henry is in Europe but manages sellers in APAC. When Olivia looks at the forecast for APAC, the opportunities of Henry's reports will roll up under Henry's name, but it will not show any opportunities that Henry owns.

3.  Select the **General** step to preview the forecast configuration with the filtered hierarchy.

    ![Graphical user interface  application Description automatically generated](media/image2.png)

4.  Ensure that the forecast hierarchy looks correct before you activate the forecast. Once the forecast is activated, you cannot edit the filter.

# Share a Forecast

You can share a forecast with anyone in your hierarchy or outside of your hierarchy and specify the access level (such as read-only or read and adjust rollups) that you want to give the shared user. For example, Henry, the Sales Manager wants one of his direct reports, Serena Davis, to manage the forecasts while he's on vacation. He can share his forecast hierarchy with Serena and assign the read and adjust rollups permissions to Serena.

## Enable or disable forecast sharing

Forecast sharing is disabled by default. As an administrator or forecast manager, enable the forecast sharing option for the forecasts that needs to be shared. Users can only share forecast records that they have access to.

**To enable forecast sharing**

1.  From the **Change area** in Sales Hub, select **App Settings**.

2.  Select **Forecast configuration** under **Performance management**.

3.  Select the forecast configuration for which you want to enable sharing.

4.  Select the **Permissions** step and specify the share permissions. Select one of the following options:

- **No share**: Indicates that forecast sharing is disabled and hence cannot be shared with anyone. If you select this option when there are active shares, the shared forecasts will no longer be available to the users.

- **Share as read-only**: Indicates that the users in the forecast hierarchy can share the forecast with view permission.

- **Share as read and adjust rollups**: Indicates that the forecast can be shared with either the view only permission, or read and adjust permission. If you want to be able to share the forecast with different levels of access to different users, then select this setting.

## Share a forecast

You can share a forecast with anyone in your hierarchy or outside of your hierarchy and specify the access level (such as read or read and adjust rollup) that you want to give the user. For example, Henry, the Sales Manager wants one of his direct reports, Serena Davis, to manage the forecasts while he's on vacation. He can share his forecast hierarchy with Serena and assign the appropriate permissions.

1.  Go to **Performance &gt; Forecasts** in the Sales Hub sitemap.

You will now see the **Share** icon ![](media/image5.png) next to the forecasts that are enabled for sharing. If you do not see the Share icon, contact your administrator to enable forecast sharing.

2.  Select the **Share** icon ![](media/image5.png) next to a specific forecast record or hierarchy.

3.  In the **Sharing** dialog, specify the users with whom you want to share the forecast and select the pencil icon to specify the access level.

**Note:** You can specify different level of access for each user if your administrator has set the **Share as read and adjust rollups** option.

![Graphical user interface  text  application Description automatically generated](media/image6.png)

The selected forecast record or hierarchy is shared with the specified users.

## Stop sharing a forecast

To stop sharing a forecast from a user, select the **Share** icon listed next to the forecast record. In the **Sharing** dialog, find the user you want to stop sharing with and select the **Delete** icon next to the username. To stop sharing the entire forecast hierarchy from all the users, your administrator needs to disable the sharing option for the forecast. For more information, see [Enable or disable forecast sharing](#enable-or-disable-forecast-sharing).

