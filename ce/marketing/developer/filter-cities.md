---
title: "Filter cities based on countries using lookup fields and custom entities (Dynamics 365 Marketing Developer Guide) | Microsoft Docs"
description: "Learn how to filter cities based on countries in marketing forms using lookup fields and custom entities in Dynamics 365 Marketing."
ms.date: 07/13/2022
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Filter cities based on countries using lookup fields and custom entities

To make marketing forms easier to navigate, you may want to filter cities based on the Country that a user selects. Out-of-the-box form fields do not support this functionality because City (`address1_country`) and Country (`address1_city`) properties are a "single line of text" type. To implement filtering, you will need to first customize the Contact entity, then leverage lookup fields.

## Necessary steps

1. Create Country and City entities
1. Add an N:1 relation and lookup field to the City entity that links the Country to the City
1. Add read permission for custom entities to the Marketing Services User so the service can use them for lookup
1. Customize the Contact entity to use lookup fields for Country and City
1. Add the City and Country to the sidebar
1. Create City and Country records
1. Create lookup form fields for City and Country
1. Enable filtering for the City lookup in the form designer (this will be possible only if all the previous steps are done correctly)
1. Publish and host the form

## Create Country and City entities

Before you can use lookup fields, you need custom entities that you are going to look up.

To create the custom entities, go to the top bar and navigate to **Settings** > **Advanced Settings**. You will be taken to a page titled Business Management. On this page, select the drop-down next to the word **Settings** in the top menu bar, then go to **Customizations** > **Customize the system**. A new window will open. Expand **Components** and select **New** > **Entity**.

Enter the Display Name, Plural Name, set the Ownership to Organization, and select Marketing in "Areas that display this entity." Next, enable Auditing, Change Tracking, and Enable for Unified Client.

On the **Primary Field** tab, leave the Name as the Primary field.

Repeat the above steps for both entities (City and Country).

Learn more about creating custom entities: [Create a custom entity](/dynamics365/customerengagement/on-premises/customize/create-entities).

## Add an N:1 relation and lookup field to the City entity that links the Country to the City

To know which City corresponds with which Country, you will need to establish a relationship between the two entitles. Countries have multiple cities, but each City belongs to only one Country, so you will use an N:1 relationship on the City entity.

To create the relationship, go back to the **Components** menu, expand the **Entities** section, and navigate to the newly created City entity. Expand the entity by selecting the arrow next to its name then select **N:1 relationships**. A pane will open displaying the relationships for the entity. Select **New Many-to-1 Relationship** from the top menu bar of the pane.

For the primary entity, select Country and enter the Relationship Name, Lookup Field Display Name, and Lookup Field Name.

Add the Country lookup field to City's main form.

Finally, save and publish the customization.

## Add read permission for service user

To add a new privilege to an existing role, go back to the main Dynamics 365 Marketing screen, then navigate to **Settings** > **Advanced settings**. You will be taken to a page titled Business Management. On this page, select the drop-down next to the word **Settings** in the top menu bar, then select **Security**. On the **Security** page, select **Security Roles**.

Select the **Marketing Service User Extensible Role**. A new window will open. Select the **Custom Entities** tab and add read privileges for the new entities.

Learn more about adding privileges for the service user: [Adding lookup fields and troubleshooting](/dynamics365/marketing/marketing-fields#adding-lookup-fields-and-troubleshooting).

## Customize the Contact entity to use lookup fields for Country and City

Now that you have custom entities set up, you will create lookup fields on the Contact entity so that you can use them instead of text fields.

To start, go back to the main Dynamics 365 Marketing screen, then navigate to **Settings** > **Advanced Settings**. You will be taken to a page titled Business Management. On this page, select the drop-down next to the word **Settings** in the top menu bar, then go to **Customizations** > **Customize the system**. In the left pane, go to **Components** > **Entities** > **Contact**. Expand the entity by selecting the arrow next to its name then select **Fields**.

Create a new field for the City lookup by selecting the **New** button in the top bar of the pane. Give the field a Display Name and a Name. Choose **Lookup** for Data Type and select the City entity name for Target Record Type.

Repeat the same field creation process for the Country lookup.

Next, add the newly created fields to the main Contact form to make them visible in the UI.

Save and publish the customizations.

## Add City and Country to the sidebar

Now, you will need to create City and Country records that will be used on your forms. But before you can do that, you will need to add a way to navigate to the new entities from the Marketing app. To do so, go back to the main Dynamics 365 Marketing screen. Select **Marketing** on the top left of the page to open the **Apps** window. Then select the three dots on the Marketing app tile and select **Open in App Designer**.

> [!div class="mx-imgBorder"]
> ![Open App Designer screenshot.](../media/filter-cities-apps.png "Open App Designer screenshot")

Add the new City and Country entities by navigating to **Components** > **Artifacts** > **Entities**.

> [!div class="mx-imgBorder"]
> ![Adding the entities screenshot.](../media/filter-cities-add-entities.png "Adding the entities screenshot")

To edit the site map, select the pencil next to the site map at the top. Add a new group called **Lookups**.

> [!div class="mx-imgBorder"]
> ![Add a group to the sitemap screenshot.](../media/filter-cities-site-map.png "Add a group to the sitemap screenshot")

Add entity sub areas for City and Country.

> [!div class="mx-imgBorder"]
> ![Add entity sub areas screenshot.](../media/filter-cities-sub-area.png "Add entity sub areas screenshot")

To finish, select **Save**, then **Publish**, and the **Play**.

## Create countries and cities

Now, you are all set with customizations and you can create a marketing form that filters cities based on country.

To do this, first, create the country and city data.

> [!div class="mx-imgBorder"]
> ![Screenshot of adding city data.](../media/filter-cities-city-data.png "Screenshot of adding city data")

## Create lookup form fields for City and Country

To use the lookup properties in your marketing forms, you need to create lookup form fields. You can remove existing city and country fields if you are not planning to use out-of-the-box text fields.

City lookup form field:

> [!div class="mx-imgBorder"]
> ![Screenshot of creating the city lookup form field.](../media/filter-cities-city-lookup.png "Screenshot of creating the city lookup form field")

Country lookup form field:

> [!div class="mx-imgBorder"]
> ![Screenshot of creating the country lookup form field.](../media/filter-cities-country-lookup.png "Screenshot of creating the country lookup form field")

## Enable filtering for City lookup in Form Designer

Next, create a new marketing form that uses the new fields. Because the lookup fields are mapping to Contact only, the form needs to update Contacts only. If you want to use them with leads, you will need to repeat the fourth step (Customize the Contact entity to use lookup fields for Country and City) with the Lead entity. Make sure to use lookup form fields.

> [!div class="mx-imgBorder"]
> ![Screenshot of adding lookup fields to the marketing form.](../media/filter-cities-marketing-form.png "Screenshot of adding lookup fields to the marketing form")

Lastly, you need to enable filtering. Select the city field and go to the **Properties** pane. Select the **Filter by** dropdown and select **Country Lookup**. If this option is missing, then relevance search is not correctly configured. Go back to step three (Add read permission for service user) and make sure that all properties are added to both "Add view columns" and "Add search columns" in the "Quick Find Active..." view. Then, the number in the brackets should be the same as in the screenshot below.

> [!div class="mx-imgBorder"]
> ![Screenshot of enabling filtering in the marketing form.](../media/filter-cities-enable-filtering.png "Screenshot of enabling filtering in the marketing form")

## Publish and host the form

The form can be hosted on a marketing page or an external site. In both cases, Cities will be filtered based on the Country value.