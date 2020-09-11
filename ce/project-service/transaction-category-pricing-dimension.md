---
title: Use transaction category as a pricing dimension
description: This topic provides information about using a transaction category as a pricing dimension.
author: Rumant
manager: kfend
ms.custom: 
  - dyn365-projectservice
ms.date: 11/19/2018
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365PS
  - ProjectOperations
---

# Use transaction category as a pricing dimension
This topic shows how to use a transaction category as a pricing dimension. Before you begin, if you have not already created a pricing dimension solution, you will need to create a new one. If you already have a pricing dimension solution, then you can make your changes in that solution. If you have not created a new pricing dimension solution for your organization, complete the procedures in the [Create custom fields and entities](create-custom-fields-entities.md) topic.

## Add transaction category to forms and views
To make transaction category visible in the UI in the pricing dimension solution, you will need to walk through all the forms and views of the key entities and add these fields to the forms and views of those entities.
The following table is a comprehensive list of the out-of-the box forms and views, listed by entity, that will need to be updated with the new fields. If there any additional views or forms in your customizations on these entities, add the new fields to those as well.

|  Entity        | Forms     |Views        |
| ------------------------------|---------------------------------|----------------------------------|
|  Role Price|• Information |• Active Resource Category Prices<br> • Resource Category Price Associated View|
|  Role Price Markup|• Information|• Active Role Price Markup<br>• Role Price Markup Associated View|
|  Quote line detail|• Project Information<br>• Project Quick Create|• Active Quote Line Detail<br>• Combined Quote Line Details<br>• Quote Line Detail associated view|
|  Project Contract line detail|• Project Information<br>• Project Quick Create|• Combined Contract line Details<br>• Active Contract Line Details<br>• Contract Line Detail associated view|
|  Project Task|• Information<br>• New Form||
|  Project Team Member|• Information<br>• New Form|• Active Project Team Members<br>• Project Team Members<br>• Project Team members associated View|
|  Time Entry|• Information<br>• Create Time Entry|• My Time Entries By Date<br>• My time Entries for this week<br>• Time entries for approval|
|  Journal Line|• Information<br>• Quick create|• Active journal lines<br>• Journal Line associated view|
|  Invoice Line Detail|• Information<br>• Quick create|• Active Invoice Line Details<br>• Chargeable Invoice Transactions<br>• Complimentary Invoice Transactions<br>• Invoice Line Detail associated view<br>• Non-Chargeable Invoice Transactions|
|  Actual|• Information<br>• Active Actuals|• Actual Associated view|

## Set up transaction category as a pricing dimension

1. In the web interface, go to **Project Service** > **Settings** > **Parameters**. 
2. On the **Parameters** page, on the **Amount-Based Pricing Dimensions** tab, note the grid on the tab shows the records in the **Pricing Dimensions** entity.
3. Add **Transaction Category** to this list and set the **Applicable to Cost** and **Applicable to Sale** fields set to **Yes**.
4. In the **Dimension Type** field, select **Amount-based**, and then select the priority for **Transaction Category** related to cost and sales.
