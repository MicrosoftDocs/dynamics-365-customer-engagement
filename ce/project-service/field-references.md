---
title: Add custom fields to price setup and transactional entities 
description: This topic provides information about adding custom fields to price setup and transactional entities. 
author: Rumant
manager: eichimur
ms.custom:
  - dyn365-projectservice
ms.date: 11/20/2018
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

# Add custom fields to price setup and transactional entities 
This topic assumes that you have completed the procedures in the topic, [Create custom fields and entities](create-custom-fields-entities.md). If you haven't completed those procedures, go back and complete them and then return to this topic. In this topic, the procedures will show you how to add the required custom field references to entities and to the UI elements such as forms and views.

## Add custom pricing dimension fields 
After custom fields and entities have been created, the next step is to make price setup and transactional entities aware of your custom entities or option sets by creating reference fields. Depending on whether your pricing dimensions list includes option set dimensions or entity dimensions or both, follow only the steps in **Option-set based custom pricing dimensions** or **Entity-based custom pricing dimensions**, or both, respectively.

### Option-set based custom pricing dimensions:
When a custom pricing dimension is an option-set, you will add it as a field to key Project Service entities. In our example, **Resource Work Location** and **Resource Work Hours** are option-set based pricing dimensions. These first must be added as fields to the pricing entities, **Role Price** and **Role Price Markup** entities.

1.In PSA, click **Settings** > **Solutions**, and then double-click to open  **\<your organization name> pricing dimensions** 
2. In the left navigation on the Solution Explorer, select  **Entities > Role Price**.
3. Expand the entity **Role Price** on the left navigation pane and select **Fields**
4. Click **New** to create a new field called **Resource Work Location** select **Option set** as the type of field 
5. Then select to **"Use an existing Option set"** and pick the **Resource Work Location** option set that was created, and then click **Save**.
6. Repeat the same steps for adding this field to **Role Price Markup** entity 
7. Repeat the steps 1-5 correspondingly for **Resource Work Hours** option set.

[!IMPORTANT]
> When you add fields on entities, keep the field name the same across all of the entities that you are adding the field to. 

> ![Adding Resource Work Location to Role Price](media/RWL-Field.png)

In the sales and estimation phases for a project, estimates of the work effort that is required to complete **Local** and **Onsite**, and in **Regular hours** and **Overtime hours** to estimate the value of the Quote/Project accurately. The fields **Resource Work Location** and **Resource Work Hours** will be added to the estimation entities, **Quote Line Detail**, **Contract Line detail**, **Project Team Member**, and **Estimate Line**.

1. In PSA, click **Settings** > **Solutions**, and then double-click to open  **\<your organization name> pricing dimensions** 
2. In the left navigation on the Solution Explorer, select  **Entities > Quote Line Detail**.
3. Expand the entity **Quote Line Detail** on the left navigation pane and select **Fields**
4. Click **New** to create a new field called **Resource Work Location** select **Option set** as the type of field 
5. Then select to **"Use an existing Option set"** and pick the **Resource Work Location** option set that was created, and then click **Save**.
6. Repeat the same steps for adding this field to **Project Contract line detail**, **Project Team Member** and **Estimate Line** entities
7. Repeat the steps 1-6 correspondingly for **Resource Work Hours** option set. 

> ![Adding Resource Work Location to Estimate Line](media/RWL-Default-Value.png)


Taking the scenario through to Delivery and Invoicing phases, we need to price the work done accurately based on whether it was “Local” or “Onsite” performed during “Regular hours” or “Overtime” on the Project Actuals. We will need to add “Resource Work Location” and “Resource Work hours” as fields to Time Entry, Actual, Invoice Line Detail, and Journal Line entities.

1. In PSA, click **Settings** > **Solutions**, and then double-click to open  **\<your organization name> pricing dimensions** 
2. In the left navigation on the Solution Explorer, select  **Entities > Time Entry**.
3. Expand the entity **Quote Line Detail** on the left navigation pane and select **Fields**
4. Click **New** to create a new field called **Resource Work Location** select **Option set** as the type of field 
5. Then select to **"Use an existing Option set"** and pick the **Resource Work Location** option set that was created, and then click **Save**.
6. Repeat the same steps for adding this field to **Actual**, **Invoice Line Detail** and **Journal Line** entities
7. Repeat the steps 1-6 correspondingly for **Resource Work Hours** option set. 

*Adding Resource Work Location to time entry*
> ![Adding Resource Work Location to Time Entry](media/RWL-time-entry.png)

This completes the schema changes required for Option-set based custom dimensions

### Entity-based custom pricing dimensions

