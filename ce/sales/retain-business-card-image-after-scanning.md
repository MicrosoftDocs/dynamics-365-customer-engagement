---
title: "Enable or disable saving of business card image (Dynamics 365 Sales) | MicrosoftDocs"
description: "Configure whether to retain the business card image in Dynamics 365 Sales after it is scanned."
ms.date: 10/26/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---
# Enable or disable saving of business card image 

By default, any business card that is scanned is stored as an image and associated with the **Lead** or **Contact** record. A system administrator can configure this option to enable or disable this setting.

## License and role requirements
| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|



## Enable or disable saving

You can enable or disable this option from the **App Settings** page in Sales Hub or **System Settings** page in Power Platform.

**To enable or disable from the App settings page**

1. In the Sales Hub app, select the **Change area** icon
    ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area")
    in the lower-left corner and then select **App Settings**.

2. Under **General Settings**, select **Overview**.
1. Select **Manage** next to **Business card scan**.  
1. Set **Scan and digitize business cards** to **Yes** or **No** depending on whether your organization wants to save and associate the business card images with the contact or lead record.
1. Save the changes.

**To enable or disable from the System Settings page**

1.  In your app, select the **Settings** icon, and then select **Advanced Settings**.

    > [!div class="mx-imgBorder"]
    > ![Advanced Settings option on the Settings menu.](media/advanced-settings-option.png "Advanced Settings option on the Settings menu")

    The **Business Management** page opens.

2. On the navigation bar, select **Settings**, and then under **System**, select **Administration**.

3. Select **System Settings**.

4. On the **Sales** tab, set the **Always retain business card images after scanning option** to **Yes** or **No** depending on whether your organization wants to save and associate the business card images with the contact or lead record. 
1. Save the changes.



[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Scan business cards](scan-business-cards.md)  
[Customize the business card scanner control](customize-business-card-scan-control.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
