---
title: Using Transaction Category in PSA as a pricing dimension for Time  | MicrosoftDocs
description: Introduction to setup of pricing dimensions in project service solution 
author: Rumant
manager: eichimur
ms.custom:
  - dyn365-projectservice
ms.date: 11/06/2018
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
---

# Using Transaction Category as a Pricing Dimension

**1. Create a pricing dimension solution:**

As a first step, we will need to create a Solution for the Pricing dimensions. If you already have a pricing dimension solution, then you can make your changes in that solution. If you have not created a new Pricing Dimension solution for your Organization, follow all of the instructions in Create a solution for pricing dimension changes: and Add all the required PSA entities and related components to the Pricing Dimension Solution

**2. Add Transaction Category to forms and views**

The next step is to make Transaction Category visible on the UI in Pricing dimension solution. For this, you will need to walkthrough all the forms and views of the key Project Service entities and add these fields to the forms and views of those entities.
Below is the comprehensive list of the out-of-the box forms and views by entity that will need to be updated with the new fields. -If you have any additional views or forms in your customizations on these entities, please add the new fields to those as well.

| Project Service Entity        | Forms that need the new field   |Views that nee the new field      |
| ------------------------------|---------------------------------|----------------------------------|
|1. Role Price|• Information |• Active Resource Category Prices<br> • Resource Category Price Associated View|
|2. Role Price Markup|• Information|• Active Role Price Markup<br>• Role Price Markup Associated View|
|3. Quote line detail|• Project Information<br>• Project Quick Create|• Active Quote Line Detail<br>• Combined Quote Line Details<br>• Quote Line Detail associated view|
|4. Project Contract line detail|• Project Information<br>• Project Quick Create|• Combined Invoice line Details<br>• Active Invoice Line Details<br>• Invoice Line Detail associated view|
|5. Project Team Member|• Information<br>• New Form|• Active Project Team Members<br>• Project Team Members<br>• Project Team members associated View|
|6. Time Entry|• Information<br>• Create Time Entry|• My Time Entries By Date<br>• My time Entries for this week<br>• Time entries for approval|
|7. Journal Line|• Information<br>• Quick create|• Active journal lines<br>• Journal Line associated view|
|8. Invoice Line Detail|• Information<br>• Quick create|• Active Invoice Line Details<br>• Chargeable Invoice Transactions<br>• Complimentary Invoice Transactions<br>• Invoice Line Detail associated view<br>• Non-Chargeable Invoice Transactions|
|9. Actual|• Information<br>• Active Actuals|• Actual Associated view|

**3. Set up transaction category as a pricing dimension**

Navigate to Project Service->Settings->Parameters and open the Parameter page. Then open the tab “Amount-Based Pricing Dimensions.” The grid on the tab shows the records in the Pricing Dimensions entity in Project Service. Add Transaction Category to this list of Pricing Dimensions with applicable to cost and applicable to sale set to “Yes”. Dimension Type should be “amount-based”. Decide the priority for Transaction Category in the cost and sales context.
