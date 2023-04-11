---
title: Prerequisites for the Dynamics 365 Sales mobile app
description: Learn about the prerequisites for the Dynamics 365 Sales mobile app
ms.date: 02/27/2023
ms.topic: article
author: sbmjais
ms.author: shjais
---

# Prerequisites for the Dynamics 365 Sales mobile app 

The Dynamics 365 Sales mobile app is an intuitive mobile experience that offers quick access to customer information and makes it easy to keep this information current. This simplifies customer relationship management and helps sellers focus on selling. 

Field sellers spend a lot of time on the road, traveling to meet customers. "On-the-go" time can become productive time with this mobile app, which is available on iOS and Android.

Before field sellers can use the Dynamics 365 Sales mobile app, you must ensure that the following prerequisites are met:

- To get the optimal mobile experience:
    - It is recommended to enable relevance search for the environment. More information: [Configure relevance search to improve search results and performance](/power-platform/admin/configure-relevance-search-organization)
    - It is recommended to have Exchange Online.
- To set a regarding record for a meeting, you must:
    - Enable server-side synchronization in your environment. More information: [Server-side synchronization](/power-platform/admin/server-side-synchronization).
    - Approve the email address. More information: [Approve mailboxes](/power-platform/admin/connect-exchange-online#approve-mailboxes)
-	The mobile app users must have the following permissions:   
    -	Read permission for [Organization table](/power-apps/developer/data-platform/reference/entities/organization).
    -	Read permission for [Mailbox table](/dynamics365/customer-engagement/web-api/mailbox?view=dynamics-ce-odata-9&preserve-view=true).
    -	[**Dynamics 365 for mobile**](../../mobile-app/set-up-dynamics-365-for-phones-and-dynamics-365-for-tablets.md#required-privileges) privilege.

> [!NOTE]
> - If the Dynamics 365 Sales mobile app is launched by a user having [mobile offline profile](../../mobile-app/setup-mobile-offline.md) defined, the app's user interface is displayed using Unified Interface (same as in Dynamics 365 for phones).
> - If the Dynamics 365 Sales mobile app is launched on a tablet device, the app's user interface is displayed using Unified Interface (same as in Dynamics 365 for tablets).

## What's next

After all the prerequisites are met for the Dynamics 365 Sales mobile app, field sellers can install it on their [iOS](install-mobile-app.md#install-the-app-on-ios) and [Android](install-mobile-app.md#install-the-app-on-android) devices. 

### See also

[Use the Dynamics 365 Sales mobile app](use-sales-mobile-app.md)    
[Learn the basics](learn-basics-mobile-app.md)  
[Guidance on the best mobile experience for your sales users](https://community.dynamics.com/365/dynamics-365-fasttrack/b/dynamics-365-fasttrack-blog/posts/guidance-on-best-mobile-experience-for-your-sales-users)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