In the scenario where the custom pricing dimension is an entity, you will be adding 1:N relationships between the dimension entity and key Project Service entities. In our example, it is reasonable to expect that Contoso assigns a standard title to each of its employees. So we will need a 1:N relationship from Standard Title to Bookable Resource or N:1 releationship if it were created from Bookable REsource to Standard Title.

1. In PSA, click **Settings** > **Solutions**, and then double-click to open  **\<your organization name> pricing dimensions** 
2. In the left navigation on the Solution Explorer, select  **Entities > Standard Title**.
3. Expand the entity **Standard Title** on the left navigation pane and select **1:N Relationships**
4. Click **New** to create a new 1:N relationship called **Standard Title to Bookable Resource**, with the required information and then click **Save**.

*Standard Title to Bookable Resource*
> ![Adding Standard Title as a reference field to Bookable Resource](media/ST-BR.png)

As the next step, Standard Title will also need to be added to Project Service Pricing entities: Role Price and Role Price Markup entities. This will also be done using 1:N relationships between Standard Title entities and the Role Price entity and Standard Title and Role Price Markup entities.

1. In the left navigation on the Solution Explorer, select  **Entities > Standard Title**.
3. Expand the entity **Standard Title** on the left navigation pane and select **1:N Relationships**
4. Click **New** to create a new 1:N relationship called **Standard Title to Role Price**, with the required information and then click **Save**.
5. Repeat these steps to create 1:N relationships from Standard Title to Role Price Markup entities

And to extend the example scenario, to the sales and estimation phases, we will need to estimate work effort required for each standard title to price the Quote/Project. So we will need 1:N relationships from Standard Title to each of these estimation entities in Project Service: Quote line Detail, Project Contract Line Detail, Project Team Member, and Estimate Line

6. Repeat these steps to create 1:N relationships from Standard Title to Quote line Detail, Project Contract Line Detail, Project Team Member, and Estimate Line

*Standard Title to Estimate Line*
> ![Adding Standard Title as a reference field to Estimate Line](media/ST-Estimate-Line.png)

Continuing the scenario through to Delivery and Invoicing phases, we will need to price the work done by each standard title accurately on the Project Actuals, so we will need 1:N relationships from Standard Title to Time Entry, Actual, Invoice Line Detail, and Journal Line entities.
7. Repeat these steps to create 1:N relationships from Standard Title to Time Entry, Actual, Invoice Line Detail, and Journal Line entities.

*Standard Title to Time Entry*
> ![Adding Standard Title as a reference field to Time Entry](media/ST-Mapping.png)

## Step 6. Setup Dimension value defaulting using the mappings features of the platform

In the context of Time Entry, it would be great to have the system default the standard title on the Time Entry from the Bookable Resource that is recording the time entry, so we will also add field mappings on the 1:N relationship from Bookable Resource to Time Entry.

1.In the left navigation on the Solution Explorer, select  **Entities > Standard Title**.
3. Expand the entity **Standard Title** on the left navigation pane and select **1:N Relationships**
4. Click **Bookable Resource to Time Entry** relationship and double click to open it. On the relationship window, left navigation, click on **Use Field mappings** and click on **New** to create a new field mapping between the **Standard Titile** field on Bookable Resource entity to the **Standard Title** reference field on **Time Entry** entity 

*Standard Title on Bookable Resource to Standard Title on Time Entry - Field Mappings for defaulting*
> ![Setup field mappings to allow defaulting of Standard Title from Bookable Resource to Time Entry](media/ST-Mapping2.png)


This completes the schema changes required for Entity-based custom dimensions

## Step 7. Add custom fields to forms, views and business rules

Once you have made all the required schema changes, the next step is to make these fields visible on the UI. For this, you will need to walkthrough the relevant forms and views of these entities and add these fields to the forms and views.
1. Open the form or the view 
2. On the right navigation pane, select the field and drag it on to the form canvas. If it is a view that you are editing, use the right navigation page and click on **Add fields** and in the Field lisitng dilaog select that fields that you need and click on **Ok**

Below is the comprehensive list of the out-of-the-box forms and views by entity that will need to be updated with the new fields. If you have any additional views or forms in your customizations on these entities, please add the new fields to those as well.

| Project Service Entity        | Forms that need the new field   |Views that need the new field      |
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

Your custom fields may also need to be added on Business rule depending on what business rules you have defined. One out-of-the-box example is for the Business Rule "Editablity of Time Entry based on status". This rule defines which fields need to be locked when the Time Entry is in a non-editbale status such as "Approved". Add fields to this business rule so that the fields are locked for editing when the Time Entry is in a status other than Draft or Returned.
