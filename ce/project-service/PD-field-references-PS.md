---
title: Creating custom field references to entities and User Interface elements of Project Service Solution  | MicrosoftDocs
description: 9-step walkthrough for using custom fields and/or custom entities as pricing dimensions  
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


Assuming you have completed the common steps 1 to 4 and created your pricing dimension solution, we will proceed to adding the required references for these custom fields to entities and the User Interface elements such as Forms and Views in Project Service solution

**5. Add custom pricing dimension fields to price setup and transactional entities**

Once custom fields and entities have been created, the next step is to make Project Service price setup and business transactional entities aware of your custom entities or option sets by creating reference fields. Depending on whether your pricing dimensions list includes option set dimensions or entity dimensions or both, follow only the steps in Option set custom pricing dimensions OR only Entity-based custom pricing dimensions, OR follow both.

**a. Option-set based custom pricing dimensions:**

In the scenario where a custom pricing dimension is an option-set, you will simply be adding it as a field to key Project Service entities. In our example scenario, Resource Work Location and Resource Work Hours are option-set based pricing dimensions. We will first need to add these as fields to the Project Service Pricing entities: Role Price and Role Price Markup entities.

**Important: When you add fields on the entities, it is important to keep the field name the same across all the entities that you will be adding it to. This will help to simplify the setup.**
 

*Adding Resource Work Location to Role Price*
> ![Adding Resource Work Location to Role Price](media/RWL-Field.png)
 


In the sales and estimation phases for a project, we will need to estimate work effort required to be done “Local” and “Onsite,” and in “Regular hours” and “Overtime hours” to estimate the value of the Quote/Project accurately. So, we will need to add “Resource Work Location” and “Resource Work Hours” as fields to each of these estimation entities in Project Service: Quote line Detail, Contract line detail, Project Team Member, and Estimate Line.

*Adding Resource Work Location to Estimate Line*
> ![Adding Resource Work Location to Estimate Line](media/RWL-Default-Value.png)

Taking the scenario through to Delivery and Invoicing phases, we need to price the work done accurately based on whether it was “Local” or “Onsite” performed during “Regular hours” or “Overtime” on the Project Actuals. We will need to add “Resource Work Location” and “Resource Work hours” as fields to Time Entry, Approval, Actual, Invoice Line Detail, and Journal Line entities.

*Adding Resource Work Location to time entry*
> ![Adding Resource Work Location to Time Entry](media/RWL-time-entry.png)

This completes the schema changes required for Option-set based custom dimensions

**b. Entity-based custom pricing dimensions**

In the scenario where the custom pricing dimension is an entity, you will be adding 1:N relationships between the dimension entity and key Project Service entities. In our example, it is reasonable to expect that Contoso assigns a standard title to each of its employees. So we will need a 1:N relationship from Standard Title to Bookable Resource.

*Standard Title to Bookable Resource*
> ![Adding Standard Title as a reference field to Bookable Resource](media/ST-BR.png)

As the next step, Standard Title will also need to be added to Project Service Pricing entities: Role Price and Role Price Markup entities. This will also be done using 1:N relationships between Standard Title entities and the Role Price entity and Standard Title and Role Price Markup entities.
And to extend the example scenario, to the sales and estimation phases, we will need to estimate work effort required for each standard title to price the Quote/Project. So we will need 1:N relationships from Standard Title to each of these estimation entities in Project Service: Quote line Detail, Project Contract Line Detail, Project Team Member, and Estimate Line


*Standard Title to Estimate Line*
> ![Adding Standard Title as a reference field to Estimate Line](media/ST-Estimate-Line.png)


Continuing the scenario through to Delivery and Invoicing phases, we will need to price the work done by each standard title accurately on the Project Actuals, so we will need 1:N relationships from Standard Title to Time Entry, Project Approval, Actual, Invoice Line Detail, and Journal Line entities.

*Standard Title to Time Entry*
> ![Adding Standard Title as a reference field to Time Entry](media/ST-Mapping.png)

6. Setup Dimension value defaulting using the mappings features of the platform:
In the context of Time Entry, it would be great to have the system default the standard title on the Time Entry from the Bookable Resource that is recording the time entry, so we will also add field mappings on the 1:N relationship from Bookable Resource to Time Entry.

*Standard Title on Bookable Rsource to Standard Title on Time Entry - Field Mappings for defaulting*
> ![Setup field mappings to allow defaulting of Standard Title from Bookable Resource to Time Entry](media/ST-Mapping2.png)


This completes the schema changes required for Entity-based custom dimensions

7. Add custom fields to forms and views
Once you have made all the required schema changes, the next step is to make these fields visible on the UI. For this, you will need to walkthrough the relevant forms and views of these entities and add these fields to the forms and views.
Below is the comprehensive list of the out-of-the-box forms and views by entity that will need to be updated with the new fields. If you have any additional views or forms in your customizations on these entities, please add the new fields to those as well.

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


