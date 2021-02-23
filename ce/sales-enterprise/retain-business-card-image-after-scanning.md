---
title: "Enable or disable saving of business card image (Dynamics 365 Sales) | MicrosoftDocs"
description: "Configure whether to retain the business card image in Dynamics 365 Sales after it is scanned."
ms.date: 02/03/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---


# Enable or disable saving of business card image

By default, any business card that is scanned is stored as an image and associated with the **Lead** or **Contact** record. A system administrator can configure this option to enable or disable this setting.

To enable or disable saving of a business card image:

1.  In your app, select the **Settings** icon, and then select **Advanced Settings**.

    > [!div class="mx-imgBorder"]
    > ![Advanced Settings option on the Settings menu](media/advanced-settings-option.png "Advanced Settings option on the Settings menu")

    The **Business Management** page opens.

2. On the navigation bar, select **Settings**, and then under **System**, select **Administration**.

3. Select **System Settings**.

4. On the **Sales** tab, set the **Always retain business card images after scanning option** to **Yes** or **No** depending on whether your organization wants to save and associate the business card images with the contact or lead record. 

5. Select **OK**.

> [!IMPORTANT]
> With the April 2020 release, this setting is also available in the **App Settings** area of the Sales Hub app itself. To go to this setting:
> 1. At the bottom of the site map, select **Change area** ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area") and then select **App Settings**. 
> 2. In the site map, select **Overview**, and on the **Overview** page, select **Manage** for **A quick, easy way to capture business card info**.


### See also

[Scan business cards](scan-business-cards.md)  
[Customize the business card scanner control](customize-business-card-scan-control.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]