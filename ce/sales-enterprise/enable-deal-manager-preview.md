---
title: "Enable the deal manager workspace preview - Sales Enterprise | MicrosoftDocs"
description: "As an administrator, enable the preview so that your sales teams can access the deal manager workspace and manage their pipelines efficiently."
ms.date: 07/15/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Enable the preview for the deal manager workspace 

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

> [!NOTE]
> This feature is being rolled out in a phased manner across different regions. To verify the feature availability in your region, see the **Next Refresh Scheduled Date** for version 9.0.21072.10001 in the [Latest version availability](/dynamics365/released-versions/dynamics365sales) section. 

The new deal manger workspace helps sellers be more productive and efficient. As an administrator, you must enable the preview and grant access to specific security roles that will need to access to the deal manager.  

## Access deal manager settings

Access the deal manager settings page to enable the deal manager preview, grant access to users, and customize the grid and charts. 

- If you're using the Sales Hub app, use the **App Settings** page to access the deal manager settings. 
- If you're using a custom app, add the deal manager settings and the deal manager workspace in **Power Apps settings**.

### Access deal manager settings in Sales Hub

1. In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") in the lower-left corner, and then select **App Settings**.  

1. Under **General Settings**, select **Deal manager (preview)**.

<a id="dmincustomapp"></a>

### Add deal manager settings and deal manager workspace in custom app

1. Sign in to [Power Apps](https://make.powerapps.com/).

1. Select the environment and then select **Apps**.
     :::image type="content" source="media/powerapps-ui.PNG" alt-text="Screenshot of the Power Apps UI with Environment and Apps highlighted.":::
1. Select your custom app, and then select **Edit**.
1. In the **App Designer**, edit the **Site Map**.
1. To add the deal manager settings page, add a subarea component, select the **Type** as **URL** and copy the following value to the **URL** field:  
     ```
    /main.aspx?appid=860f4439-9cf8-ea11-a813-000d3a54419d&pagetype=control&controlName=MscrmControls.Sales.DealManagerSettings.DealManagerSettings
    ``` 
    :::image type="content" source="media/appdesigner-subarea.PNG" alt-text="Screenshot of the subarea component in the App designer.":::  
1. To add the deal manager workspace, add a subarea component, select the **Type** as *URL* and copy the following value to the **URL** field:

    ```
    /main.aspx?pagetype=control&controlName=MscrmControls.Sales.DealManager.DealManager&data={"entityType":"opportunity"}
    ```
1. Save and publish the changes.

1. Open your custom app, and verify that you're able to access the deal manager settings and workspace pages that you just added.



## Enable the preview

1. Open the [deal manager settings page](#access-deal-manager-settings). 

1. Select **Get started** to enable the preview.
1. Select the roles that you want to give access to, and then select **Publish**.

The deal manager workspace is now available to administrators and the roles you selected. 

### See also

- [Grant access to deal manager (Preview)](grant-access-deal-manager.md)
- [Using the deal manager workspace (Preview)](deal-manager-seller-overview.md)
