---
title: Bookable Resource as a Pricing Dimension (Dynamics 365 for Project Service) | MicrosoftDocs
description: Setup required for using Bookable Resource as a pricing dimension in project service solution 
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

# Using Bookable Resource as a Pricing Dimension

## Step 1. Create a pricing dimension solution
As a first step, we will need to create a Solution for the Pricing dimensions. If you already have a pricing dimension solution, then you can make your changes in that solution. If you have not created a new Pricing Dimension solution for your Organization, follow all of the instructions in [Steps 1-4: Create custom fields and entities in the Power Apps platform](PD-Common-steps.md)

## Step 2. Add Bookable Resource to forms and views

The next step is to make these fields visible on the UI in Pricing dimension solution. For this, you will need to walkthrough all the forms and views of the key Project Service entities and add these fields to the forms and views of those entities.
Below is the comprehensive list of the out-of-thebox forms and views by entity that will need to be updated with the new fields. -If you have any additional views or forms in your customizations on these entities, please add the new fields to those as well.
Open the Solution Explorer for the pricing dimension solution and “Publish All Customizations.”


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

## Step 3. Set up bookable resource as a pricing dimension

Navigate to Project Service->Settings->Parameters and open the Parameter page. Then open the tab “Amount-Based Pricing Dimensions.” The grid on the tab shows the records in the Pricing Dimensions entity in Project Service. Add Bookable Resource to this list of Pricing Dimensions as msydyn_bookableresource. Decide the context in which Bookable Resource works as a pricing dimension and set "Applicable to cost" and "Applicable to sales" values. Dimension Type should be “amount-based”. Decide the priority for Bookable Resource in the cost and sales context. Usually when present as a pricing dimension, Bookable Resource has the highest priority so setting this to 1 (or 0 depending on how you count the priority) would ensure that behavior.

## Step 4. Set up pricing dimension field names

Whenever the field name of a pricing dmension in the Role Price table is different from its field name in any of other entities where price defaulting needs to work, the Pricing dimension record for that needs to be made aware of the entity in which it is named differently.    
For Bookable Resource, the project team members entity in Project Service has a slightly different field name it(msdyn_bookableresourceid) from what it is called on the Role price entity (msdyn_bookableresource). So the pricing dimension record for msydn_bookableresource must be made aware of this. Navigate to the dimension page of msdyn_bookableresource by double-clicking on the row in the pricing dimensions grid.
The Main page for the pricing dimension of msdyn_bookableresource will open. On this page, find the "Related" tab and click on "Pricing Dimension Field Names".

*Pricing dimension field names tab*
 ![Pricing dimension field names tab](media/PD-fieldname.png)

On the associated view that opens, click on "Add New Pricing Dimension Field Names".

*Add New Pricing Dimension Field Names*
 ![Add New Pricing Dimension Field Names](media/Add-NewPD-fieldname.png)


This opens the "New Pricing dimension field name" page for msdyn_bookableresource. Add the msdyn_projectteam to the "Entity Locigal Name" field and msdyn_bookableresourceid to the "Field Name" field. Save the record.

*New Pricing dimension field name form*
 ![New Pricing dimension field name form](media/PD-fieldname-Added.png)




