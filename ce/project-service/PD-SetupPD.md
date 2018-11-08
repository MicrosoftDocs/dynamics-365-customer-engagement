---
title: Setup pricing dimensions in Project Service (Dynamics 365 for Project Service) | MicrosoftDocs
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

# 8. Set up custom fields as pricing dimensions

Navigate to Project Service->Settings->Parameters and open the Parameter page. Then open the tab “Amount-Based Pricing Dimensions.” The grid on the tab show the records in the Pricing Dimensions entity in Project Service.

By default, Project Service installation creates 2 rows in the grid on this tab:

  •   Msdyn_resourcecategory (Role)
  
  •   Msdyn_OrganizationalUnit (Organizational Unit)

These two rows in the pricing dimension table should not be deleted; however, if you do not need them, you can make them not applicable in a specific context by setting “Applicable to Cost”=No, “Applicable to Sales” = No, “Applicable to Purchase” = No. Setting these attribute values to “No” for a pricing dimension has the same effect of not having this field as a pricing dimensions.

For a field to become a pricing dimension, it should be 

1. Created as a field in the Role Price AND Role Price markup entities (as shown in Add custom pricing dimension fields to price setup and transactional entities)

2. Created as a row in the Pricing Dimension table

For our example, we will add pricing dimension rows as follows:

*Amount - based Pricing Dimension Rows*
![Amount - based Pricing Dimension Rows](media/Amt-based-PD.png)

Notice that Resource Work hours has been added as a Markup-based dimension and hence shows up in the tab for Markup based dimension.

*Markup - based Pricing Dimension Rows*
![Markup - based Pricing Dimension Rows](media/Markup-based-PD.png)


**_Any change to pricing dimension data in this table, existing or newly created is propagated to the Project Service pricing business logic only after the cache is refreshed. The cache refresh time can be upto 10 minutes. So, allow that length of time to see the changes in price defaulting logic that must result from changes to the Pricing Dimension data._**

## Understanding the attributes of the Pricing dimensions table

### Pricing Dimension Name:

This value should be the exact same as the schema name of the field added to the Role Price table for custom pricing dimensions. Adding fields to Role Price table was detailed in sections Option-set based custom pricing dimensions and Entity-based custom pricing dimensions.

### Type of dimension:

  There can be 2 types of pricing dimensions:
  
   #### Amount-based dimensions
  
   These are dimensions where Project Service will match the dimension values from the input context to the dimension values on Role       Price line and default the price/cost directly from the Role Price table.
      
   #### Markup-based dimensions
  
   These are dimensions where Project Service will adopt a 3-step process to get the price/cost.
       1. Project Service will match the non-markup-based dimension values from the input context to the Role Price line to get the base rate.
        2. Project Service will match ALL dimension values from the input context to the Role Price Markup line to get a markup %.
        3. Project Service will then apply the markup % from the second step to the base rate obtained from the Role price table in the first step to arrive at final price/cost.
   
   Let’s look at a simple example to illustrate the calculation of price markups.
      ROLE
      ORG UNIT
      WORK LOCATION
      STD. TITLE
      RESOURCE WORK HOURS(REGULAR TIME, OVERTIME)
      MARK UP
      Contoso India Onsite
      Overtime 15
      Contoso India
      Local
      Overtime
      10
      Contoso US Onsite
      Overtime 20

If a resource from Contoso India working onsite whose base rate is 100 USD, logs 8 hours of Regular time and 2 hours of overtime on the time entry, the Project Service pricing engine will use the base rate of 100 for the 8 hours to record 800 USD. For the 2 hours overtime, Project Service will apply a markup of 15% to the base rate of 100 to get a unit price of 115 USD and will record a total cost of 230 USD.

### Applicable to Cost: 

Setting this flag to Yes indicates to the Project Service’s engine that it must use this dimension value from the input context to match to the Role Price and Role Price markup when retrieving the cost and/or markup rates.

### Applicable to Sales:

Setting this flag to Yes indicates to the Project Service’s engine that it must use this dimension value from the input context to match to the Role Price and Role Price markup when retrieving the bill rate or markup rates.

### Applicable to Purchase:

Setting this flag to Yes indicates to the Project Service’s engine that it must use this dimension value from the input context to match to the Role Price and Role Price markup when retrieving the purchase price. Currently Project Service does not have support for Subcontracting scenarios, so this field is not used. Once there is support for subcontracted pricing scenarios, this field will be used.

### Priority
Setting the Priority of a dimension helps Project Service pricing engine produce a price even when it cannot find an exact match between the input dimension values and the values from the Role Price or Role Price Markup tables. In this scenario, Project Service will use null values for unmatched dimension values by giving weightage to the dimensions in order of their priority.

  #### Cost priority
The value of the cost priority of a dimension will indicate the weightage of that dimension when matching against the setup of cost prices. The value of Cost Priority must be unique across Dimensions that are “applicable to cost.”

  #### Sales priority
The value of the sales priority of a dimension will indicate the weightage of that dimension when matching against the setup of sales prices or bill rates. The value of Sales Priority must be unique across Dimensions that are “applicable to sales.”
