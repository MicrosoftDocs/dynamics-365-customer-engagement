---
title: "Enable entities for mobile offline synchronization for Dynamics 365 for phones and tablets | MicrosoftDocs"
ms.custom: 
ms.date: 12/18/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: da282f05-9188-40ec-b835-d4e991609edc
caps.latest.revision: 7
ms.author: mkaur
author: mduelae
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Sales
---
# Enable entities for mobile offline synchronization

You can enable any entity for mobile offline that is enabled for mobile. By default, no entities are enabled for mobile offline , so you need to follow these steps for each entity you want to make available for users when they’re offline. You can find a list of entities available for mobile in [Entities and Dynamics 365 for phones and tablets](https://technet.microsoft.com/library/dn531159.aspx#BKMK_CustomEntity).  
  
 The following entities are enabled for mobile by default:  
  
-   Account  
  
-   Appointment  
  
-   Attachment  
  
-   Competitor  
  
-   Competitor Address  
  
-   Contact  
  
-   Email  
  
-   Lead  
  
-   Note  
  
-   Opportunity  
  
-   Opportunity Product  
  
-   Product  
  
-   Task  
  
-   Case  
  
-   Queue  
  
-   Queue Item  
  
-   SLA KPI Instance  
  
-   Entitlement  
  
-   Team  
  
-   User  
  
> [!WARNING]
>  Keep in mind that the amount of data you make available to users while they’re offline can affect the data usage rates for devices on cellular networks. The amount of data depends on:  
> 
> - The number of entities you enable for mobile offline  
>   -   The number of days you specify since records were last modified  
>   -   The filters you set while creating mobile offline profiles in [Create a mobile offline profile](create-mobile-offline-profile.md)  
  
1.  Go to **Settings > Customizations**.  
  
2.  Click **Customize the System**.  
  
3.  Expand **Entities** in the left pane.  
  
4.  Select the entity you want to enable for mobile offline (for example, **Account**).  
  
5.  Under **Outlook & Mobile**, select **Enable for mobile offline**.  
  
6.  Click **Organization data download filter** to filter the data and set the freshness of the data you want to make available offline. You can set up to three criteria when you define a filter. Select the field to filter by, select an operator, then set a value.  
  
     The entities that are enabled for mobile offline by default have **Modified On** set for **Last X Days** = 10, so the data modified or created in the last 10 days will be available for downloading to mobile devices.  
  
7.  Click **Save**.  
  
8.  When you’re done enabling entities for mobile offline, click **Publish** so your changes take effect.  
  
> [!NOTE]
>  Publishing customizations prompts the mobile apps to download changes when users next start their app, which can adversely affect their experience over slow connections.  
  
