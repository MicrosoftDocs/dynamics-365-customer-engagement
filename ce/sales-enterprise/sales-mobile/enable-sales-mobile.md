---
title: Enable the Dynamics 365 Sales mobile app
description: Instructions to enable the Dynamics 365 Sales mobile app
ms.date: 01/06/2020
ms.topic: article
ms.service: dynamics-365-sales
author: sbmjais
ms.author: shjais
manager: shujoshi
---

# Enable the Dynamics 365 Sales mobile app

[!INCLUDE [cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

The Dynamics 365 Sales mobile app is an intuitive mobile experience that offers quick access to customer information and makes it easy to keep this information current. This simplifies customer relationship management and helps sellers focus on selling. 

Field sellers spend a lot of time on the road, traveling to meet customers. "On-the-go" time can become productive time with this mobile app, which is available on iOS and Android.

Before field sellers can use the Dynamics 365 Sales mobile app, you must enable it.

> [!IMPORTANT]
>- For the Dynamics 365 Sales mobile app to work, you must enable relevance search for the environment in which you enable the mobile app. More information: [Configure relevance search to improve search results and performance](https://docs.microsoft.com/power-platform/admin/configure-relevance-search-organization)
>- To set a regarding record for a meeting, you must enable server-side synchronization in your environment. More information: [Server-side synchronization](https://docs.microsoft.com/power-platform/admin/server-side-synchronization).
>-	Users must have the following permissions:   
>       -	Read permission for [Organization Entity](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/developer/entities/organization).
>       -	Read permission for [Mailbox Entity](https://docs.microsoft.com/dynamics365/customer-engagement/web-api/mailbox?view=dynamics-ce-odata-9).
>       -	[**Dynamics 365 for mobile**](../../mobile-app/set-up-dynamics-365-for-phones-and-dynamics-365-for-tablets.md#required-privileges) privilege.

**To enable the Dynamics 365 Sales mobile app**

1. In Dynamics 365 Sales, select **Settings** ![Settings icon](../media/settings--button-the-nav-bar.png), and then select **Advanced Settings**.

    ![Advanced settings](media/advanced-settings-option.png "Advanced settings")

    The **Business Management** page opens in a new browser tab.

2. On the navigation bar, select **Settings**, and then under **System**, select **Administration**.

3. Select **System Settings**.

4. In the **System Settings** window, go to the **Mobile Client** tab.

5. Under **Dynamics 365 Sales mobile app (preview)**, read the terms and conditions, and then select **Yes**.

    ![Enable the mobile app in System Settings](media/system-settings-enable-app.png "Enable the mobile app in System Settings")

6. Select **OK**.

## What's next

After you enable the Dynamics 365 Sales mobile app, field sellers can install it on their [iOS](install-ios-app.md) and [Android](install-android-app.md) devices. 

### See also

[Use the Dynamics 365 Sales mobile app](use-sales-mobile-app.md)    
[Learn the basics](learn-basics-mobile-app.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]