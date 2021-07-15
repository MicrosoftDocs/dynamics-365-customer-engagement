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

> [!IMPORTANT]
> A preview is a feature that is not complete, but is made available to you before general availability so you can evaluate the preview and provide feedback to Microsoft. Previews may have restricted functionality and may employ reduced or different privacy, security, or compliance commitments than a commercial version. As such, previews are not intended for production use, which means they are not meant for "live" Customer Data, Personal Data, or other data that is subject to heightened compliance requirements. Use of such data is at your sole risk and it's your sole responsibility to notify your end users about not including personal or sensitive information with their use of previews, as appropriate. We don't provide support for previews and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions. This preview, and any one-off support Microsoft may elect to provide, is provided "as-is," "with all faults," "as available," and without warranty.

The new deal manger workspace helps sellers be more productive and efficient. Sellers can get better visibility into their pipeline, drill into opportunities, view important sales metrics, update information, and take action on their opportunities&mdash;all from a single interface. 

As an administrator, you must enable the preview and grant access to specific security roles that will need to access to the deal manager.  

## Access deal manager settings

Access the deal manager settings page to enable the deal manager preview, grant access to users, and customize the grid and charts. If you're using the Sales Hub app, use the **App Settings** page to access the deal manager settings. If you're using a custom app, add the deal manager settings and the deal manager workspace in Power Apps settings.

### Access deal manager settings in Sales Hub

1. In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") in the lower-left corner, and then select **App Settings**.  
1. Under **General Settings**, select **Deal manager (preview)**.

<a id="dmincustomapp"></a>

### Add deal manager settings and deal manager workspace in custom app
<!--note from editor: Image file names should be all lowercase, including the extension. I don't dare change this, though, in case it's called from other topics. (This is less a DevOps requirement than a pattern we follow in BACX, I think.) -->
1. Sign in to [Power Apps](https://make.powerapps.com/).
1. Select the environment and then select **Apps**.
     :::image type="content" source="media/powerapps-UI.PNG" alt-text="Screenshot of the Power Apps UI with Environment and Apps highlighted.":::
1. Select your custom app, and then select **Edit**.
1. In the **App Designer**, edit the **Site Map**.
1. To add the deal manager settings page, add a subarea component, select the **Type** as **URL** and set the **URL** to:  
     ```
    /main.aspx?appid=860f4439-9cf8-ea11-a813-000d3a54419d&pagetype=control&controlName=MscrmControls.Sales.DealManagerSettings.DealManagerSettings
    ``` 
    :::image type="content" source="media/appdesigner-subarea.PNG" alt-text="Screenshot of the subarea component in the App designer.":::  
1. To add the deal manager workspace, add a subarea component, select the **Type** as *URL* and set the **URL** to:
    ```
    /main.aspx?pagetype=control&controlName=MscrmControls.Sales.DealManager.DealManager&data={"entityType":"opportunity"}
    ```
1. Save and publish the changes.
1. Open your custom app, and verify that you're able to access the deal manager settings and workspace pages that you just added.


## Enable the preview

1. Access the deal manager settings page. 
1. Select **Get started** to enable the preview.
1. Select the roles that you want to give access to, and then select **Publish**.

The deal manager workspace is now available to administrators and the roles you selected. 

### See also

[Deal manager (Preview)](deal-manager-overview.md)

