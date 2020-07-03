---
title: "Enable customization of the Opportunity Close form (Dynamics 365 Sales) | MicrosoftDocs"
description: "Enable the system customizers to customize the opportunity close experience in Dynamics 365 for Sales to enable sales reps to capture important details about why an opportunity was closed."
ms.date: 04/03/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Enable customization of the Opportunity Close form

To allow users in your organization to capture more relevant details about an opportunity closing, a system administrator can enable the customization of the Opportunity Close form.

> [!NOTE]
> The capability to customize the **Opportunity Close** form is supported only in the sales app built on Unified Interface.

To enable customization:

1.  In your app, on the navigation bar, select the **Settings** icon ![Settings icon on the navigation bar](media/settings-icon.png "Settings icon on the navigation bar"), and then select **Advanced Settings**.

    The **Business Management settings** page opens in a new browser tab.

1.  On the navigation bar, select **Settings**, and then select **Administration**.

2.  Select **System Settings**.

3.  In the **System Settings** dialog box, on the **Sales** tab, set the **Customize close opportunity form** field to **Yes**.

    > [!div class="mx-imgBorder"]
    > ![Customize opportunity close option in System Settings](media/system-setting-customize-close-opportunity-form.png "Customize opportunity close option in System Settings")

4.  Select **OK**.


## Verify that Opportunity Close entity is added to the app

Even after doing these steps, if the Opportunity Close quick create form isn't available while closing an opportunity, verify that the Opportunity Close entity is added to the app. By default, the Opportunity Close entity is added to the Sales Hub app. 

To verify:

1. In your app, select the **Settings** icon, and then select **Advanced Settings**.

    > [!div class="mx-imgBorder"]  
    > ![Advanced Settings link in the site map](media/advanced-settings-option.png "Advanced Settings link in the site map")

    The **Business Management settings** page opens in a new browser tab.

2. On the navigation bar, select **Settings** and then under **Application**, select **Apps**. 

3. On the Apps page, in the Sales Hub tile, select the **More Options** icon ![More Options icon](media/apps-more-options-icon.png "More Options icon"), and then select **Open in App Designer**.

4. In the app designer, on the right side, select the **Components** tab, and under **Artifacts**, select **Entities**.

5. In the entity list, check whether  the Opportunity Close entity is selected. If it is selected, it means that the entity is added to the app. If not, add the entity to the app. To learn how to add an entity to an app, see [Add components to your app](/powerapps/maker/model-driven-apps/build-first-model-driven-app#add-components-to-your-app).



> [!IMPORTANT]
With the April 2020 release, this setting is also available in the **App Settings** area of the Sales Hub app itself. To go to this setting:
> 1. At the bottom of the site map, select **Change area** ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**. 
> 2. In the site map, select **Overview**, and on the **Overview** page, select **Manage** for **Collect additional details about closed opportunities using custom form fields on the closing form**.


### See also

[Customize the Opportunity Close form](customize-opportunity-close-experience.md)  
[Close opportunities as won or lost](close-opportunity-won-lost-sales.md)
