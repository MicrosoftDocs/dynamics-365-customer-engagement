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


If you're using a custom app, in addition to enabling the customization of opportunity close form, you must also add the Opportunity Close entity to the custom app in the app designer. For more information, see [Add Opportunity Close entity to the custom app module](customize-opportunity-close-experience.md#add-entity-to-app) to learn how to add to entity to the app.


> [!IMPORTANT]
> With the April 2020 release, this setting is also available in the **App Settings** area of the Sales Hub app itself. To go to this setting:
> 1. At the bottom of the site map, select **Change area** ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**. 
> 2. In the site map, select **Overview**, and on the **Overview** page, select **Manage** for **Collect additional details about closed opportunities using custom form fields on the closing form**.


### See also

[Customize the Opportunity Close form](customize-opportunity-close-experience.md)  
[Close opportunities as won or lost](close-opportunity-won-lost-sales.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]