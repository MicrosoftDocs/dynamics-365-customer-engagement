---
title: "Enable the deal manager workspace preview | MicrosoftDocs"
description: "As an administrator, enable the preview so that your sales teams can access the deal manager workspace and manage their pipelines efficiently."
ms.date: 11/29/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Preview: Enable the deal manager workspace 

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

The new deal manger workspace helps sellers be more productive and efficient. As an administrator, you must enable the preview and grant access to specific security roles that will need to access to the deal manager.  


## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Access deal manager settings

Access the deal manager settings page to enable the deal manager preview, grant access to users, and customize the grid and charts. 

- If you're using the Sales Hub app, use the **App Settings** page to access the deal manager settings. 
- If you're using a custom app, add the deal manager settings and the deal manager workspace in **Power Apps settings**.

### Access deal manager settings in Sales Hub

1. In the Sales Hub app, select **Change area** ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") in the lower-left corner, and then select **App Settings**.  

1. Under **General Settings**, select **Deal manager (preview)**.

<a id="dmincustomapp"></a>

### Add deal manager settings and deal manager workspace in custom app

**To add the deal manager settings page:**

1. Sign in to [Power Apps](https://make.powerapps.com/).

1. Select the environment and then select **Apps**.
     :::image type="content" source="media/powerapps-ui.PNG" alt-text="Screenshot of the Power Apps UI with Environment and Apps highlighted.":::
1. Select your custom app, and then select **Edit**.
1. In the **App Designer**, edit the **Site Map**.
1. Add a subarea for the deal manager settings page.

    :::image type="content" source="media/appdesigner-subarea.PNG" alt-text="Screenshot of the subarea component in the App designer."::: 
1. Update the following fields:
    - **Type:** URL
    - **URL:** 
        ```/main.aspx?appid=860f4439-9cf8-ea11-a813-000d3a54419d&pagetype=control&controlName=MscrmControls.Sales.DealManagerSettings.DealManagerSettings```
    - **Title:** Deal manager settings
    - **Advanced** > **Privileges** > **Entity**: Deal manager settings

1. After selecting the entity, select the **+** icon to update the privilege for the entity.  
    By default, all the privileges are selected. 

1. Clear all the checkboxes and select only the **Read** privilege.  
    This step ensures that only the security roles that you've granted access to can see and access the deal manager settings from the site map. 
      > [!IMPORTANT]
    > If you don't update the privilege, the deal manager related pages will be visible to all the users irrespective of their security role.
1. Repeat steps 5 through 8 to add the deal manager workspace page to your sitemap with the following values:
    - **Type:** URL
    - **URL:** 
        ```/main.aspx?pagetype=control&controlName=MscrmControls.Sales.DealManager.DealManager&data={"entityType":"opportunity"}```
    - **Title:** Deal manager
    - **Advanced** > **Privileges** > **Entity**: dealmanageraccess   

1. Save and publish the changes. 

1. Open your custom app, and verify that you're able to access the deal manager settings and workspace pages that you just added.



## Enable the preview

1. Open the [deal manager settings page](#access-deal-manager-settings). 

1. Select **Get started** to enable the preview.
1. Select the roles that you want to give access to, and then select **Publish**.

The deal manager workspace is now available to administrators and the roles you selected. 

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

- [Grant access to deal manager](grant-access-deal-manager.md)
- [Using the deal manager workspace](deal-manager-seller-overview.md)
